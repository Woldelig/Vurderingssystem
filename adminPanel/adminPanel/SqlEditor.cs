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
        public SqlEditor()
        {
            InitializeComponent();
            feilmeldingTxt.ForeColor = Color.Red;
        }

        private void sqlBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            String sql = sqlTxt.Text;
            String[] fyOrd = { "DELETE", "TRUNCATE", "DROP", "INSERT", "UPDATE", "ALTER", "--", "FORMLOGIN", "GRANT", "REVOKE" };
            //Ord som vi ikke vil ha i spørringen, store bokstaver siden vi bruker toUpper

            foreach (string ord in fyOrd)  //Her foreacher vi alle ordene i fyOrd for å se om sql spørringen inneholder ulovlige kommandoer
            {
                if (sql.ToUpperInvariant().Contains(ord.ToString()))
                {
                    feilmeldingTxt.Text = "SQL spørringen inneholder ulovlige ord.";
                    return;
                }
            }

            try
            {
                db.OpenConnection();
                var da = db.DataAdapter(sql); //Kaller på egenlagd metode som returnerer dataadapter
                MySqlCommandBuilder sqlBygger = new MySqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds); //Data adapteret fyller på datasetet
                sqlDatagrid.DataSource = ds.Tables[0]; //Datasetet fyller på datagriden
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                feilmeldingTxt.Text = "Spørring feilet, pass på at du har skrevet korrekt syntaks";
                Console.WriteLine(ex); //cw for debugging
            }
        }
    }
}
