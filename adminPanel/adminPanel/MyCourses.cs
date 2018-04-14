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

            ChartFeilmld2Lbl.Text = "";
            ChartFeilmldLbl.Text = "";
            SammenlignFeilmldLbl.Text = "";
            FagkodeDiagram1.Hide();
            FagkodeDiagram2.Hide();
            SkrivUtDiagram1Btn.Hide();
            SkrivUtDiagram2Btn.Hide();
            LagreDiagram1Btn.Hide();
            LagreDiagram2Btn.Hide();



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

            /*
             * Hvis det ikke er trykket på noen knapper vil fagkoden legges inn i den første tekstboksen.
             * Hvilken tekstboks fagkoden blir lagt inn i kommer an på variabelen som blir testet i If setningen
             * denne øker og trekkes fra for hver gang en knapp blir trykket så den bytter tekstboks vær gang
             */
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

            String fagkode1 = FagkodeNr1.Text;
            String fagkode2 = FagkodeNr2.Text;
            try
            {
                //Kaller på en metode som lager diagram basert på parameter
                LagDiagram(FagkodeDiagram1, fagkode1);
                LagDiagram(FagkodeDiagram2, fagkode2);
                SkrivUtDiagram1Btn.Show();
                SkrivUtDiagram2Btn.Show();
                LagreDiagram1Btn.Show();
                LagreDiagram2Btn.Show();
            }
            catch (Exception)
            {
                ChartFeilmld2Lbl.ForeColor = Color.Red;
                ChartFeilmldLbl.ForeColor = Color.Red;
                ChartFeilmld2Lbl.Text = "Noe gikk galt, prøv igjen senere.";
                ChartFeilmldLbl.Text = "Noe gikk galt, prøv igjen senere.";
            }
           


        }
        private void LagDiagram (Chart diagramNavn, String fagkode)
        {
            /*
             * Denne metoden lager diagram basert på parameter. Parameter 1 er navnet på diagrammet og parameter 2 er fagkoden
             * først blir series, legend og title tømt så man kan bytte fagkoder uten at noe henger igjen fra en tidligere sammenligning
             * Arrayene under passer på at alle spørsmål hentes ut og at de får blir lagt til i riktig serie (seriesname variabelen)
             */

            diagramNavn.Series.Clear();
            diagramNavn.Legends.Clear();
            diagramNavn.Titles.Clear();
            diagramNavn.ChartAreas.Clear();


            String seriesname = "";
            String[] ProsedyreNavnArray = new String[] { "hent_spm1_verdier", "hent_spm2_verdier", "hent_spm3_verdier", "hent_spm4_verdier", "hent_spm5_verdier" };
            String[] SpørsmålNr = new String[] { "Spørsmål 1", "Spørsmål 2", "Spørsmål 3", "Spørsmål 4", "Spørsmål 5" };
            for (int i = 0; i < ProsedyreNavnArray.Length; i++)
            {
                int[] prosedyreSvar = ProsedyreUtfører(fagkode, ProsedyreNavnArray[i]);
                seriesname = SpørsmålNr[i];
                //Legger til data for fagkode 1
                diagramNavn.Series.Add(seriesname);
                if (i == 0)
                {
                    diagramNavn.Legends.Add("Legende");
                    Title tittel = diagramNavn.Titles.Add(fagkode);
                    tittel.Font = new Font("Verdana", 16, FontStyle.Bold);
                    diagramNavn.ChartAreas.Add("ChartArea");
                    diagramNavn.ChartAreas["ChartArea"].AxisY.Title = "Antall forekomster";
                }
                diagramNavn.Series[seriesname].BorderWidth = 3;
                diagramNavn.Series[seriesname].ChartType = SeriesChartType.Line;
                diagramNavn.Series[seriesname].Points.AddXY("1 Stjerne", prosedyreSvar[0]);
                diagramNavn.Series[seriesname].Points.AddXY("2 Stjerner", prosedyreSvar[1]);
                diagramNavn.Series[seriesname].Points.AddXY("3 Stjerner", prosedyreSvar[2]);
                diagramNavn.Series[seriesname].Points.AddXY("4 Stjerner", prosedyreSvar[3]);
                diagramNavn.Series[seriesname].Points.AddXY("5 Stjerner", prosedyreSvar[4]);
                diagramNavn.Show();
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

       
        private void LagreDiagram (Chart diagramSomSkalLagres)
        {
            /*
             * Denne metoden lagrer diagrammet som blir sendt inn som parameter
             */
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
                            diagramSomSkalLagres.SaveImage(lagreFilDialog.FileName, ChartImageFormat.Png);
                        }
                        else if (lagreFilDialog.FilterIndex == 2)
                        {
                            diagramSomSkalLagres.SaveImage(lagreFilDialog.FileName, ChartImageFormat.Jpeg);
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
        private void SkrivUtDiagram (Chart diagramSomSkalSkrivesUt)
        {
            /*
             * Denne metoden skriver ut det diagrammet som blir sendt inn som parameter
             */
            diagramSomSkalSkrivesUt.Printing.PrintPreview();
        }
     

        private void LagreDiagram1Btn_Click(object sender, EventArgs e)
        {
            LagreDiagram(FagkodeDiagram1);

        }

        private void LagreDiagram2Btn_Click(object sender, EventArgs e)
        {
            LagreDiagram(FagkodeDiagram2);

        }

        private void SkrivUtDiagram2Btn_Click(object sender, EventArgs e)
        {
            SkrivUtDiagram(FagkodeDiagram2);

        }
        private void SkrivUtDiagram1Btn_Click(object sender, EventArgs e)
        {
            SkrivUtDiagram(FagkodeDiagram1);

        }
    }
}
