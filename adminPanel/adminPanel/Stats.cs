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
            dbConn.Close(); //https://softwareengineering.stackexchange.com/questions/142065/creating-database-connections-do-it-once-or-for-each-query

            spmListeboks.Hide();    //Gjemmer listeboksene til vi har data i de
            diagramListeboks.Hide();
            chart1.Hide();
            spmLbl.Hide();
            diagramLbl.Hide();
        }

        private void fagkodeListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            spmListeboks.Items.Clear();//Fjerner elementer i listeboks. Må gjøres hvis klassekode byttes
            for (int i = 1; i < 11; i++)//Populerer listeboksen. Øk loopen for flere spørsmål
            {
                spmListeboks.Items.Add("Spørsmål "+i);
            }
            spmListeboks.Show();
            spmLbl.Show();
            dbConn.Close();
        }

        private void spmListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            diagramListeboks.Items.Clear(); //Fjerner elementer i listeboksen
            diagramListeboks.Show();
            diagramLbl.Show();
            String[] diagramTyper = { "Kakediagram", "Stolpediagram" }; //Legg til flere diagrammer her når vi er i gang

            foreach (String diagram in diagramTyper)
            {
                diagramListeboks.Items.Add(diagram.ToString());
            }
        }

        private void diagramListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int verdi1 = 20000, verdi2 = 10000, verdi3 = 40000, verdi4 = 20000, verdi5 = 40000; //Denne er her bare for å fjerne rødlinjer. men skal represntere svar i spm 1-5

            switch (spmListeboks.SelectedIndex) //Her legger vi inn hvilken prosedyre vi kaller på
            {
                case 0:
                    Console.WriteLine("spørsmål 1");
                    break;

                case 1:
                    Console.WriteLine("spørsmål 2");
                    break;

                case 2:
                    Console.WriteLine("spørsmål 3");
                    break;

                case 3:
                    Console.WriteLine("spørsmål 4");
                    break;

                case 4:
                    Console.WriteLine("spørsmål 5");
                    break;

                case 5:
                    Console.WriteLine("spørsmål 6");
                    break;

                case 6:
                    Console.WriteLine("spørsmål 7");
                    break;

                case 7:
                    Console.WriteLine("spørsmål 8");
                    break;

                case 8:
                    Console.WriteLine("spørsmål 9");
                    break;

                case 9:
                    Console.WriteLine("spørsmål 10");
                    break;

                default:
                    break;
            }


            

            MySqlCommand cmd = new MySqlCommand("hent_spm2_verdier", dbConn);
            //cmd.CommandText = "prosedyrenavn";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?out_verdi1", MySqlDbType.VarChar));
            cmd.Parameters["?out_verdi1"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new MySqlParameter("?out_verdi2", MySqlDbType.Int16));
            cmd.Parameters["?out_verdi2"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new MySqlParameter("?out_verdi3", MySqlDbType.Int16));
            cmd.Parameters["?out_verdi3"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new MySqlParameter("?out_verdi4", MySqlDbType.Int16));
            cmd.Parameters["?out_verdi4"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new MySqlParameter("?out_verdi5", MySqlDbType.Int16));
            cmd.Parameters["?out_verdi5"].Direction = ParameterDirection.Output;

            dbConn.Open();
            string stjerne1 = (string)cmd.Parameters["?out_verdi1"].Value;/*
            int stjerne2 = (int)cmd.Parameters["?out_verdi2"].Value;
            int stjerne3 = (int)cmd.Parameters["?out_verdi3"].Value;
            int stjerne4 = (int)cmd.Parameters["?out_verdi4"].Value;
            int stjerne5 = (int)cmd.Parameters["?out_verdi5"].Value;*/
            cmd.ExecuteNonQuery();
            dbConn.Close();

            
            Console.WriteLine(stjerne1/*.ToString(), stjerne2.ToString(), stjerne3.ToString(), stjerne4.ToString(), stjerne5.ToString()*/);

            chart1.Series.Clear();
            string seriesname = "seriesName"; //Av en eller annen grunn heter den dette overalt på stackoverflow så følger det
            try
            {
                switch (diagramListeboks.SelectedItem.ToString())
                {
                    case "Kakediagram":
                        //De to første linjene "tømmer" chart1 sin Series og Legends,
                        //ved å gjøre dette kan man switche frem og tilbake uten at applikasjonen feiler
                        chart1.Series.Clear();
                        chart1.Legends.Clear();
                        chart1.Series.Add(seriesname);
                        chart1.Series[seriesname].ChartType = SeriesChartType.Pie;
                        chart1.Legends.Add("Legende");
                        chart1.Legends[0].Docking = Docking.Bottom; //Legger boksen på bunnen
                        chart1.Legends[0].Alignment = StringAlignment.Center;   //midtstiller boksen og strings i den
                        chart1.Legends[0].BorderColor = Color.Black;    //setter sort farge rundt
                        break;

                    case "Stolpediagram":
                        chart1.Series.Clear();
                        chart1.Legends.Clear();
                        chart1.Series.Add(seriesname);
                        chart1.Series[seriesname].ChartType = SeriesChartType.Bar;
                        break;

                    default:
                        break;
                }

                chart1.Series[seriesname].Points.AddXY("1 Stjerne", verdi1);
                chart1.Series[seriesname].Points.AddXY("2 Stjerner", verdi2);
                chart1.Series[seriesname].Points.AddXY("3 Stjerner", verdi3);
                chart1.Series[seriesname].Points.AddXY("4 Stjerner", verdi4);
                chart1.Series[seriesname].Points.AddXY("5 Stjerner", verdi5);
                chart1.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
