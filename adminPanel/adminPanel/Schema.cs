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
        //bool variabel jeg bruker i forgrenningssjekk for å se om det er et nytt skjema eller et som endres
        bool nyttSkjema = false;
        String valgtSkjemaId = "";

        private void Schema_Load(object sender, EventArgs e)
        {
            lagreSkjemaBtn.Hide();
            SkjemaListeboks.Hide();
            GjemController(); //Gjemmer unna alle textbokser og labels
        }

        private void LagSkjemaBtn_Click(object sender, EventArgs e)
        {
            /*
             * Denne foreachen sjekker om samtlige tekstbokser er fylt ut. 
             * Hvis det er en tekstboks som ikke er fyllt ut, vil koden
             * avbrytes med return;
             */
            foreach (Control c in this.Controls)
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

            String query = "";
            /*
             * Her sjekkes det om det er et helt nytt vurderingsskjema ved hjelp av 
             * bool variabelen som ble deklarert tidligere. Hvis det ikke er et nytt skjema
             * må vi ha en UPDATE setning istedenfor INSERT setning
             */
            if (nyttSkjema)
            {
                query = "INSERT INTO vurderingsskjema VALUES (NULL, @Fagkode, @Spm1, @Spm2, @Spm3, @Spm4, @Spm5, @Spm6, @Spm7, @Spm8, @Spm9, @Spm10);";
            }
            else
            {
                query = "UPDATE vurderingsskjema SET fagkode = @Fagkode, spm1 = @Spm1, spm2 = @Spm2, spm3 = @Spm3, spm4 = @Spm4, spm5 = @Spm5, spm6 = @Spm6, spm7 = @Spm7, spm8 = @Spm8, spm9 = @Spm9, spm10 = @Spm10 WHERE skjemaid = @Skjemaid";
            }
             
            var mySqlCommand = db.SqlCommand(query);
            if (!nyttSkjema) //Hvis skjema endres må jeg ha valgtSkjemaId som parameter i tillegg
            {
                mySqlCommand.Parameters.AddWithValue("@Skjemaid", valgtSkjemaId);
            }
            mySqlCommand.Parameters.AddWithValue("@Fagkode", fagkodeTxt.Text);
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
                //en metode som tømmer textbokser
                ClearTextbox();
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
            String hentStandardSpm = "SELECT spm1, spm2, spm3, spm4, spm5 FROM vurderingsskjema WHERE fagkode = 'standard'";
            var cmd = db.SqlCommand(hentStandardSpm);
            db.OpenConnection();
            MySqlDataReader leser = cmd.ExecuteReader();

            //Foreachen under fyller på de 5 første standard spørsmålene
            foreach (TextBox c in this.Controls.OfType<TextBox>())
            {
                leser.Read();
                if (c == spm1Txt){((TextBox)c).Text = leser[0].ToString();}
                if (c == spm2Txt){((TextBox)c).Text = leser[1].ToString();}
                if (c == spm3Txt){((TextBox)c).Text = leser[2].ToString();}
                if (c == spm4Txt){((TextBox)c).Text = leser[3].ToString();}
                if (c == spm5Txt){((TextBox)c).Text = leser[4].ToString();}
            }
            leser.Close();
            db.CloseConnection();
        }

        private void EndreSkjemaBtn_Click(object sender, EventArgs e)
        {
            SkjemaListeboks.Items.Clear();
            nyttSkjema = false;
            listboksLbl.Show();
            SkjemaListeboks.Show();
            String query = "SELECT fagkode FROM vurderingsskjema;";
            db.OpenConnection();
            var cmd = db.SqlCommand(query);
            MySqlDataReader leser = cmd.ExecuteReader();
            while (leser.Read())
            {
                SkjemaListeboks.Items.Add(leser["fagkode"].ToString());

                //Linjen under sjekkerom standard skjemaet kommer inn i listeboksen. Og fjerner den hvis den kommer der
                if (SkjemaListeboks.Items.Contains("standard"))
                {
                    SkjemaListeboks.Items.Remove("standard");
                }
            }
            db.CloseConnection();
        }

        private void SkjemaListeboks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SkjemaListeboks.SelectedItem == null)
            {
                return;
            }


            lagreSkjemaBtn.Show();
            HvisController();
            listboksLbl.Hide();
            SkjemaListeboks.Hide();
            try
            {
                String skjemaIdQuery = "SELECT skjemaid FROM vurderingsskjema WHERE fagkode = @Fagkode;";
                var cmdSkjemaId = db.SqlCommand(skjemaIdQuery);
                cmdSkjemaId.Parameters.AddWithValue("@Fagkode", SkjemaListeboks.SelectedItem.ToString());
                db.OpenConnection();
                MySqlDataReader skjemaIdleser = cmdSkjemaId.ExecuteReader();
                while (skjemaIdleser.Read())
                {
                    valgtSkjemaId = skjemaIdleser[0].ToString();
                }

                db.CloseConnection();

                String query = "SELECT fagkode, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10 FROM vurderingsskjema WHERE fagkode = @Fagkode";
                var cmd = db.SqlCommand(query);
                cmd.Parameters.AddWithValue("@Fagkode", SkjemaListeboks.SelectedItem.ToString());

                db.OpenConnection();
                MySqlDataReader leser = cmd.ExecuteReader();
                //Må sette j til 10 og ha j-- fordi foreach fylte opp boksene omvendt av hva man forventer
                int j = 10;

                //this.Controls.OfType vil gjøre at vi kun foreacher textboksene innenfor THIS
                foreach (TextBox c in this.Controls.OfType<TextBox>()) 
                {
                    leser.Read();
                    ((TextBox)c).Text = leser[j].ToString();
                    j--;
                }
                leser.Close();
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
        private void GjemController() {
            /*
             * Denne metoden vil gjemme vekk alle
             * labels og textbokser ved å foreach alle 
             * Controls som er enten textboks eller label
             * til å bruke sin Hide() metode
             */
            foreach (var c in Controls) 
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
            /*
             * Denne metoden vil vise alle
             * labels og textbokser som er gjemt
             * ved å foreach alle Controls som er enten
             * textboks eller label til å bruke
             * sin Show() metode
             */
            foreach (var c in Controls)
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
            /*
             * Denne foreachen vil tømme alle tekstbokser for tekst
             */
            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }
    }
}
