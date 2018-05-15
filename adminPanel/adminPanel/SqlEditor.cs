using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace adminPanel
{
    public partial class SqlEditor : UserControl
    {
        public SqlEditor()
        {
            InitializeComponent();
            feilmeldingTxt.ForeColor = Color.Red;
            LagreXmlBtn.Hide();
            LagreCsvBtn.Hide();
        }

        private void SqlBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            String sql = sqlTxt.Text;
            String[] fyOrd = { "DELETE", "TRUNCATE", "DROP", "INSERT", "UPDATE", "ALTER", "--", "FORMLOGIN", "GRANT", "REVOKE", "CALL" };

            /*
             * Dette arrayet inneholder ord som ikke kan godtas i SQL spørringer pga av sikkerhet.
             * 
             * I foreachen under blir SQL spørringen til brukeren sammenlignet opp
             * mot array med fyOrd ved hjelp av Contains() metoden. Vi har også brukt 
             * toUpper for at ordene som sammenlignes begge er i store bokstaver
             */

            foreach (string ord in fyOrd) 
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
                var da = db.DataAdapter(sql); //Kaller på egenlagd metode i Database.cs som returnerer dataadapter
                MySqlCommandBuilder sqlBygger = new MySqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds); //Data adapteret fyller på datasetet
                sqlDatagrid.DataSource = ds.Tables[0]; //Datasetet fyller på datagriden
                db.CloseConnection();
                LagreXmlBtn.Show();
                LagreCsvBtn.Show();
            }
            catch (Exception ex)
            {
                feilmeldingTxt.Text = "Spørring feilet, pass på at du har skrevet korrekt syntaks";
                Console.WriteLine(ex); //cw for debugging
            }

        }

        private void LagreXmlBtn_Click(object sender, EventArgs e)
        {

            /*
             * Datagridview objektet blir castet over til et datatable objekt
             * deretter lager vi et fildialog objekt
             * helt til slutt skriver vi ut datatable som xml og angir filnavnet brukeren taster i fildialogen
             */

            DataTable dt = (DataTable)sqlDatagrid.DataSource;
            SaveFileDialog lagreFilDialog = new SaveFileDialog();
            lagreFilDialog.Filter = "XML | *.xml";
            if (lagreFilDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dt.WriteXml(lagreFilDialog.FileName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void LagreCsvBtn_Click(object sender, EventArgs e)
        {

            /*
             * Denne metoden lar oss lagre SQL spørringen til brukeren
             * som en CSV fil
             */

            DataTable dt = (DataTable)sqlDatagrid.DataSource;
            SaveFileDialog lagreFilDialog = new SaveFileDialog();
            lagreFilDialog.Filter = "CSV | *.csv";

            int antallKolonner = sqlDatagrid.ColumnCount;
            int antallRader = sqlDatagrid.RowCount;

            if (lagreFilDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(lagreFilDialog.FileName);
                
                //Denne loopen får ut kolonne navnene, dette er vanligvis ikke med i csv filer, men vi tar det med.
                for (int i = 0; i < antallKolonner; i++)
                {
                    sw.Write(dt.Columns[i]);
                    //Denne sjekken gjør at siste linje ikke får komma
                    if (i < antallKolonner - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
                //Setter inn en ny linje

                foreach (DataRow rad in dt.Rows)
                {
                    for (int i = 0; i < antallKolonner; i++)
                    {
                        sw.Write(rad[i].ToString());
                        if (i < antallKolonner - 1)
                        {
                            sw.Write(",");
                            //sw.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator);

                            /*
                             * Denne linjen ville gitt oss et semikolon siden dette er seperatoren vi bruker i europa.
                             * den finnger ut hvilken seperator den skal sette basert på "kulturen" til din datamaskin
                             * linjen er bare med for å vise at dette er en mulighet
                             */
                        }
                    }
                    sw.Write(sw.NewLine);
                }
                sw.Close();
            }
        }
    }
}
