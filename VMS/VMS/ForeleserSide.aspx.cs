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
    public partial class ForeleserSide : System.Web.UI.Page
    {
        private Database db = new Database();
        private List<ForeleserInfo> foreleserInfoListe = new List<ForeleserInfo>();
        private String sidensForeleser = "Steve Jobs";
        //Setter en standard foreleserId så det alltid vil vises noe informasjon
         
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
                sidensForeleser = formatertQueryString;
            }

            //Henter ut navn, fagkode, fagnavn, fakultet, studieretning
            String query = "SELECT CONCAT(f.fornavn, ' ', f.etternavn) as navn, fag.fagkode, fag.fagnavn, fag.studieretning, s.fakultet from foreleser as f, fag, studier as s WHERE CONCAT(f.fornavn, ' ', f.etternavn) = @SidensForeleser AND fag.foreleserid = f.foreleserid AND fag.studieretning = s.studieretning";
            var cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@SidensForeleser", sidensForeleser);

            db.OpenConnection();
            String foreleserNavn = null;


            /*
             * Using passer på at objektet som blir definert inne i 
             * parantesene i blir "destroyed" eller tatt hånd om av 
             * garbage collector så fort krøllparantesene tar slutt
             * 
             * Innenfor while løkken legger vi inn informasjonen som er
             * hentet ut fra databasen i ForeleserInfo objekter som legges
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
                    foreleserNavn = leser["navn"].ToString();

                    foreleserInfoListe.Add(new ForeleserInfo()
                    {
                        Fagkode = leser["fagkode"].ToString(),
                        Fagnavn = leser["fagnavn"].ToString(),
                        Fakultet = leser["fakultet"].ToString(),
                        Studieretning = leser["studieretning"].ToString()
                    });
                }

            }
            db.CloseConnection();

            foreleserLbl.Text = "Foreleser: " + foreleserNavn;


            /*
             * Her lager vi en tekststreng ved hjelp av string builder klassen.
             * Vi legger tekststrengene som ble hentet utfra databasen og inn i 
             * ForeleserInfo klassen inn i html kode. Vær iterasjon i foreachen tilsvarer
             * et FakultetInfo objekt som igjen tilsvarer en rad i SQL spørringen.
             * Helt tilslutt blir hele tekststrengen skrevet ut til HTML, ved hjelp av InnerHtml.
             * 
             * Html formateringen under er for å legge dataene inn i en tabell og gjøre de til linker
             * så man enkelt kan navigere på nettsiden
             */
            StringBuilder sb = new StringBuilder();
            foreach (var info in foreleserInfoListe)
            {
                sb.Append(
                    "<tr>" +
                        "<td><a href = 'fagside.aspx?" + info.Fagkode + "'>"+ info.Fagkode + "</a></td>" +
                        "<td><a href = 'fagside.aspx?" + info.Fagkode + "'>" + info.Fagnavn + "</a></td>" +
                        "<td><a href = 'linjeside.aspx?" + info.Studieretning +"'>"+ info.Studieretning + "</a></td>" +
                        "<td>" + info.Fakultet + "</td>" +
                    "</tr>");
            }
            tableBody.InnerHtml = sb.ToString();
        }


        private class ForeleserInfo
        {
            /*
           * Denne klassen er lagret for å holde styr på
           * informasjonen som blir hentet ut av databasen.
           * Alle String's som er definert er vil tilsvare en 
           * verdi som blir plukket ut av databasen
           */
            public String Fagkode { get; set; }
            public String Fagnavn { get; set; }
            public String Studieretning { get; set; }
            public String Fakultet { get; set; }
        }
    }
}