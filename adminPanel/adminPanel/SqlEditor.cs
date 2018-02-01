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
    public partial class SqlEditor : UserControl
    {
        Database db = new Database();
        public SqlEditor()
        {
            InitializeComponent();
        }

        private void sqlBtn_Click(object sender, EventArgs e)
        {
            String connString = "server=localhost;user=root;database=vurderingssystem;";//OBS OBS! HUSK Å ENDRE DATABSEN!
            MySqlConnection dbConn = new MySqlConnection(connString);
            String sql = sqlTxt.Text;
            String[] fyOrd = { "DELETE", "TRUNCATE", "DROP", "INSERT", "UPDATE", "ALTER", "--" }; //Ord som vi ikke vil ha i spørringen
       
            foreach (string ord in fyOrd)  //Her foreacher vi alle ordene i fyOrd for å se om sql spørringen inneholder ulovlige kommandoer
            {
                if (sql.ToUpperInvariant().Contains(ord.ToString()))
                {
                    feilmeldingTxt.ForeColor = Color.Red;
                    feilmeldingTxt.Text = "SQL spørring er ikke godkjent";
                    return;
                }
            }
            dbConn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(sql, dbConn);
            MySqlCommandBuilder sqlBygger = new MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            sqlDatagrid.DataSource = ds.Tables[0];

            dbConn.Close();


        }
    }
}
