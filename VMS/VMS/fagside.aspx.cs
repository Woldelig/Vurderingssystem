using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;

namespace VMS
{
    public partial class Fagside : System.Web.UI.Page
    {
        Database db = new Database();
        private String sidensFagkode = "obj2100";
        /*
         * Denne variabelen skal bestemme hva fagsiden handler om. Planen er at man kun skal trenge å 
         * bytte ut denne variabelen så vil all info byttes ut dynamisk
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hvis noen blir redirected til fagsiden med et parameter vil fagsiden bytte om fagkoden til parameteret ved hjelp av en stringQuery
            String uformatertQueryString = Request.Url.Query;
            String formatertQueryString = FormaterQueryString.FormaterString(uformatertQueryString);


            if (formatertQueryString != "" || formatertQueryString == null)
            {
                sidensFagkode = formatertQueryString;
            }

            int foreleserId; //Denne trenger vi for å få informasjon om foreleser

            String query = "SELECT f.*, s.fakultet FROM fag as f, studier as s  WHERE f.fagkode = @SidensFagkode AND f.studieretning = s.studieretning";
            var cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@SidensFagkode", sidensFagkode);


            //Under hentes data ut fra databasen og blir lagt inn i labels
            db.OpenConnection();
            MySqlDataReader leser = cmd.ExecuteReader();

            if (!leser.HasRows)
            {
                //Hvis fagkoden ikke inneholder informasjon eller er feil sender serveren deg til default
                Server.Transfer("Default.aspx");
            }
            leser.Read();
            foreleserId = (int)leser[2]; //her henter vi ut foreleser id, så vi får hentet ut all info om personen senere. Samtidig som verdien blir castet til int
            fagkodeLbl.Text = "Fagkode: " + leser[0].ToString();
            fagnavnLbl.Text = "Fagnavn: " + leser[1].ToString();
            studieretningLbl.Text = "Studieretning: <a href = 'linjeside.aspx?" + leser[3].ToString() + "'>" + leser[3].ToString() + "</a>";
            String forkurs = leser[4].ToString();
            fakultetLbl.Text = "Fakultet: <a href = 'fakultet.aspx?" + leser[5].ToString() + "'>" + leser[5].ToString() + "</a>";

            //Her sjekkes det om forkurs finnes, hvis det gjør det skrives det til label som en link til forkurset
            if (forkurs != "")
            {
                forkursLbl.Text = "Forkurs: <a href = 'fagside.aspx?" + forkurs + "'>" + forkurs + "</a>";
            }
            else
            {
                forkursLbl.Text = "";
            }
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
            //foreleserLbl.Text = "Foreleser: " + foreleserNavn;
            foreleserLbl.Text = "Foreleser: <a href = 'foreleserside.aspx?" + foreleserNavn + "'>" + foreleserNavn + "</a>";


            //Her kaller vi på prosedyren for spm1, kaller på den her pga dataen skal brukes flere steder
            int[] prosedyreSvarSpm1 = ProsedyreKaller("hent_spm1_verdier", sidensFagkode, 1);
            int[] prosedyreSvarSpm2 = ProsedyreKaller("hent_spm2_verdier", sidensFagkode, 2);
            int[] prosedyreSvarSpm3 = ProsedyreKaller("hent_spm3_verdier", sidensFagkode, 3);
            int[] prosedyreSvarSpm4 = ProsedyreKaller("hent_spm4_verdier", sidensFagkode, 4);
            int[] prosedyreSvarSpm5 = ProsedyreKaller("hent_spm5_verdier", sidensFagkode, 5);

            //Under sjekker vi om et eller flere av spørsmålene ikke har data
            //de uten data blir deretter skjult fra nettsiden
            int sumSpm1 = prosedyreSvarSpm1.Sum();
            int sumSpm2 = prosedyreSvarSpm2.Sum();
            int sumSpm3 = prosedyreSvarSpm3.Sum();
            int sumSpm4 = prosedyreSvarSpm4.Sum();
            int sumSpm5 = prosedyreSvarSpm5.Sum();

            
            
            //if (sumSpm1 != 0 || sumSpm2 != 0 || sumSpm3 != 0 ) Setningen under fungerer på samme måte som denne. Men den har mye penere syntax og er mindre repeterende
            if (!new int[] { sumSpm1, sumSpm2, sumSpm3, sumSpm4, sumSpm5 }.Contains(0))
            {
                String gjennomsnittSpm1 = BeregnGjennomsnittsRating(prosedyreSvarSpm1);
                String gjennomsnittSpm2 = BeregnGjennomsnittsRating(prosedyreSvarSpm2);
                String gjennomsnittSpm3 = BeregnGjennomsnittsRating(prosedyreSvarSpm3);
                String gjennomsnittSpm4 = BeregnGjennomsnittsRating(prosedyreSvarSpm4);
                String gjennomsnittSpm5 = BeregnGjennomsnittsRating(prosedyreSvarSpm5);

                spm1RatingLbl.Text = gjennomsnittSpm1;
                spm2RatingLbl.Text = gjennomsnittSpm2;
                spm3RatingLbl.Text = gjennomsnittSpm3;
                spm4RatingLbl.Text = gjennomsnittSpm4;
                spm5RatingLbl.Text = gjennomsnittSpm5;

                spm1RatingStjerne.Value = gjennomsnittSpm1.Replace(",", ".");
                spm2RatingStjerne.Value = gjennomsnittSpm2.Replace(",", ".");
                spm3RatingStjerne.Value = gjennomsnittSpm3.Replace(",", ".");
                spm4RatingStjerne.Value = gjennomsnittSpm4.Replace(",", ".");
                spm5RatingStjerne.Value = gjennomsnittSpm5.Replace(",", ".");

                /* Chris sine gamle variabler
                pensumRatingLbl.Text = BeregnGjennomsnittsRating(prosedyreSvarSpm1);
                kvalitetRatingLbl.Text = BeregnGjennomsnittsRating(prosedyreSvarSpm2);
                vanskelighetsgradRatingLbl.Text = BeregnGjennomsnittsRating(prosedyreSvarSpm3);
                spm4RatingLbl.Text = BeregnGjennomsnittsRating(prosedyreSvarSpm4);//PLACEHOLDER
                spm5RatingLbl.Text = BeregnGjennomsnittsRating(prosedyreSvarSpm5);//PLACEHOLDER
                */

                //Koden under påvirker kun diagrammet
                String diagramTittel = "Var faget vanskelig?"; //diagramets tittel
                String seriesname = "seriesName";
                diagram.Series.Clear();
                diagram.Legends.Clear();
                diagram.Series.Add(seriesname);
                diagram.Series[seriesname].ChartType = SeriesChartType.Pie;
                Title tittel = diagram.Titles.Add(diagramTittel);
                tittel.Font = new System.Drawing.Font("Verdana", 16, System.Drawing.FontStyle.Bold); //Her setter vi skrifttype ol.

                diagram.Legends.Add("Legende");
                diagram.Legends[0].Alignment = StringAlignment.Center;
                diagram.Legends[0].BorderColor = Color.Black;

                diagram.Series[seriesname].Label = "#PERCENT{P0}";
                diagram.Series[seriesname].Points.AddXY(0, prosedyreSvarSpm1[1]);
                diagram.Series[seriesname].Points.AddXY(1, prosedyreSvarSpm1[2]);
                diagram.Series[seriesname].Points.AddXY(2, prosedyreSvarSpm1[3]);
                diagram.Series[seriesname].Points.AddXY(3, prosedyreSvarSpm1[4]);
                diagram.Series[seriesname].Points.AddXY(4, prosedyreSvarSpm1[5]);
                
                //Teksten under er den som kommer opp i legend.
                diagram.Series[seriesname].Points[0].LegendText = "Svært misfornøyd";
                diagram.Series[seriesname].Points[1].LegendText = "Litt misfornøyd";
                diagram.Series[seriesname].Points[2].LegendText = "Hverken/eller";
                diagram.Series[seriesname].Points[3].LegendText = "Litt fornøyd";
                diagram.Series[seriesname].Points[4].LegendText = "Meget fornøyd";

                
            }
            else
            {
                pensumLbl.ForeColor = System.Drawing.Color.Red;
                pensumLbl.Text = "Det er ikke foretatt en fagvurdering i dette faget. Prøv igjen senere.";

                //Kodesnutten under trenger vi for å skjule rateit. Uten den vil stjernene vises
                spm1Div.InnerHtml = "";
                spm2Div.InnerHtml = "";
                spm3Div.InnerHtml = "";
                spm4Div.InnerHtml = "";
                spm5Div.InnerHtml = "";

                kvalitetLbl.Text = "";
                vanskelighetsgradLbl.Text = "";
                pensumFormidlingLbl.Text = "";
                fagRelevantLbl.Text = "";
            }
        }

        private String BeregnGjennomsnittsRating (int[] prosedyreSvar)
        {
            //Arrayet som sendes inn her må tilhøre det spørsmålet du ønsker å gjøre en gjennomsnittsberegning på!

            int totalSpmRating = prosedyreSvar[1] * 1 + prosedyreSvar[2] * 2 + prosedyreSvar[3] * 3 + prosedyreSvar[4] * 4 + prosedyreSvar[5] * 5;
            //Grunnen til at prosedyre svar må ganges opp er fordi den kun teller antall forekomster, så for å få den korrekte gjennomsnittsverdien
            //må vi gange opp verdiene så vi for den riktige totalsummen så vi kan få gjennomsnittet

            double spmGjennomsnittsRating = (double)totalSpmRating / (double)prosedyreSvar[0];
            //NB HVIS DET IKKE FINNES VERDIER I DB VIL DU FÅ DIVIDE BY ZERO EXCEPTION
                        
            //Runder av gjennomsnittet til å vise en desimal og returner verdien som en string
            return Math.Round(spmGjennomsnittsRating, 1).ToString();
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