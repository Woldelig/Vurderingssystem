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
    public partial class MyCourses : UserControl
    {
        public MyCourses()
        {
            InitializeComponent();
        }
        int antallGangerKnappenErTrykket = 0;
        private void MyCourses_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            String sql = "SELECT fagkode FROM fag;";
            var mySqlCommand = db.SqlCommand(sql);
            int row = 0; //10
            int column = 0; //3
            String fagkode = "";


            SammenlignFeilmldLbl.Text = "";
            spmLbl.Hide();
            spmListeboks.Hide();
            chart1.Hide();


            try
            {
                db.OpenConnection();
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (column > 2)
                        {
                            column = 0;
                            row++;

                            if (row > 10)
                            {
                                row = 0;
                            }
                        }

                        fagkode = reader.GetString("fagkode");
                        Button button = new Button();
                        button.FlatAppearance.BorderSize = 0;
                        button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        button.Name = fagkode;
                        button.Text = fagkode;
                        button.Left = column * 145;
                        button.Top = row * 50;
                        button.Width = 145;
                        button.Height = 50;
                        button.Click += new EventHandler(Button_Click);
                        MyCoursesPanel.Controls.Add(button);
                        column++;
                    }
                }
            }
            catch (MySqlException DBexception)
            {

                Console.WriteLine("Feilmelding: ", DBexception);
            }


        }
        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            label1.Text = button.Name;
            if (antallGangerKnappenErTrykket == 0)
            {
                FagkodeNr1.Text = button.Text;
                antallGangerKnappenErTrykket++;
            }
            else
            {
                FagkodeNr2.Text = button.Text;
                antallGangerKnappenErTrykket--;
            }
        }

        private void SammenlignFagBtn_Click(object sender, EventArgs e)
        {
            //Sjekker om brukeren har valgt to fagkoder, og avbryter operasjonen hvis det ikke er det
            if (String.IsNullOrWhiteSpace(FagkodeNr1.Text) || String.IsNullOrWhiteSpace(FagkodeNr2.Text))
            {
                SammenlignFeilmldLbl.ForeColor = Color.Red;
                SammenlignFeilmldLbl.Text = "Du må velge to fagkoder";
                return;
            }
            else if (FagkodeNr1.Text.Equals(FagkodeNr2.Text))
            {
                SammenlignFeilmldLbl.ForeColor = Color.Red;
                SammenlignFeilmldLbl.Text = "Du må velge to forskjellige fagkoder";
                return;
            }
            SammenlignFeilmldLbl.Text = "";

            //Fjerner alle fagkodene fra 
            MyCoursesPanel.Controls.Clear();
            MyCoursesPanel.Hide();


            for (int i = 1; i < 6; i++)//Populerer listeboksen. Øk loopen for flere spørsmål.
            {                           //Hvis den økes må det lages flere prosedyrer i db og legges til i switchen under
                spmListeboks.Items.Add("Spørsmål " + i);
            }
            spmLbl.Show();
            spmListeboks.Show();
        }

        private void spmListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database db = new Database();

            var cmd = db.SqlCommand("");
            switch (spmListeboks.SelectedIndex) //Her legger vi inn hvilken prosedyre vi kaller på
            {
                case 0:
                    cmd.CommandText = "hent_spm1_verdier"; //Legger til commandtext i cmd objektet
                    break;

                case 1:
                    cmd.CommandText = "hent_spm2_verdier";
                    break;

                case 2:
                    cmd.CommandText = "hent_spm3_verdier";
                    break;

                case 3:
                    cmd.CommandText = "hent_spm4_verdier";
                    break;

                case 4:
                    cmd.CommandText = "hent_spm5_verdier";
                    break;
                default:
                    break;
            }
            cmd.CommandType = CommandType.StoredProcedure; //Setter at cmd sender en stored procedure - prosedyre
            String fagkode = FagkodeNr1.Text; //Valgt fagkode blir hentet ut og plassert som inn parameter
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

            String seriesname = "seriesName"; //Av en eller annen grunn heter den dette overalt på stackoverflow så følger det
            chart1.Series.Clear();
            chart1.Legends.Clear();
            chart1.Series.Add(seriesname);
            chart1.Series[seriesname].BorderWidth = 3; //Setter tykkelsen på linjen
            chart1.Series[seriesname].ChartType = SeriesChartType.Line;
            chart1.Series[seriesname].Points.AddXY("1 Stjerne", stjerne1);
            chart1.Series[seriesname].Points.AddXY("2 Stjerner", stjerne2);
            chart1.Series[seriesname].Points.AddXY("3 Stjerner", stjerne3);
            chart1.Series[seriesname].Points.AddXY("4 Stjerner", stjerne4);
            chart1.Series[seriesname].Points.AddXY("5 Stjerner", stjerne5);
            chart1.Show();
        }
    }
}
