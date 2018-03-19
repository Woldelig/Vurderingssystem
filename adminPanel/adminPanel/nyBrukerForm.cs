using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminPanel
{
    public partial class nyBrukerForm : Form
    {
        public nyBrukerForm()
        {
            InitializeComponent();
            NyBrukerFeilmelding.Hide();
            nyBrukerLogginn.Hide();
            opprettetLbl.Hide();
            FeltFeilmeldingLbl.Hide();
            passordFeilmeldingLbl.Hide();
        }

        private void AvsluttBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LagBrukerBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (Brukernavn.Text == "" || fornavn.Text == "" || etternavn.Text == "" || Passord.Text == "" || Passord2.Text == "")
            {
                FeltFeilmeldingLbl.Show();
            }
            else if (Passord.Text != Passord2.Text)
            {
                passordFeilmeldingLbl.Show();
            }
            else
            {
                try
                {
                    FeltFeilmeldingLbl.Hide();
                    passordFeilmeldingLbl.Hide();
                    db.OpenConnection();
                    string query = "SELECT bruker FROM formlogin WHERE bruker = @Brukernavn;";
                    var mySqlCommand = db.SqlCommand(query);
                    mySqlCommand.Parameters.AddWithValue("@Brukernavn", Brukernavn.Text);
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        NyBrukerFeilmelding.Show();
                        db.CloseConnection();
                    }
                    else
                    {
                        Hasher hasher = new Hasher();
                        string hash = hasher.PassordHasher(Passord.Text);

                        db.OpenConnection();
                        query = "INSERT INTO formlogin (bruker, passord, fornavn, etternavn, brukertype) VALUES (@Brukernavn, @Passord, @Fornavn, @Etternavn, 2);";

                        var mySqlCommandInsert = db.SqlCommand(query);

                        mySqlCommandInsert.Parameters.AddWithValue("@Brukernavn", Brukernavn.Text);
                        mySqlCommandInsert.Parameters.AddWithValue("@Passord", hash);
                        mySqlCommandInsert.Parameters.AddWithValue("@Fornavn", fornavn.Text);
                        mySqlCommandInsert.Parameters.AddWithValue("@Etternavn", etternavn.Text);

                        int resultat = mySqlCommandInsert.ExecuteNonQuery();
                        if (resultat < 0)
                        {
                            Console.WriteLine("Noe gikk galt! Kunne ikke legge til data i databasen!");
                        }
                        db.CloseConnection();
                    }
                }
                catch (MySqlException DBException)
                {
                    Console.WriteLine(DBException.ToString());
                    //Under testing og debugging skriver vi til konsollen.
                    //Kan bytte til å skrive til feilmelding label når vi nærmer oss et produkt
                }
                nyBrukerLbl.Hide();
                BrukernavnLbl.Hide();
                Brukernavn.Hide();
                fornavn.Hide();
                fornavnLbl.Hide();
                etternavn.Hide();
                etternavnLbl.Hide();
                nyttPassordLbl.Hide();
                Passord.Hide();
                nyttPassordLbl2.Hide();
                Passord2.Hide();
                LagBrukerBtn.Hide();
                AvsluttBtn.Hide();
                NyBrukerFeilmelding.Hide();

                nyBrukerLogginn.Show();
                opprettetLbl.Show();
            }
        }

        private void nyBrukerLogginn_Click(object sender, EventArgs e)
        {
            UserInfo.Username = Brukernavn.Text;
            this.Dispose();
        }
    }
}
