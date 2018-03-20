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

namespace adminPanel
{
    public partial class SammenlignFlereFagkoder : UserControl
    {
        public SammenlignFlereFagkoder()
        {
            InitializeComponent();
        }
        Database db = new Database();

        private void SammenlignFlereFagkoder_Load(object sender, EventArgs e)
        {
            String query = "SELECT DISTINCT fagkode FROM vurderingshistorikk;";
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
                FagkodeListbox.Items.Add(dr["Fagkode"].ToString());
            }
            db.CloseConnection();

            for (int i = 1; i < 6; i++)//Populerer listeboksen. Øk loopen for flere spørsmål.
            {                           //Hvis den økes må det lages flere prosedyrer i db og legges til i switchen under
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
        private void FlyttListeboksItems (ListBox kilde, ListBox destinasjon)
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

        private void SpmListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
