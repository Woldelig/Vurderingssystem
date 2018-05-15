using System;
using System.Drawing;
using System.Data;
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

         private Database db = new Database();

        private void Stats_Load(object sender, EventArgs e)
        {
            String query = "SELECT fagkode FROM fag;";
            var cmd = db.SqlCommand(query);
            db.OpenConnection();

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            //plassering 0 fordi den kun henter ut en rad. i foreachen blir den splittet opp per rad og lagt inn en og en i listeboksen
            dt = ds.Tables[0];

            //Her brukes datarow fordi vi skal ha ut rader
            foreach (DataRow dr in dt.Rows)
            {
                fagkodeListeboks.Items.Add(dr["Fagkode"].ToString());
            }
            db.CloseConnection();

            //Gjemmer listeboksene og knapper til de har et bruksområde
            spmListeboks.Hide();    
            diagramListeboks.Hide();
            diagram.Hide();
            spmLbl.Hide();
            diagramLbl.Hide();
            clearListeboxBtn.Hide();
            printBtn.Hide();
            lagreChartBtn.Hide();
        }

        private void FagkodeListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * Denne sjekken gjør at brukeren må trykke på en verdi for å få programmet til å fortsette
             * hvis denne sjekken ikke er der kan han bare trykke på det hvite området noe som skaper
             * en exception
             */

            if (fagkodeListeboks.SelectedItem == null)
            {
                return;
            }

            /*
             * Fjerner elementer i listeboks. Dette må gjøres brukeren endrer fagkoden.
             * Listeboksen blir populert med en for loop.
             */

            spmListeboks.Items.Clear();
            for (int i = 1; i < 11; i++)
            {
                spmListeboks.Items.Add("Spørsmål " + i);
            }
            spmListeboks.Show();
            spmLbl.Show();
        }

        private void SpmListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (spmListeboks.SelectedItem == null)
            {
                return;
            }
            //Fjerner elementer i listeboksen
            diagramListeboks.Items.Clear();
            diagramListeboks.Show();
            diagramLbl.Show();

            //Arrayet inneholder de typer diagram vi kan vise frem
            String[] diagramTyper = { "Kakediagram", "Stolpediagram", "Linjediagram", "Radardiagram" };

            foreach (String diagram in diagramTyper)
            {
                diagramListeboks.Items.Add(diagram.ToString());
            }
        }

        private void DiagramListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (diagramListeboks.SelectedItem == null)
            {
                return;
            }
            try
            {
                clearListeboxBtn.Show();
                printBtn.Show();
                lagreChartBtn.Show();

                //Lager cmd objektet, sender tomstreng så vi får laget objektet
                var cmd = db.SqlCommand("");

                //Her legger vi inn hvilken prosedyre vi kaller på
                switch (spmListeboks.SelectedIndex)
                {
                    case 0:
                        //Legger til commandtext i cmd objektet
                        cmd.CommandText = "hent_spm1_verdier"; 
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

                    case 5:
                        cmd.CommandText = "hent_spm6_verdier";
                        break;

                    case 6:
                        cmd.CommandText = "hent_spm7_verdier";
                        break;

                    case 7:
                        cmd.CommandText = "hent_spm8_verdier";
                        break;

                    case 8:
                        cmd.CommandText = "hent_spm9_verdier";
                        break;

                    case 9:
                        cmd.CommandText = "hent_spm10_verdier";
                        break;

                    default:
                        break;
                }
                //Setter at cmd sender en stored procedure - prosedyre
                cmd.CommandType = CommandType.StoredProcedure;


                String fagkode = fagkodeListeboks.SelectedItem.ToString();
                
                //Valgt fagkode blir hentet ut og plassert som inn parameter
                cmd.Parameters.AddWithValue("@in_fagkode", fagkode).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@out_verdi1", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@out_verdi2", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@out_verdi3", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@out_verdi4", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@out_verdi5", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                //På linjene over blir inn og ut parametere definert. Ut parametere får datatype (int). Og deretter blir parameter retning definert

                db.OpenConnection();
                cmd.ExecuteNonQuery();
                int stjerne1 = (int)cmd.Parameters["@out_verdi1"].Value;
                int stjerne2 = (int)cmd.Parameters["@out_verdi2"].Value;
                int stjerne3 = (int)cmd.Parameters["@out_verdi3"].Value;
                int stjerne4 = (int)cmd.Parameters["@out_verdi4"].Value;
                int stjerne5 = (int)cmd.Parameters["@out_verdi5"].Value;
                db.CloseConnection();


                //Her sjekker vi om vi har fått ut noe data, hvis ikke skrives det ut en feilmelding
                if (stjerne1 == 0 && stjerne2 == 0 && stjerne3 == 0 && stjerne4 == 0 && stjerne5 == 0)
                {
                    FeilmeldingsLbl.ForeColor = Color.Red;
                    FeilmeldingsLbl.Text = "Denne fagkoden eller spørsmålet har ikke fått inn nok vurderinger til å lage et diagram.";
                    diagram.Hide();
                    return;
                }
                FeilmeldingsLbl.Text = "";
                //Hvis forrige diagram hadde en feilmelding blir den fjernet på her.

                diagram.Series.Clear();
                diagram.Titles.Clear();
                string seriesname = "seriesName";
                try
                {
                    bool diagramSkalHaFarger = false;
                    //hvis variabelen over settes til true vil det legges til egendefinerte farger på diagrammet
                    switch (diagramListeboks.SelectedItem.ToString())
                    {
                        case "Kakediagram":
                            //De to første linjene "tømmer" chart1 sin Series og Legends,
                            //ved å gjøre dette kan man switche frem og tilbake uten at applikasjonen feiler
                            diagram.Series.Clear();
                            diagram.Legends.Clear();
                            diagram.ChartAreas.Clear();
                            diagram.Series.Add(seriesname);
                            diagram.Series[seriesname].ChartType = SeriesChartType.Pie;
                            diagram.Legends.Add("Legende");

                            //Legger legends på bunnen av diagramet
                            diagram.Legends[0].Docking = Docking.Bottom;

                            //midtstiller strings som er i legend
                            diagram.Legends[0].Alignment = StringAlignment.Center;
                            diagram.Legends[0].BorderColor = Color.Black;
                            diagramSkalHaFarger = true;
                            break;

                        case "Stolpediagram":
                            diagram.Series.Clear();
                            diagram.Legends.Clear();
                            diagram.ChartAreas.Clear();
                            diagram.Series.Add(seriesname);
                            diagram.Series[seriesname].ChartType = SeriesChartType.Column;
                            diagram.ChartAreas.Add("ChartArea");
                            diagram.ChartAreas["ChartArea"].AxisY.Title = "Antall forekomster";
                            diagramSkalHaFarger = true;
                            break;

                        case "Linjediagram":
                            diagram.Series.Clear();
                            diagram.Legends.Clear();
                            diagram.ChartAreas.Clear();
                            diagram.Series.Add(seriesname);

                            //Setter tykkelsen på linjen
                            diagram.Series[seriesname].BorderWidth = 3;
                            diagram.Series[seriesname].ChartType = SeriesChartType.Line;
                            diagram.ChartAreas.Add("ChartArea");
                            diagram.ChartAreas["ChartArea"].AxisY.Title = "Antall forekomster";
                            break;

                        case "Radardiagram":
                            diagram.Series.Clear();
                            diagram.Legends.Clear();
                            diagram.ChartAreas.Clear();
                            diagram.Series.Add(seriesname);
                            diagram.Series[seriesname].ChartType = SeriesChartType.Radar;
                            diagram.ChartAreas.Add("ChartArea");

                            break;

                        default:
                            break;
                    }
                    //Setter en tittel på diagrammet
                    Title tittel = diagram.Titles.Add(fagkode + ": " + spmListeboks.SelectedItem);
                    tittel.Font = new Font("Verdana", 16, FontStyle.Bold);
                    diagram.Series[seriesname].Points.AddXY("1 Stjerne", stjerne1);
                    diagram.Series[seriesname].Points.AddXY("2 Stjerner", stjerne2);
                    diagram.Series[seriesname].Points.AddXY("3 Stjerner", stjerne3);
                    diagram.Series[seriesname].Points.AddXY("4 Stjerner", stjerne4);
                    diagram.Series[seriesname].Points.AddXY("5 Stjerner", stjerne5);

                    
                    if (diagramSkalHaFarger)
                    {
                        //Under blir det satt at det vises prosenter i figuren i tillegg til at farger velges
                        diagram.Series[seriesname].Label = "#PERCENT{P0}";
                        diagram.Series[seriesname].Points[0].Color = Color.Green;
                        diagram.Series[seriesname].Points[1].Color = Color.Red;
                        diagram.Series[seriesname].Points[2].Color = Color.LightBlue;
                        diagram.Series[seriesname].Points[3].Color = Color.Peru;
                        diagram.Series[seriesname].Points[4].Color = Color.Yellow;


                        //Her legges overskrifter manuelt til i legend, dette må gjøres hvis vi skal ha prosenter
                        diagram.Series[seriesname].Points[0].LegendText = "1 Stjerne";
                        diagram.Series[seriesname].Points[1].LegendText = "2 Stjerner";
                        diagram.Series[seriesname].Points[2].LegendText = "3 Stjerner";
                        diagram.Series[seriesname].Points[3].LegendText = "4 Stjerner";
                        diagram.Series[seriesname].Points[4].LegendText = "5 Stjerner";

                    }
                    diagram.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void ClearListeboxBtn_Click(object sender, EventArgs e)
        {
            diagramListeboks.ClearSelected();
            spmListeboks.ClearSelected();
            diagram.Series.Clear();
            diagram.Legends.Clear();
            diagram.ChartAreas.Clear();
            diagram.Titles.Clear();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            this.diagram.Printing.PrintPreview();
            //Åpner en dialog som lar deg printe ut diagrammet med en liten forhåndsvisning
        }

        private void LagreChartBtn_Click(object sender, EventArgs e)
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
                            diagram.SaveImage(lagreFilDialog.FileName, ChartImageFormat.Png);
                        }
                        else if (lagreFilDialog.FilterIndex == 2)
                        {
                            diagram.SaveImage(lagreFilDialog.FileName, ChartImageFormat.Jpeg);
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