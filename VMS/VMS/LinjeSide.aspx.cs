using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VMS
{
    public partial class LinjeSide : System.Web.UI.Page
    {
        private Database db = new Database();
        private List<StudieInfo> studieInfoListe = new List<StudieInfo>();
        //Lager en liste som består av StudieInfo objekter
        private String sidensStudielinje = "Dataingeniør";
        //Statisk variabel så siden alltid har noe å vise


        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Under henter vi ut en string query. Denne inneholder
             * fagkoden siden skal vise. Denne kommer enten fra søk eller en lenke.
             * Denne blir formatert ved hjelp av formaterQueryString metoden deretter
             * brukes den i en SQL spørring
             */
            String uformatertQueryString = Request.Url.Query;
            String formatertQueryString = FormaterQueryString.FormaterString(uformatertQueryString);
            
            if (formatertQueryString != "" || formatertQueryString == null)
            {
                sidensStudielinje = formatertQueryString;
            }

            String query = "SELECT f.studieretning, f.fagnavn, f.fagkode, s.fakultet FROM fag as f, studier as s WHERE f.studieretning = @SidensStudielinje AND f.studieretning = s.studieretning";
            var cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@SidensStudielinje", sidensStudielinje);

            db.OpenConnection();
            String studieNavn = null;


            /*
             * Using passer på at objektet som blir definert inne i 
             * parantesene i blir "destroyed" eller tatt hånd om av 
             * garbage collector så fort krøllparantesene tar slutt
             * 
             * Innenfor while løkken legger vi inn informasjonen som er
             * hentet ut fra databasen i StudieInfo objekter som legges
             * i en liste.
             */
            using (MySqlDataReader leser = cmd.ExecuteReader())
            {
                if (!leser.HasRows)
                {
                    //Hvis sql feilet/ugyldig parameter til siden blir man sendt til default.aspx
                    Server.Transfer("Default.aspx");
                }
                while (leser.Read())
                {
                    studieNavn = leser["studieretning"].ToString();
                    studieInfoListe.Add(new StudieInfo()
                    {
                        Fagnavn = leser["fagnavn"].ToString(),
                        Fagkode = leser["fagkode"].ToString(),
                        Fakultet = leser["fakultet"].ToString()
                    });
                }
            }
            db.CloseConnection();


            studielinjeLbl.Text = "Studielinje: " + studieNavn;

            /*
            * Her lager vi en tekststreng ved hjelp av string builder klassen.
            * Vi legger tekststrengene som ble hentet utfra databasen og inn i 
            * FakultetInfo klassen inn i html kode. Vær iterasjon i foreachen tilsvarer
            * et StudieInfo objekt som igjen tilsvarer en rad i SQL spørringen.
            * Helt tilslutt blir hele tekststrengen skrevet ut til HTML, ved hjelp av InnerHtml.
            * 
            * Html formateringen under er for å legge dataene inn i en tabell og gjøre de til linker
            * så man enkelt kan navigere på nettsiden
            */
            StringBuilder sb = new StringBuilder();
            foreach (var info in studieInfoListe)
            {
                sb.Append(
                    "<tr>" +
                        "<td><a href = 'fagside.aspx?" + info.Fagkode + "'>" + info.Fagnavn + "</a></td>" +
                        "<td><a href = 'fagside.aspx?" + info.Fagkode + "'>" + info.Fagkode + "</a></td>" +
                        "<td><a href = 'fakultet.aspx?" + info.Fakultet + "'>" + info.Fakultet + "</a></td>" +
                    "</tr>");
            }
            tableBody.InnerHtml = sb.ToString();

        }

        private class StudieInfo
        {
            /*
             * Denne klassen er lagret for å holde styr på
             * informasjonen som blir hentet ut av databasen.
             * Alle String's som er definert er vil tilsvare en 
             * verdi som blir plukket ut av databasen
             */
            public String Fagnavn { get; set; }
            public String Fagkode { get; set; }
            public String Fakultet { get; set; }
        }
    }
}