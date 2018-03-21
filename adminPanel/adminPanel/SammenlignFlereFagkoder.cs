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
    public partial class SammenlignFlereFagkoder : UserControl
    {
        public SammenlignFlereFagkoder()
        {
            InitializeComponent();
        }
        Database db = new Database();
        String prosedyrenavn;

        private void SammenlignFlereFagkoder_Load(object sender, EventArgs e)
        {
            //Gjemmer knapper til diagrammet er tegnet
            chart1.Hide();
            printBtn.Hide();
            lagreChartBtn.Hide();
            ClearDiagramBtn.Hide();
            UpdateDiagramBtn.Hide();
            FeilmldLbl.Text = "";
            FeilmldLbl.ForeColor = Color.Red;

            String query = "SELECT DISTINCT fagkode FROM vurderingshistorikk;";
            var cmd = db.SqlCommand(query);

            db.OpenConnection();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            //plassering 0 fordi den kun henter ut en rad. i foreachen blir den splittet opp per rad og lagt inn en og en i listeboksen

            foreach (DataRow dr in dt.Rows)  //Her brukes datarow fordi vi skal ha ut rader
            {
                FagkodeListbox.Items.Add(dr["Fagkode"].ToString());
            }
            db.CloseConnection();

            for (int i = 1; i < 6; i++)//Populerer listeboksen. Øk loopen for flere spørsmål.
            {
                SpmListeboks.Items.Add("Spørsmål " + i);
            }
        }

        private void Fra1Til2Btn_Click(object sender, EventArgs e)
        {
            FlyttListeboksItems(FagkodeListbox, FagkodeSammenlignesListebox);
        }


        private void Fra2Til1Btn_Click(object sender, EventArgs e)
        {
            FlyttListeboksItems(FagkodeSammenlignesListebox, FagkodeListbox);
        }
        private void FlyttListeboksItems(ListBox kilde, ListBox destinasjon)
        {
            //Under lages en objectcollection av valgte elementer
            ListBox.SelectedObjectCollection valgteItems = kilde.SelectedItems;

            //objectcollection blir brukt som en foreach
            foreach (var item in valgteItems)
            {
                destinasjon.Items.Add(item);
            }

            //Her fjernes de valgte elementene fra sin originale listeboks
            while (kilde.SelectedItems.Count > 0)
            {
                kilde.Items.Remove(kilde.SelectedItems[0]);
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

        private void SpmListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                printBtn.Show();
                lagreChartBtn.Show();
                ClearDiagramBtn.Show();
                UpdateDiagramBtn.Show();
                String seriesname;
                switch (SpmListeboks.SelectedIndex)
                {
                    case 0:
                        prosedyrenavn = "hent_spm1_verdier";
                        break;

                    case 1:
                        prosedyrenavn = "hent_spm2_verdier";
                        break;

                    case 2:
                        prosedyrenavn = "hent_spm3_verdier";
                        break;

                    case 3:
                        prosedyrenavn = "hent_spm4_verdier";
                        break;

                    case 4:
                        prosedyrenavn = "hent_spm5_verdier";
                        break;
                    default:
                        break;
                }

                chart1.Legends.Clear();
                chart1.Series.Clear();
                chart1.Legends.Add("Legende");
                /* 
                 * Loopen går for så mange fagkoder det er i listeboksen
                 * og legger til nye linjer på diagrammet og fagkoden til i legenden
                 */
                foreach (String fagkode in FagkodeSammenlignesListebox.Items)
                {
                    int[] prosedyreSvar = ProsedyreUtfører(fagkode, prosedyrenavn);
                    seriesname = fagkode;

                    chart1.Series.Add(seriesname);
                    chart1.Series[seriesname].BorderWidth = 3;
                    chart1.Series[seriesname].ChartType = SeriesChartType.Line;
                    chart1.Series[seriesname].Points.AddXY("1 Stjerne", prosedyreSvar[0]);
                    chart1.Series[seriesname].Points.AddXY("2 Stjerner", prosedyreSvar[1]);
                    chart1.Series[seriesname].Points.AddXY("3 Stjerner", prosedyreSvar[2]);
                    chart1.Series[seriesname].Points.AddXY("4 Stjerner", prosedyreSvar[3]);
                    chart1.Series[seriesname].Points.AddXY("5 Stjerner", prosedyreSvar[4]);
                    chart1.DataBind();

                    chart1.Show();
                }
                //for (int i = 0; i < FagkodeSammenlignesListebox.Items.Count; i++){} Alternativ til foreach                    

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
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

        private void printBtn_Click(object sender, EventArgs e)
        {
            this.chart1.Printing.PrintPreview();
        }

        private void ClearDiagramBtn_Click(object sender, EventArgs e)
        {
            chart1.Legends.Clear();
            chart1.Series.Clear();
        }

        private void UpdateDiagramBtn_Click(object sender, EventArgs e)
        {
            SpmListeboks_SelectedIndexChanged(null, new EventArgs());
        }

        private void ResetListboxBtn_Click(object sender, EventArgs e)
        {
            /*
             * Denne knappen fjerner alle elementer i FagkodeSammenlignesListebox
             * og legger dem tilbake i FagkodeListbox
             */
            ListBox.ObjectCollection elementer = FagkodeSammenlignesListebox.Items;

            foreach (var item in elementer)
            {
                FagkodeListbox.Items.Add(item);
            }

            while (FagkodeSammenlignesListebox.Items.Count > 0)
            {
                FagkodeSammenlignesListebox.Items.Remove(FagkodeSammenlignesListebox.Items[0]);
            }
        }

        private void LeggTilAlleBtn_Click(object sender, EventArgs e)
        {
            /*
             * Denne knappen fjerner alle elementer i FagkodeListebox
             * og legger dem i FagkodeSammenlignesListebox
             */
            ListBox.ObjectCollection elementer = FagkodeListbox.Items;

            foreach (var item in elementer)
            {
                FagkodeSammenlignesListebox.Items.Add(item);
            }

            while (FagkodeListbox.Items.Count > 0)
            {
                FagkodeListbox.Items.Remove(FagkodeListbox.Items[0]);
            }
        }
    }
}
