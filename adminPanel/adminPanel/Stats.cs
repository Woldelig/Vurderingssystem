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

        Database db = new Database();

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
            dt = ds.Tables[0]; //plassering 0 fordi den kun henter ut en rad. i foreachen blir den splittet opp per rad og lagt inn en og en i listeboksen

            foreach (DataRow dr in dt.Rows)  //Her brukes datarow fordi vi skal ha ut rader
            {
                fagkodeListeboks.Items.Add(dr["Fagkode"].ToString());
            }
            //https://softwareengineering.stackexchange.com/questions/142065/creating-database-connections-do-it-once-or-for-each-query
            db.CloseConnection();

            spmListeboks.Hide();    //Gjemmer listeboksene og knapper til de har et bruksområde
            diagramListeboks.Hide();
            chart1.Hide();
            spmLbl.Hide();
            diagramLbl.Hide();
            clearListeboxBtn.Hide();
            printBtn.Hide();
            lagreChartBtn.Hide();
        }

        private void fagkodeListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Denne sjekken gjør at brukeren må trykke på en verdi for å få programmet til å fortsette
            //hvis denne sjekken ikke er der kan han bare trykke på det hvite området
            if (fagkodeListeboks.SelectedItem == null)
            {
                return;
            }

            //Fjerner elementer i listeboks.Må gjøres hvis klassekode byttes
            //Populerer listeboksen. Øk loopen for flere spørsmål.
            //Hvis den økes må det lages flere prosedyrer i db og legges til i switchen under
            spmListeboks.Items.Clear();
            for (int i = 1; i < 11; i++)
            {
                spmListeboks.Items.Add("Spørsmål " + i);
            }
            spmListeboks.Show();
            spmLbl.Show();
        }

        private void spmListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (spmListeboks.SelectedItem == null)
            {
                return;
            }
            //Fjerner elementer i listeboksen
            diagramListeboks.Items.Clear();
            diagramListeboks.Show();
            diagramLbl.Show();
            //Arrayet her inneholder de typer diagram vi kan vise frem
            String[] diagramTyper = { "Kakediagram", "Stolpediagram", "Linjediagram", "Radardiagram" };

            foreach (String diagram in diagramTyper)
            {
                diagramListeboks.Items.Add(diagram.ToString());
            }
        }

        private void diagramListeboks_SelectedIndexChanged(object sender, EventArgs e)
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

                //Valgt fagkode blir hentet ut og plassert som inn parameter
                String fagkode = fagkodeListeboks.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@in_fagkode", fagkode).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@out_verdi1", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@out_verdi2", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@out_verdi3", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@out_verdi4", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@out_verdi5", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                //På linjene over blir inn og ut parametere definert. Ut parametere får datatype (int). Og deretter blir parameter retning definert
                //dette kan også gjøres på 2 linjer.

                db.OpenConnection();
                cmd.ExecuteNonQuery();
                int stjerne1 = (int)cmd.Parameters["@out_verdi1"].Value;
                int stjerne2 = (int)cmd.Parameters["@out_verdi2"].Value;
                int stjerne3 = (int)cmd.Parameters["@out_verdi3"].Value;
                int stjerne4 = (int)cmd.Parameters["@out_verdi4"].Value;
                int stjerne5 = (int)cmd.Parameters["@out_verdi5"].Value;
                db.CloseConnection();


                //Her sjekker vi om det faktisk er data relatert til diagrammet, hvis ikke skrives det ut en feilmelding og det vises ingen diagram
                if (stjerne1 == 0 && stjerne2 == 0 && stjerne3 == 0 && stjerne4 == 0 && stjerne5 == 0)
                {
                    FeilmeldingsLbl.ForeColor = Color.Red;
                    FeilmeldingsLbl.Text = "Denne fagkoden eller spørsmålet har ikke fått inn nok vurderinger til å lage et diagram.";
                    chart1.Hide();
                    return;
                }
                FeilmeldingsLbl.Text = "";
                //Hvis forrige diagram hadde en feilmelding blir den fjernet på her.

                chart1.Series.Clear();
                chart1.Titles.Clear();
                string seriesname = "seriesName"; //Av en eller annen grunn heter den dette overalt på stackoverflow så følger det
                try
                {
                    bool diagramSkalHaFarger = false;
                    //hvis variabelen over settes til true vil det legges til egendefinerte farger på diagrammet
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

                            //Legger boksen på bunnen
                            chart1.Legends[0].Docking = Docking.Bottom;

                            //midtstiller boksen og strings i den
                            chart1.Legends[0].Alignment = StringAlignment.Center;
                            chart1.Legends[0].BorderColor = Color.Black;
                            diagramSkalHaFarger = true;
                            break;

                        case "Stolpediagram":
                            chart1.Series.Clear();
                            chart1.Legends.Clear();
                            chart1.Series.Add(seriesname);
                            chart1.Series[seriesname].ChartType = SeriesChartType.Column;
                            diagramSkalHaFarger = true;
                            break;

                        case "Linjediagram":
                            chart1.Series.Clear();
                            chart1.Legends.Clear();
                            chart1.Series.Add(seriesname);

                            //Setter tykkelsen på linjen
                            chart1.Series[seriesname].BorderWidth = 3;
                            chart1.Series[seriesname].ChartType = SeriesChartType.Line;
                            break;

                        case "Radardiagram":
                            chart1.Series.Clear();
                            chart1.Legends.Clear();
                            chart1.Series.Add(seriesname);
                            chart1.Series[seriesname].ChartType = SeriesChartType.Radar;
                            break;

                        default:
                            break;
                    }
                    //Setter en tittel på diagrammet
                    Title tittel = chart1.Titles.Add(fagkode + ": " + spmListeboks.SelectedItem);
                    tittel.Font = new Font("Verdana", 16, FontStyle.Bold);
                    chart1.Series[seriesname].Points.AddXY("1 Stjerne", stjerne1);
                    chart1.Series[seriesname].Points.AddXY("2 Stjerner", stjerne2);
                    chart1.Series[seriesname].Points.AddXY("3 Stjerner", stjerne3);
                    chart1.Series[seriesname].Points.AddXY("4 Stjerner", stjerne4);
                    chart1.Series[seriesname].Points.AddXY("5 Stjerner", stjerne5);

                    
                    if (diagramSkalHaFarger)
                    {
                        //Under blir det satt at det vises prosenter i figuren i tillegg til at farger velges
                        chart1.Series[seriesname].Label = "#PERCENT{P0}";
                        chart1.Series[seriesname].Points[0].Color = Color.Green;
                        chart1.Series[seriesname].Points[1].Color = Color.Red;
                        chart1.Series[seriesname].Points[2].Color = Color.LightBlue;
                        chart1.Series[seriesname].Points[3].Color = Color.Peru;
                        chart1.Series[seriesname].Points[4].Color = Color.Yellow;


                        //Her legges overskrifter manuelt til i legend, dette må gjøres hvis vi skal ha prosenter
                        chart1.Series[seriesname].Points[0].LegendText = "1 Stjerne";
                        chart1.Series[seriesname].Points[1].LegendText = "2 Stjerner";
                        chart1.Series[seriesname].Points[2].LegendText = "3 Stjerner";
                        chart1.Series[seriesname].Points[3].LegendText = "4 Stjerner";
                        chart1.Series[seriesname].Points[4].LegendText = "5 Stjerner";

                    }
                    chart1.Show();
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

        private void clearListeboxBtn_Click(object sender, EventArgs e)
        {
            diagramListeboks.ClearSelected();
            spmListeboks.ClearSelected();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            this.chart1.Printing.PrintPreview();
            //Åpner en dialog som lar deg printe ut diagrammet med en liten forhåndsvisning
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