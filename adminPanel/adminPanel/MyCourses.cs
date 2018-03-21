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
        Database db = new Database();

        int antallGangerKnappenErTrykket = 0;
        private void MyCourses_Load(object sender, EventArgs e)
        {
            String sql = "SELECT DISTINCT fagkode FROM vurderingshistorikk;";
            var mySqlCommand = db.SqlCommand(sql);
            int row = 0; //10
            int column = 0; //3
            String fagkode = "";

            ChartFeilmldLbl.Text = "";
            SammenlignFeilmldLbl.Text = "";
            spmLbl.Hide();
            spmListeboks.Hide();
            chart1.Hide();
            printBtn.Hide();
            lagreChartBtn.Hide();



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

            String fagkode = FagkodeNr1.Text;
            String seriesname = "";

            chart1.Series.Clear();
            chart1.Legends.Clear();
            String[] ProsedyreNavnArray = new String[] { "hent_spm1_verdier", "hent_spm2_verdier", "hent_spm3_verdier", "hent_spm4_verdier", "hent_spm5_verdier" };
            String[] SpørsmålNr = new String[] { "Spørsmål 1", "Spørsmål 2", "Spørsmål 3", "Spørsmål 4", "Spørsmål 5" };
            for (int i = 0; i < ProsedyreNavnArray.Length; i++)
            {
                int[] prosedyreSvar = ProsedyreUtfører(fagkode, ProsedyreNavnArray[i]);
                seriesname = SpørsmålNr[i];
                //Legger til data for fagkode 1
                chart1.Series.Add(seriesname);
                if (i == 0) { chart1.Legends.Add("Legende"); }
                chart1.Series[seriesname].BorderWidth = 3;
                chart1.Series[seriesname].ChartType = SeriesChartType.Line;
                chart1.Series[seriesname].Points.AddXY("1 Stjerne", prosedyreSvar[0]);
                chart1.Series[seriesname].Points.AddXY("2 Stjerner", prosedyreSvar[1]);
                chart1.Series[seriesname].Points.AddXY("3 Stjerner", prosedyreSvar[2]);
                chart1.Series[seriesname].Points.AddXY("4 Stjerner", prosedyreSvar[3]);
                chart1.Series[seriesname].Points.AddXY("5 Stjerner", prosedyreSvar[4]);

                ChartFeilmldLbl.Text = "";
                chart1.Show();
                printBtn.Show();
                lagreChartBtn.Show();

            }
        }

        private void spmListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Må ha try catch siden denne metoden reagerer på index change. Hvis du velger noe som ikke er element ville den ha gitt en feilmelding
            try
            {
                //Fjerner alle fagkodene fra 
                MyCoursesPanel.Controls.Clear();
                MyCoursesPanel.Hide();

                Database db = new Database();
                try
                {
                    var cmdForFagkode1 = db.SqlCommand("");
                    var cmdForFagkode2 = db.SqlCommand("");
                    //Her velges hvilket spørsmål som skal sammenlignes
                    switch (spmListeboks.SelectedIndex)
                    {
                        case 0:
                            cmdForFagkode1.CommandText = "hent_spm1_verdier";
                            cmdForFagkode2.CommandText = "hent_spm1_verdier";

                            break;

                        case 1:
                            cmdForFagkode1.CommandText = "hent_spm2_verdier";
                            cmdForFagkode2.CommandText = "hent_spm2_verdier";
                            break;

                        case 2:
                            cmdForFagkode1.CommandText = "hent_spm3_verdier";
                            cmdForFagkode2.CommandText = "hent_spm3_verdier";
                            break;

                        case 3:
                            cmdForFagkode1.CommandText = "hent_spm4_verdier";
                            cmdForFagkode2.CommandText = "hent_spm4_verdier";
                            break;

                        case 4:
                            cmdForFagkode1.CommandText = "hent_spm5_verdier";
                            cmdForFagkode2.CommandText = "hent_spm5_verdier";
                            break;
                        default:
                            break;
                    }


                    









                    //Setter farge på linjene
                    /*for (int i = 0; i < 5; i++)
                    {
                        chart1.Series[seriesname1].Points[i].Color = Color.Blue;
                        chart1.Series[seriesname2].Points[i].Color = Color.Green;
                    }*/

                    

                }
                catch (Exception ex)
                {
                    ChartFeilmldLbl.ForeColor = Color.Red;
                    ChartFeilmldLbl.Text = "Fagkoden mangler vurderinger kontakt databaseadministratoren";
                    Console.WriteLine(ex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private int[] ProsedyreUtfører(String fagkode, String prosedyrenavn)
        {
            /*
             * Metoden utfører en prosedyre basert på parameter. Og returnerer et in array
             * prosedyrenavn blir valgt fra en switch mens fagkoden kommer fra en listeboks
             * som henter disse ut fra DB
             */
            var cmdForFagkode = db.SqlCommand("");
            cmdForFagkode.CommandText = prosedyrenavn;
            cmdForFagkode.CommandType = CommandType.StoredProcedure;
            cmdForFagkode.Parameters.AddWithValue("@in_fagkode", fagkode).Direction = ParameterDirection.Input;
            cmdForFagkode.Parameters.AddWithValue("@out_verdi1", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            cmdForFagkode.Parameters.AddWithValue("@out_verdi2", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            cmdForFagkode.Parameters.AddWithValue("@out_verdi3", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            cmdForFagkode.Parameters.AddWithValue("@out_verdi4", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            cmdForFagkode.Parameters.AddWithValue("@out_verdi5", MySqlDbType.Int32).Direction = ParameterDirection.Output;

            db.OpenConnection();
            cmdForFagkode.ExecuteNonQuery();
            int stjerne1 = (int)cmdForFagkode.Parameters["@out_verdi1"].Value;
            int stjerne2 = (int)cmdForFagkode.Parameters["@out_verdi2"].Value;
            int stjerne3 = (int)cmdForFagkode.Parameters["@out_verdi3"].Value;
            int stjerne4 = (int)cmdForFagkode.Parameters["@out_verdi4"].Value;
            int stjerne5 = (int)cmdForFagkode.Parameters["@out_verdi5"].Value;
            db.CloseConnection();

            int[] prosedyreSvar = new int[] { stjerne1, stjerne2, stjerne3, stjerne4, stjerne5 };
            return prosedyreSvar;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            this.chart1.Printing.PrintPreview();
        }

        private void lagreChartBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog lagreFilDialog = new SaveFileDialog();
            lagreFilDialog.Filter = "PNG Bilde|*.png|Jpeg Bilde|*.jpg"; //Hvilke filtyper som vi kan lagre i
            lagreFilDialog.Title = "Lagre diagram som bilde fil";
            lagreFilDialog.FileName = "diagram.png";                    //filnavnet blir diagram.png

            DialogResult dialogResultat = lagreFilDialog.ShowDialog();
            lagreFilDialog.RestoreDirectory = true;

            if (dialogResultat == DialogResult.OK && lagreFilDialog.FileName != "") //Sjekker at dialogen er godkjent og at det er navn på filen
            {
                try
                {
                    if (lagreFilDialog.CheckPathExists) //Denne kan byttes om til switch hvis vi ønsker flere filtyper
                    {
                        if (lagreFilDialog.FilterIndex == 1)    //Indexen starter på 1
                        {
                            chart1.SaveImage(lagreFilDialog.FileName, ChartImageFormat.Png);
                        }
                        else if (lagreFilDialog.FilterIndex == 2)
                        {
                            chart1.SaveImage(lagreFilDialog.FileName, ChartImageFormat.Jpeg);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Filsti finnes ikke.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
