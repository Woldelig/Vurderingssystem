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
        bool nyttSkjema = false; //bool variabel jeg bruker i forgrenningssjekk for å se om det er et nytt skjema eller et som endres
        String valgtSkjemaId = "";

        private void Schema_Load(object sender, EventArgs e)
        {
            lagreSkjemaBtn.Hide();
            skjemaListeboks.Hide();
            GjemController(); //Gjemmer unna alle textbokser og labels
        }

        private void LagSkjemaBtn_Click(object sender, EventArgs e)
        {
            String query = "";
            SjekkTextboksVerdi();
            if (nyttSkjema)
            {
                query = "INSERT INTO vurderingsskjema VALUES (NULL, @Beskrivelse, @Spm1, @Spm2, @Spm3, @Spm4, @Spm5, @Spm6, @Spm7, @Spm8, @Spm9, @Spm10);";
            }
            else
            {
                query = "UPDATE vurderingsskjema SET beskrivelse = @Beskrivelse, spm1 = @Spm1, spm2 = @Spm2, spm3 = @Spm3, spm4 = @Spm4, spm5 = @Spm5, spm6 = @Spm6, spm7 = @Spm7, spm8 = @Spm8, spm9 = @Spm9, spm10 = @Spm10 WHERE skjemaid = @Skjemaid";
            }
             
            var mySqlCommand = db.SqlCommand(query);
            if (!nyttSkjema) //Hvis skjema endres må jeg ha valgtSkjemaId som parameter i tillegg
            {
                Console.WriteLine(valgtSkjemaId);
                mySqlCommand.Parameters.AddWithValue("@Skjemaid", valgtSkjemaId);
            }
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
                if (nyttSkjema)
                {
                    resultatLbl.Text = "Spørreskjema er laget.";

                }
                else
                {
                    resultatLbl.Text = "Spørreskjema er endret.";

                }
                ClearTextbox();//tømmer textbokser
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            //Console.WriteLine(query); //Denne linjen kan brukes til å sjekke queryen som blir sendt ut
            db.CloseConnection();

        }

        private void LagNyttSkjema_Click(object sender, EventArgs e)
        {
            nyttSkjema = true;
            ClearTextbox();
            lagreSkjemaBtn.Show();
            HvisController();
            listboksLbl.Hide();
        }

        private void EndreSkjemaBtn_Click(object sender, EventArgs e)
        {
            skjemaListeboks.Items.Clear();
            nyttSkjema = false;
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

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lagreSkjemaBtn.Show();
            HvisController();
            listboksLbl.Hide();
            skjemaListeboks.Hide();
            try
            {
                String skjemaIdQuery = "SELECT skjemaid FROM vurderingsskjema WHERE beskrivelse = @Beskrivelse;";
                var cmdSkjemaId = db.SqlCommand(skjemaIdQuery);
                cmdSkjemaId.Parameters.AddWithValue("@Beskrivelse", skjemaListeboks.SelectedItem.ToString());
                db.OpenConnection();
                MySqlDataReader skjemaIdleser = cmdSkjemaId.ExecuteReader();
                while (skjemaIdleser.Read())
                {
                    valgtSkjemaId = skjemaIdleser[0].ToString();

                }
                Console.WriteLine(valgtSkjemaId);
                db.CloseConnection();

                String query = "SELECT beskrivelse, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10 FROM vurderingsskjema WHERE beskrivelse = @Beskrivelse";
                var cmd = db.SqlCommand(query);
                cmd.Parameters.AddWithValue("@Beskrivelse", skjemaListeboks.SelectedItem.ToString());
                db.OpenConnection();
                MySqlDataReader leser = cmd.ExecuteReader();
                Console.WriteLine(valgtSkjemaId);
                int j = 10;
                //Må sette j til 10 og ha j-- fordi foreach fylte opp boksene omvendt av hva man forventer
                foreach (TextBox c in this.Controls.OfType<TextBox>()) //this.Controls.OfType vil gjøre at vi kun foreacher textboksene innenfor THIS
                {
                    leser.Read();
                    ((TextBox)c).Text = leser[j].ToString();
                    j--;
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
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
