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
            dbConn.Close(); //lukke. Burde de åpnes/lukkes for vær gang? Spørr lasse https://softwareengineering.stackexchange.com/questions/142065/creating-database-connections-do-it-once-or-for-each-query

            spmListeboks.Hide();    //Gjemmer listeboksene til vi har data i de
            diagramListeboks.Hide();
        }

        private void fagkodeListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10 FROM vurderingshistorikk;", dbConn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0]; //plassering 0 fordi den kun henter ut en rad. i foreachen blir den splittet opp per rad og lagt inn en og en i listeboksen

            foreach (DataColumn dc in dt.Columns)  //her bruker vi dataColumn fordi vi skal ha ut kolonner
            {
                spmListeboks.Items.Add(dc.ToString());
                Console.WriteLine(dc);
            }
            spmListeboks.Show();
            dbConn.Close();

        }

        private void spmListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            diagramListeboks.Show();
            String[] diagramTyper = {"Kakediagram", "Stolpediagram" }; //Legg til flere diagrammer her når vi er i gang

            foreach (String diagram in diagramTyper)
            {
                diagramListeboks.Items.Add(diagram.ToString());
            }
        }

        private void diagramListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (diagramListeboks)
            {
                default:
                    break;
            }

            //bruke switch case for å sjekke valg i listeboksen. Som starter metode for å tegne diagrammet!
        }
    }
}
