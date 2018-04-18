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
    public partial class fakultet : System.Web.UI.Page
    {
        private Database db = new Database();
        private List<FakultetInfo> fakultetInfoListe = new List<FakultetInfo>();
        private String sidensFakultet = "Handelshøyskolen";
        //Setter et standard fakultet for nettsiden
      
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Under henter vi ut en string query. Denne inneholder
             * fagkoden siden skal vise. Denne kommer enten fra søk eller en lenke.
             * Denne blir formatert ved hjelp av formaterQueryString metoden deretter
             * brukes den i en SQL spørring
             */
            String uformatertQueryString = Request.Url.Query;
            String formatertString = FormaterQueryString.FormaterString(uformatertQueryString);

            if (formatertString != "" || formatertString == null)
            {
                sidensFakultet = formatertString;
            }

            String query = "SELECT s.fakultet, s.grad, s.studieretning, f.fagkode, f.fagnavn FROM studier as s, fag as f WHERE s.fakultet = @SidensFakultet AND f.studieretning = s.studieretning";
            var cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@SidensFakultet", sidensFakultet);

            db.OpenConnection();

            String fakultetNavn = null;

            /*
             * Using passer på at objektet som blir definert inne i 
             * parantesene i blir "destroyed" eller tatt hånd om av 
             * garbage collector så fort krøllparantesene tar slutt
             * 
             * Innenfor while løkken legger vi inn informasjonen som er
             * hentet ut fra databasen i FakultetInfo objekter som legges
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
                    fakultetNavn = leser["fakultet"].ToString();
                    fakultetInfoListe.Add(new FakultetInfo()
                    {
                        Fagkode = leser["fagkode"].ToString(),
                        Fagnavn = leser["fagnavn"].ToString(),
                        Studielinje = leser["studieretning"].ToString(),
                        Grad = leser["grad"].ToString()
                    });
                }
            }
            db.CloseConnection();

            fakultetLbl.Text = "Fakultet: " + fakultetNavn;

            /*
             * Her lager vi en tekststreng ved hjelp av string builder klassen.
             * Vi legger tekststrengene som ble hentet utfra databasen og inn i 
             * FakultetInfo klassen inn i html kode. Vær iterasjon i foreachen tilsvarer
             * et FakultetInfo objekt som igjen tilsvarer en rad i SQL spørringen.
             * Helt tilslutt blir hele tekststrengen skrevet ut til HTML, ved hjelp av InnerHtml.
             * 
             * Html formateringen under er for å legge dataene inn i en tabell og gjøre de til linker
             * så man enkelt kan navigere på nettsiden
             */
            StringBuilder sb = new StringBuilder();
            foreach (var info in fakultetInfoListe)
            {
                sb.Append(
                    "<tr>" +
                        "<td>" + info.Grad + "</td>" +
                        "<td><a href = 'linjeside.aspx?" + info.Studielinje + "'>" + info.Studielinje + "</a></td>"+
                        "<td><a href = 'fagside.aspx?" + info.Fagkode + "'>" + info.Fagnavn + "</a></td>" +
                        "<td><a href = 'fagside.aspx?" + info.Fagkode + "'>" + info.Fagkode + "</a></td>" +
                    "</tr>");
            }
            tableBody.InnerHtml = sb.ToString();
        }

        private class FakultetInfo
        {
            /*
             * Denne klassen er lagret for å holde styr på
             * informasjonen som blir hentet ut av databasen.
             * Alle String's som er definert er vil tilsvare en 
             * verdi som blir plukket ut av databasen
             */
            public String Fagnavn { get; set; }
            public String Fagkode { get; set; }
            public String Studielinje { get; set; }
            public String Grad { get; set; }
        }
    }
}