using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Web.UI.DataVisualization.Charting;

namespace VMS
{
    public partial class Fagside : System.Web.UI.Page
    {
        Database db = new Database();
        private String sidensFagkode = "OBJ2100";
        /*
         * Denne variabelen skal bestemme hva fagsiden handler om. Planen er at man kun skal trenge å 
         * bytte ut denne variabelen så vil all info byttes ut dynamisk
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            int foreleserId; //Denne trenger vi for å få informasjon om foreleser

            String query = "SELECT * FROM fag WHERE fagkode = @SidensFagkode";
            var cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@SidensFagkode", sidensFagkode);


            //Under hentes data ut fra databasen og blir lagt inn i labels
            db.OpenConnection();
            MySqlDataReader leser = cmd.ExecuteReader();
            leser.Read();
            foreleserId = (int)leser[2]; //her henter vi ut foreleser id, så vi får hentet ut all info om personen senere. Samtidig som verdien blir castet til int
            fagkodeLbl.Text = "Fagkode: " + leser[0].ToString();
            fagnavnLbl.Text = "Fagnavn: " + leser[1].ToString();
            studieretningLbl.Text = "Studieretning: " + leser[3].ToString();
            if (leser[4] == null){ forkursLbl.Text = "Forkurs: " + leser[4].ToString();} else { forkursLbl.Text = ""; }
            //Linjen over sjekker om det finnes forkurs. Hvis det finnes settes det inn i label, hvis ikke forblir labelen tom
            leser.Close();
            db.CloseConnection();

            query = "SELECT fornavn, etternavn FROM foreleser WHERE foreleserid = @ForeleserId";
            cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@ForeleserId", foreleserId);

            db.OpenConnection();
            leser = cmd.ExecuteReader();
            leser.Read();
            String foreleserNavn = leser[0].ToString() + " " + leser[1].ToString(); //Setter sammen fornavn og etternavn fra databasen
            leser.Close();
            db.CloseConnection();
            foreleserLbl.Text = "Foreleser: " + foreleserNavn;


            int[] prosedyreSvar = ProsedyreKaller("hent_spm1_verdier", sidensFagkode, 1);
            //Her kaller vi på prosedyren for spm1, kaller på den her pga dataen skal brukes flere steder


            pensumRatingLbl.Text = BeregnGjennomsnittsRating(prosedyreSvar);


            //Koden under påvirker kun diagrammet
            String diagramTittel = "Var faget vanskelig?"; //diagramets tittel
            String seriesname = "seriesName";
            diagram.Series.Clear();
            diagram.Legends.Clear();
            diagram.Series.Add(seriesname);
            diagram.Series[seriesname].ChartType = SeriesChartType.Pie;
            Title tittel = diagram.Titles.Add(diagramTittel);
            tittel.Font = new System.Drawing.Font("Verdana", 16, System.Drawing.FontStyle.Bold); //Her setter vi skrifttype ol.

            diagram.Series[seriesname].Points.AddXY("Svært misfornøyd", prosedyreSvar[1]);
            diagram.Series[seriesname].Points.AddXY("Litt misfornøyd", prosedyreSvar[2]);
            diagram.Series[seriesname].Points.AddXY("Hverken/eller", prosedyreSvar[3]);
            diagram.Series[seriesname].Points.AddXY("Litt fornøyd", prosedyreSvar[4]);
            diagram.Series[seriesname].Points.AddXY("Meget fornøyd", prosedyreSvar[5]);


        }

        private String BeregnGjennomsnittsRating (int[] prosedyreSvar)
        {
            int totalSpm1Rating = prosedyreSvar[1] * 1 + prosedyreSvar[2] * 2 + prosedyreSvar[3] * 3 + prosedyreSvar[4] * 4 + prosedyreSvar[5] * 5;
            //Grunnen til at prosedyre svar må ganges opp er fordi den kun teller antall forekomster, så for å få den korrekte gjennomsnittsverdien
            //må vi gange opp verdiene så vi for den riktige totalsummen så vi kan få gjennomsnittet

            double spm1GjennomsnittsRating = (double)totalSpm1Rating / (double)prosedyreSvar[0];
            //NB HVIS DET IKKE FINNES VERDIER I DB VIL DU FÅ DIVIDE BY ZERO EXCEPTION
                        
            //Runder av gjennomsnittet til å vise en desimal og returner verdien som en string
            return Math.Round(spm1GjennomsnittsRating, 1).ToString();
        }

        private int[] ProsedyreKaller (String prosedyreNavn, String fagkode, int spmnr)
        {
            //Denne metoden kaller på prosedyrer så vi får telling over alle verdier
            //derfor trenger vi fagkode, prosedyrenr og spmnr som et parameter, man 
            //vil få tilbake et int array som resultat etter å ha kalt på metoden
            //Posisjon 0 i arrayet vil innehold antall svar per spm

            var cmd = db.SqlCommand("");
            cmd.CommandText = prosedyreNavn; //prosedyrenavn må være helt likt som i db
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@in_fagkode", fagkode).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@out_verdi1", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@out_verdi2", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@out_verdi3", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@out_verdi4", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@out_verdi5", MySqlDbType.Int32).Direction = ParameterDirection.Output;

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            int stjerne1 = (int)cmd.Parameters["@out_verdi1"].Value;
            int stjerne2 = (int)cmd.Parameters["@out_verdi2"].Value;
            int stjerne3 = (int)cmd.Parameters["@out_verdi3"].Value;
            int stjerne4 = (int)cmd.Parameters["@out_verdi4"].Value;
            int stjerne5 = (int)cmd.Parameters["@out_verdi5"].Value;
            db.CloseConnection();



            String telleProsedyreNavn = "telle_svar_skjemaer";
            //Denne prosedyren teller opp antall svar som har kommet per fagkode og spm
            //dette tallet kan vi dele på den totale summen vi får senere for å finne ut
            //gjennomsnittsverdien til vært enkelt spm

            cmd = db.SqlCommand(telleProsedyreNavn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@in_fagkode", fagkode).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@out_verdi1", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@in_spmnr", spmnr).Direction = ParameterDirection.Input;

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            int totaltAntallSvar = (int)cmd.Parameters["@out_verdi1"].Value;
            db.CloseConnection();
            
            int[] rating = new int[] { totaltAntallSvar, stjerne1, stjerne2, stjerne3, stjerne4, stjerne5 };

            return rating;
        }
    }
}