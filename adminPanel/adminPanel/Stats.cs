using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace adminPanel
{
    public partial class Stats : UserControl
    {
        public Stats()
        {
            InitializeComponent();
        }
        private static String connString = "server=localhost;user=root;database=vurderingssystem;";//OBS OBS! HUSK Å ENDRE DATABSEN!
        MySqlConnection dbConn = new MySqlConnection(connString);

        private void Stats_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT fagkode FROM fag;", dbConn);
            dbConn.Open(); //åpne

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0]; //plassering 0 fordi den kun henter ut en rad. i foreachen blir den splittet opp per rad og lagt inn en og en i listeboksen

            foreach (DataRow dr in dt.Rows)  //Her brukes datarow fordi vi skal ha ut rader
            {
                fagkodeListeboks.Items.Add(dr["Fagkode"].ToString());
            }
            dbConn.Close(); //lukke. Burde de åpnes/lukkes for vær gang? Spørr lasse https://softwareengineering.stackexchange.com/questions/142065/creating-database-connections-do-it-once-or-for-each-query

            spmListeboks.Hide();    //Gjemmer listeboksene til vi har data i de
            diagramListeboks.Hide();
            chart1.Hide();
        }

        private void fagkodeListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10 FROM vurderingshistorikk;", dbConn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0]; //plassering 0 fordi den kun henter ut en rad. i foreachen blir den splittet opp per rad og lagt inn en og en i listeboksen

            foreach (DataColumn dc in dt.Columns)  //her bruker vi dataColumn fordi vi skal ha ut kolonner
            {
                spmListeboks.Items.Add(dc.ToString());
                Console.WriteLine(dc);
            }
            spmListeboks.Show();
            dbConn.Close();

        }

        private void spmListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            diagramListeboks.Show();
            String[] diagramTyper = {"Kakediagram", "Stolpediagram" }; //Legg til flere diagrammer her når vi er i gang

            foreach (String diagram in diagramTyper)
            {
                diagramListeboks.Items.Add(diagram.ToString());
            }
        }

        private void diagramListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (diagramListeboks.SelectedItem.ToString())
            {
                case "Kakediagram":
                    DrawPieChart(1, 2, 3, 5, 5);

                    //tegnKakediagram();
                    break;

                case "Stolpediagram":
                    tegnStolpediagram();
                    break;

                default:
                    break;
            }

            //bruke switch case for å sjekke valg i listeboksen. Som starter metode for å tegne diagrammet!
        }

        private void tegnStolpediagram()
        {

            int verdi1 = 0, verdi2 = 0, verdi3 = 0, verdi4 = 0, verdi5 = 0; //Denne er her bare for å fjerne rødlinjer. men skal represntere svar i spm 1-5
            //Må brukes så applikasjonen ikke krasjer!
            chart1.Series.Clear();

            //Lager sånn boks på bunnen som forklarer hva fargene betyr
            chart1.Legends.Add("Legende");
            chart1.Legends[0].Docking = Docking.Bottom; //Legger boksen på bunnen
            chart1.Legends[0].Alignment = StringAlignment.Center;   //midtstiller boksen og strings i den
            chart1.Legends[0].BorderColor = Color.Black;    //setter sort farge rundt

            string seriesname = "seriesName"; //Av en eller annen grunn heter den dette overalt på stackoverflow så følger det
            chart1.Series.Add(seriesname);

            chart1.Series[seriesname].ChartType = SeriesChartType.Bar; //Her velger man diagramtype. Og fy faen det er mange!
            /*
             vi kan legge linjen over inn i en switch case, da kan vi legge inn utrolige mange flere diagramtyper
             og vi kommer til å ha ekstremt lite gjenbruk av kode kontra slik som jeg planla nå.
             


            Jeg legger inn i switch case når jeg får til SQL delen

            TODO

            1. Fiks prosedyren så jeg får 5 verdier
            2. Hent disse verdiene ut og legg inn i diagramet
            3. Lag switch case med 100 diagramtyper -- Legg i SelectIndexChange? husk å legg til chart1.Series.Clear og Show() på alle casene!
             */

            chart1.Series[seriesname].Points.AddXY("1 Stjerne", verdi1);
            chart1.Series[seriesname].Points.AddXY("2 Stjerner", verdi2);
            chart1.Series[seriesname].Points.AddXY("3 Stjerner", verdi3);
            chart1.Series[seriesname].Points.AddXY("4 Stjerner", verdi4);
            chart1.Series[seriesname].Points.AddXY("5 Stjerner", verdi5);
            chart1.Show();


            throw new NotImplementedException();
        }

        private void tegnKakediagram()
        {
            throw new NotImplementedException();
        }

        private void DrawPieChart(int verdi1, int verdi2, int verdi3, int verdi4, int verdi5)
        {
            //litt usikker på hva den gjør men uten den stopper applikasjonen.
            // må lese meg opp på den virker som at den reseter chart1 så jeg får puttet inn info?
            chart1.Series.Clear();
            

            //Lager sånn boks på bunnen som forklarer hva fargene betyr
            chart1.Legends.Add("Legende");
            chart1.Legends[0].Docking = Docking.Bottom; //Legger boksen på bunnen
            chart1.Legends[0].Alignment = StringAlignment.Center;   //midtstiller boksen og strings i den
            chart1.Legends[0].BorderColor = Color.Black;    //setter sort farge rundt

            string seriesname = "MySeriesName";
            chart1.Series.Add(seriesname);
            chart1.Series[seriesname].ChartType = SeriesChartType.Doughnut; //Her velger man diagramtype. Og fy faen det er mange!

            chart1.Series[seriesname].Points.AddXY("1 Stjerne", verdi1);
            chart1.Series[seriesname].Points.AddXY("2 Stjerner", verdi2);
            chart1.Series[seriesname].Points.AddXY("3 Stjerner", verdi3);
            chart1.Series[seriesname].Points.AddXY("4 Stjerner", verdi4);
            chart1.Series[seriesname].Points.AddXY("5 Stjerner", verdi5);
            chart1.Show();
        }
    }
}
