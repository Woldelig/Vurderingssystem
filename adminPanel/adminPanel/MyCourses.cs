using System;
using System.Drawing;
using System.Data;
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

        //Denne variabelen blir brukt til validering. Mer informasjon finner du i Button_Click metoden under
        int antallGangerKnappenErTrykket = 0;
        private void MyCourses_Load(object sender, EventArgs e)
        {
            String sql = "SELECT DISTINCT fagkode FROM vurderingshistorikk;";
            var mySqlCommand = db.SqlCommand(sql);
           
            /*
             * Her defineres variabler som brukes til
             * å holde styr på hvor mange knapper 
             * vi skal ha per rad
             */

            int row = 0; //10
            int column = 0; //3
            String fagkode = "";

            //Her gjemmer vi bort elementer som ikke trenger å være synlig
            DiagramFeilmld2Lbl.Text = "";
            DiagramFeilmldLbl.Text = "";
            SammenlignFeilmldLbl.Text = "";
            FagkodeDiagram1.Hide();
            FagkodeDiagram2.Hide();
            SkrivUtDiagram1Btn.Hide();
            SkrivUtDiagram2Btn.Hide();
            LagreDiagram1Btn.Hide();
            LagreDiagram2Btn.Hide();


            /*
             * Under blir det generert en knapp til hver unike
             * fagkode som er i databasen. Brukeren kan da trykke på to
             * uliker fagkoder som da blir sammenlignet.
             */

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
             * Hvis det ikke er trykket på noen knapper tidligere vil fagkoden legges inn i den første tekstboksen og variabelen
             * antallGangerKnappenErtrykket vil øke med en, dette gjør at neste gang en knapp trykkes vil denne
             * fagkoden legges i neste tekstboks. Når en fagkode legges i tekstboks nummer 2 vil variabelen bli
             * satt tilbake til 0. Dette gir en flytt i programmet så man bare trenger å trykke på fagkodene for å 
             * fylle på tekstboksene for sammenligning.
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
            //Sjekker om brukeren har valgt ulike to fagkoder, og avbryter operasjonen hvis det ikke er det
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
                DiagramFeilmld2Lbl.ForeColor = Color.Red;
                DiagramFeilmldLbl.ForeColor = Color.Red;
                DiagramFeilmld2Lbl.Text = "Noe gikk galt, prøv igjen senere.";
                DiagramFeilmldLbl.Text = "Noe gikk galt, prøv igjen senere.";
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

            /*
             * Her har vi lagt inn alle prosedyrenavnene som et tekstarray fordi
             * vi skal ha ut verdiene til alle de 5 første spørsmålene i en vurdering.
             * For loopen vil deretter kalle på metoden ProsedyreUtfører som vil legge 
             * inn alle spørsmålsverdiene som hver sin linje i dette linjediagrammet.
             */

            String seriesname = "";
            String[] ProsedyreNavnArray = new String[] { "hent_spm1_verdier", "hent_spm2_verdier", "hent_spm3_verdier", "hent_spm4_verdier", "hent_spm5_verdier" };
            String[] SpørsmålNr = new String[] { "Spørsmål 1", "Spørsmål 2", "Spørsmål 3", "Spørsmål 4", "Spørsmål 5" };
            for (int i = 0; i < ProsedyreNavnArray.Length; i++)
            {
                int[] prosedyreSvar = ProsedyreUtfører(fagkode, ProsedyreNavnArray[i]);
                seriesname = SpørsmålNr[i];
                //Legger til data for fagkode 1
                diagramNavn.Series.Add(seriesname);

                //Linjene i denne if setningen skal kun kjøres en gang. Linjene setter font, tittel og lignende.
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
             * Metoden utfører en prosedyre basert på parameter. Og returnerer et int array
             * prosedyrenavn og fagkode blir sendt inn som parameter
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
