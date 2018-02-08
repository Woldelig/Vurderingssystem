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

        }

        private void lagSkjemaBtn_Click(object sender, EventArgs e)
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

                foreach (var c in Controls) //denne foreachen vil tømme alle textboksene i formen
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            Console.WriteLine(query);
            db.CloseConnection();

        }
    }
}
