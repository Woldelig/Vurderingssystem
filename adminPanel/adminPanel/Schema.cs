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
    public partial class Schema : UserControl
    {
        public Schema()
        {
            InitializeComponent();
        }
        Database db = new Database();

        private void Schema_Load(object sender, EventArgs e)
        {
            lagreSkjemaBtn.Hide();
            skjemaListeboks.Hide();
            GjemController(); //Gjemmer unna alle textbokser og labels

        }

        private void lagSkjemaBtn_Click(object sender, EventArgs e)
        {

            SjekkTextboksVerdi();
            String query = "INSERT INTO vurderingsskjema VALUES (NULL, @Beskrivelse, @Spm1, @Spm2, @Spm3, @Spm4, @Spm5, @Spm6, @Spm7, @Spm8, @Spm9, @Spm10);";
            var mySqlCommand = db.SqlCommand(query);
            mySqlCommand.Parameters.AddWithValue("@Beskrivelse", beskrivelseTxt.Text);
            mySqlCommand.Parameters.AddWithValue("@Spm1", spm1Txt.Text);
            mySqlCommand.Parameters.AddWithValue("@Spm2", spm2Txt.Text);
            mySqlCommand.Parameters.AddWithValue("@Spm3", spm3Txt.Text);
            mySqlCommand.Parameters.AddWithValue("@Spm4", spm4Txt.Text);
            mySqlCommand.Parameters.AddWithValue("@Spm5", spm5Txt.Text);
            mySqlCommand.Parameters.AddWithValue("@Spm6", spm6Txt.Text);
            mySqlCommand.Parameters.AddWithValue("@Spm7", spm7Txt.Text);
            mySqlCommand.Parameters.AddWithValue("@Spm8", spm8Txt.Text);
            mySqlCommand.Parameters.AddWithValue("@Spm9", spm9Txt.Text);
            mySqlCommand.Parameters.AddWithValue("@Spm10", spm10Txt.Text);
            db.OpenConnection();

            try
            {
                mySqlCommand.ExecuteNonQuery();
                resultatLbl.Text = "Spørreskjema er laget";
                ClearTextbox();//tømmer textbokser
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            Console.WriteLine(query);
            db.CloseConnection();

        }

        private void lagNyttSkjema_Click(object sender, EventArgs e)
        {
            lagreSkjemaBtn.Show();
            HvisController();
            listboksLbl.Hide();
        }

        private void endreSkjemaBtn_Click(object sender, EventArgs e)
        {
            listboksLbl.Show();
            skjemaListeboks.Show();
            String query = "SELECT beskrivelse FROM vurderingsskjema;";
            db.OpenConnection();
            var cmd = db.SqlCommand(query);
            MySqlDataReader leser = cmd.ExecuteReader();
            while (leser.Read())
            {
                skjemaListeboks.Items.Add(leser["Beskrivelse"].ToString());
            }
            db.CloseConnection();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lagreSkjemaBtn.Show();
            HvisController();
            listboksLbl.Hide();
            skjemaListeboks.Hide();
            String query = "SELECT beskrivelse, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10 FROM vurderingsskjema WHERE beskrivelse = @Beskrivelse";
            var cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@Beskrivelse", skjemaListeboks.SelectedItem.ToString());
            db.OpenConnection();
            MySqlDataReader leser = cmd.ExecuteReader();
            String[] radArray = new String[11];
            int i = 0;
            while (leser.Read())
            {
                for (; i < 11; i++)
                {
                    radArray[i] = Convert.ToString(leser[i]);
                    //radArray[i] = leser[i].ToString();
                    Console.WriteLine(radArray[i].ToString());
                }
            }

            int j = 0;
            foreach (TextBox c in this.Controls.OfType<TextBox>())
            {
                ((TextBox)c).Text = radArray[j].ToString();
                j++;
            }
            db.CloseConnection();
        }
        private void GjemController() {
            foreach (var c in Controls) //denne foreachen vil gjemme all labels og textbokser for brukeren
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Hide();
                }
                if (c is Label)
                {
                    ((Label)c).Hide();
                }
            }
        }

        private void HvisController()
        {
            foreach (var c in Controls) //denne foreachen vil vise alle kontrollerne
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Show();
                }
                if (c is Label)
                {
                    ((Label)c).Show();
                }
            }
        }
        private void ClearTextbox()
        {
            foreach (var c in Controls) //denne foreachen vil tømme alle textboksene i formen
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        private void SjekkTextboksVerdi()
        {
            foreach (Control c in this.Controls) //Denne foreachen sjekker om samtlige tekstbokser er fylt ut. Og avbryter koden hvis ikke
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        resultatLbl.ForeColor = Color.Red;
                        resultatLbl.Text = "Fyll ut alle tekstfelt.";
                        return;
                    }
                }
            }
        }
    }
}
