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
            MySqlCommand cmd = new MySqlCommand();
            switch (spmListeboks.SelectedIndex) //Her legger vi inn hvilken prosedyre vi kaller på
            {
                case 0:
                    cmd.CommandText = "hent_spm1_verdier";
                    Console.WriteLine("spørsmål 1");
                    break;

                case 1:
                    cmd.CommandText = "hent_spm2_verdier";
                    Console.WriteLine("spørsmål 2");
                    break;

                case 2:
                    cmd.CommandText = "hent_spm3_verdier";
                    Console.WriteLine("spørsmål 3");
                    break;

                case 3:
                    cmd.CommandText = "hent_spm4_verdier";
                    Console.WriteLine("spørsmål 4");
                    break;

                case 4:
                    cmd.CommandText = "hent_spm5_verdier";
                    Console.WriteLine("spørsmål 5");
                    break;

                case 5:
                    cmd.CommandText = "hent_spm16_verdier";
                    Console.WriteLine("spørsmål 6");
                    break;

                case 6:
                    cmd.CommandText = "hent_spm7_verdier";
                    Console.WriteLine("spørsmål 7");
                    break;

                case 7:
                    cmd.CommandText = "hent_spm8_verdier";
                    Console.WriteLine("spørsmål 8");
                    break;

                case 8:
                    cmd.CommandText = "hent_spm9_verdier";
                    Console.WriteLine("spørsmål 9");
                    break;

                case 9:
                    cmd.CommandText = "hent_spm10_verdier";
                    Console.WriteLine("spørsmål 10");
                    break;

                default:
                    break;
            }


            cmd.Connection = dbConn;
            cmd.CommandType = CommandType.StoredProcedure;
            string fagkode = fagkodeListeboks.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@in_fagkode", fagkode).Direction = ParameterDirection.Input;
            //cmd.Parameters["@in_fagkode"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@out_verdi1", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            //cmd.Parameters["@out_verdi1"].Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@out_verdi2", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@out_verdi3", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@out_verdi4", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@out_verdi5", MySqlDbType.Int32).Direction = ParameterDirection.Output;

            Console.WriteLine(cmd.CommandText);



            Console.WriteLine("Verdi 1 " + cmd.Parameters["@out_verdi1"]);
            Console.WriteLine("Verdi 1 " + cmd.Parameters[0]);
            Console.WriteLine("Verdi 1 " + cmd.Parameters["@out_verdi2"]);
            Console.WriteLine("Verdi 2 " + cmd.Parameters[1]);
            Console.WriteLine("Verdi 1 " + cmd.Parameters["@out_verdi3"]);
            Console.WriteLine("Verdi 3 " + cmd.Parameters[2]);
            Console.WriteLine("Verdi 1 " + cmd.Parameters["@out_verdi4"]);
            Console.WriteLine("Verdi 4 " + cmd.Parameters[3]);
            Console.WriteLine("Verdi 5 " + cmd.Parameters["@out_verdi5"]);
            Console.WriteLine("Verdi 1 " + cmd.Parameters[4]);

            dbConn.Open();
            int stjerne1 = (int)cmd.Parameters["@out_verdi1"].Value;
            int stjerne2 = (int)cmd.Parameters["@out_verdi2"].Value;
            int stjerne3 = (int)cmd.Parameters["@out_verdi3"].Value;
            int stjerne4 = (int)cmd.Parameters["@out_verdi4"].Value;
            int stjerne5 = (int)cmd.Parameters["@out_verdi5"].Value;
            Console.WriteLine("Verdi 1: " + stjerne1.ToString());
            Console.WriteLine("Verdi 2: " + stjerne2.ToString());
            Console.WriteLine("Verdi 3: " + stjerne3.ToString());
            Console.WriteLine("Verdi 4: " + stjerne4.ToString());
            Console.WriteLine("Verdi 5: " + stjerne5.ToString());
            cmd.ExecuteNonQuery();
            dbConn.Close();

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

                chart1.Series[seriesname].Points.AddXY("1 Stjerne", stjerne1);
                chart1.Series[seriesname].Points.AddXY("2 Stjerner", stjerne2);
                chart1.Series[seriesname].Points.AddXY("3 Stjerner", stjerne3);
                chart1.Series[seriesname].Points.AddXY("4 Stjerner", stjerne4);
                chart1.Series[seriesname].Points.AddXY("5 Stjerner", stjerne5);
                chart1.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

/*
           cmd.Parameters.Add(new MySqlParameter("?out_verdi1", MySqlDbType.Int16));
           cmd.Parameters["?out_verdi1"].Direction = ParameterDirection.Output;
           cmd.Parameters.Add(new MySqlParameter("?out_verdi2", MySqlDbType.Int16));
           cmd.Parameters["?out_verdi2"].Direction = ParameterDirection.Output;
           cmd.Parameters.Add(new MySqlParameter("?out_verdi3", MySqlDbType.Int16));
           cmd.Parameters["?out_verdi3"].Direction = ParameterDirection.Output;
           cmd.Parameters.Add(new MySqlParameter("?out_verdi4", MySqlDbType.Int16));
           cmd.Parameters["?out_verdi4"].Direction = ParameterDirection.Output;
           cmd.Parameters.Add(new MySqlParameter("?out_verdi5", MySqlDbType.Int16));
           cmd.Parameters["?out_verdi5"].Direction = ParameterDirection.Output;*/
