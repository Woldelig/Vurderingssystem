using System;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace VMS
{
    public partial class Vurderingsskjema : System.Web.UI.Page
    {
        private Database db = new Database();
        private String sidensFagkode = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //Sjekker om en bruker er logget inn
            if (Session["studentID"] == null)
            {
                Response.Redirect("Default.aspx", true);
            }
            
            /*
             * Under henter vi ut en string query. Denne inneholder
             * fagkoden siden skal vise. Denne kommer enten fra søk eller en lenke.
             * Denne blir formatert ved hjelp av formaterQueryString metoden deretter
             * brukes den i en SQL spørring mot databasen
             */

            String uformatertQueryString = Request.Url.Query;
            String formatertQueryString = FormaterQueryString.FormaterString(uformatertQueryString);

            if (formatertQueryString != "" || formatertQueryString == null)
            {
                sidensFagkode = formatertQueryString;
            }
            else
            {
                Response.Redirect("velkomstside.aspx", true);
            }

            /*
             * På denne siden får vi tak i fagkoden til faget som skal vurderes
             * fra string query. Den blir sendt med nå en student trykker på
             * knappen for vurdering på MineVurderinger.aspx
             */

            String query = "SELECT spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10 FROM student as s, fag as f, vurderingsskjema as v WHERE s.studentid = @Studentid AND v.fagkode = @Fagkode AND s.studieretning = f.studieretning AND v.fagkode = f.fagkode";

            var cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            cmd.Parameters.AddWithValue("@Fagkode", sidensFagkode);
            db.OpenConnection();
            MySqlDataReader leser = cmd.ExecuteReader();

            //Arrayet blir satt til 10 siden det kun er 10 spørsmål per vurderingsskjema
            String[] skjemaSpm = new String[10];
            while (leser.Read())
            {
                for (int i = 0; i < 10; i++)
                {
                    skjemaSpm[i] = leser[i].ToString();
                }
            }
            db.CloseConnection();

            /*
             * Her bruker vi foreach loop for å fylle på spørsmålsteksten til
             * labelene på asp.net siden.
             */

            Label[] spmLabel = new Label[10] { spm1Lbl, spm2Lbl, spm3Lbl, spm4Lbl, spm5Lbl, spm6Lbl, spm7Lbl, spm8Lbl, spm9Lbl, spm10Lbl };
            int spmIndex = 0;
            foreach (Label lbl in spmLabel)
            {
                lbl.Text = skjemaSpm[spmIndex];
                spmIndex++;
            }
        }
        protected void SendInnSkjemaBtn_Click(object sender, EventArgs e)
        {
            //Parser verdiene til int
            int spm1 = Int32.Parse(spm1rating.Value);
            int spm2 = Int32.Parse(spm2rating.Value);
            int spm3 = Int32.Parse(spm3rating.Value);
            int spm4 = Int32.Parse(spm4rating.Value);
            int spm5 = Int32.Parse(spm5rating.Value);
            int spm6 = Int32.Parse(spm6rating.Value);
            int spm7 = Int32.Parse(spm7rating.Value);
            int spm8 = Int32.Parse(spm8rating.Value);
            int spm9 = Int32.Parse(spm9rating.Value);
            int spm10 = Int32.Parse(spm10rating.Value);

            int[] ratingArray = new int[10] { spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10 };
            //Sjekker om studentene har svart på alle spm
            foreach (var rating in ratingArray)
            {
                if (rating.Equals(0))
                {
                    feilmeldingLbl.Text = "Du må fylle ut hele skjemaet";
                    return;
                    //Stopper resten av koden fra å kjøre
                }
                else
                {

                    feilmeldingLbl.Text = "";
                }
            }

            String skjemaid = null;
            String sql = "SELECT skjemaid FROM student as s, fag as f, vurderingsskjema as v WHERE s.studentid = @Studentid AND v.fagkode = @Fagkode AND s.studieretning = f.studieretning AND v.fagkode = f.fagkode";
            var cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            cmd.Parameters.AddWithValue("@Fagkode", sidensFagkode);
            db.OpenConnection();
            MySqlDataReader leser = cmd.ExecuteReader();
            while (leser.Read())
            {
                skjemaid = leser[0].ToString();
            }
            db.CloseConnection();

            /*
             * Her blir svarene fra vurderinsskjemaet sendt inn til databasen.
             * Etter svarene er sendt inn blir det skrevet en tekststreng til en label
             * som sier at testen er fullført. Og etter ca 4 sekunder blir studenten sendt
             * tilbake til MineVurderinger.aspx
             */

            sql = "INSERT INTO pågåendevurdering(skjemaid, studentid, fagkode, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10) VALUES (@Skjemaid, @Studentid, @Fagkode, @Spm1rating, @Spm2rating, @Spm3rating, @Spm4rating, @Spm5rating, @Spm6rating, @Spm7rating, @Spm8rating, @Spm9rating, @Spm10rating);";
            cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Skjemaid", skjemaid);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            cmd.Parameters.AddWithValue("@Fagkode", sidensFagkode);
            cmd.Parameters.AddWithValue("@Spm1rating", spm1);
            cmd.Parameters.AddWithValue("@Spm2rating", spm2);
            cmd.Parameters.AddWithValue("@Spm3rating", spm3);
            cmd.Parameters.AddWithValue("@Spm4rating", spm4);
            cmd.Parameters.AddWithValue("@Spm5rating", spm5);
            cmd.Parameters.AddWithValue("@Spm6rating", spm6);
            cmd.Parameters.AddWithValue("@Spm7rating", spm7);
            cmd.Parameters.AddWithValue("@Spm8rating", spm8);
            cmd.Parameters.AddWithValue("@Spm9rating", spm9);
            cmd.Parameters.AddWithValue("@Spm10rating", spm10);
            db.OpenConnection();
            cmd.ExecuteNonQuery();
            db.CloseConnection();

            suksessLbl.Text = "Takk for at at du svarte på våre spørsmål. Du vil nå bli sendt tilbake til mine vurderinger.";
            Response.AddHeader("REFRESH", "4;URL=MineVurderinger.aspx");
            //Sender brukeren til mineVurderinger etter 4 sekunder
        }
    }
}