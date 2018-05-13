using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace adminPanel
{
    // Oppretter en egen form for å lage ny bruker.

    public partial class nyBrukerForm : Form
    {
        public nyBrukerForm()
        {
            InitializeComponent();
            Feilmelding.Hide();
            nyBrukerLogginn.Hide();
            opprettetLbl.Hide();
            
            // Plasserer formen oppå loginForm
            if (FormPosition.Pos == new Point(0,0))
            {
               this.StartPosition = FormStartPosition.CenterScreen;
            } else
            {
                this.Location = FormPosition.Pos;
            }
            
        }

        private void AvsluttBtn_Click(object sender, EventArgs e)
        {
            //Stopper threaden og nyBrukerForm
            new Multithread().StopThread();
            this.Dispose();
        }

        private void LagBrukerBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (Brukernavn.Text == "" || fornavn.Text == "" || etternavn.Text == "" || Passord.Text == "" || Passord2.Text == "")
            {
                // Setter rød farge på de boksene som ikke oppflyer kravene
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        //Sjekker om en eller flere tekstboker er tomme.
                        if (c.Text == "")
                        {
                            c.BackColor = Color.Red;
                            Feilmelding.Text = "Alle felt må fylles ut!";
                            Feilmelding.Show();
                        }
                    }
                }
            }
            // Sjekker om passordene er like
            else if (Passord.Text != Passord2.Text)
            {
                Feilmelding.Text = "Passordene må være like!";
                Feilmelding.Show();
                Passord2.BackColor = Color.Red;
            }
            else
            {
                try
                {
                    Feilmelding.Hide();
                    db.OpenConnection();
                    string query = "SELECT bruker FROM formlogin WHERE bruker = @Brukernavn;";
                    var mySqlCommand = db.SqlCommand(query);
                    mySqlCommand.Parameters.AddWithValue("@Brukernavn", Brukernavn.Text);
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();

                    // Sjekker om brukeren finnes i databasen fra før av.
                    if (reader.HasRows)
                    {
                        Feilmelding.Text = "Brukeren finnes allerede!";
                        Feilmelding.Show();
                        Brukernavn.BackColor = Color.Red;
                        db.CloseConnection();
                    }

                    // Hvis ikke skal dataen lagres og opprette en ny bruker.
                    else
                    {
                        // Objekt for hashing av passord.
                        Hasher hasher = new Hasher();

                        // Hasher passordet og lagrer det i en streng.
                        string hash = hasher.PassordHasher(Passord.Text);

                        db.OpenConnection();
                        query = "INSERT INTO formlogin (bruker, passord, fornavn, etternavn, brukertype) VALUES (@Brukernavn, @Passord, @Fornavn, @Etternavn, 2);";

                        var mySqlCommandInsert = db.SqlCommand(query);
                        
                        // Hinderer SQL-injection.
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
                        // Oppdaterer formen med å gjemme bort unødvendige labels og tekstbokser.
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
                        Feilmelding.Hide();

                        nyBrukerLogginn.Show();
                        opprettetLbl.Show();
                    }
                }
                catch (MySqlException DBException)
                {
                    /*
                     * Under testing og debugging av prototypen skriver vi til konsollen.
                     * Kan bytte til å skrive til feilmelding label når vi nærmer oss et produkt
                    */
                    Console.WriteLine(DBException.ToString());
                }
            }
        }

        private void nyBrukerLogginn_Click(object sender, EventArgs e)
        {
            UserInfo.Username = Brukernavn.Text;
            this.Dispose();
        }

        private void Passord_MouseDown(object sender, MouseEventArgs e)
        {
            Passord.BackColor = SystemColors.Window;
        }

        private void Passord2_MouseDown(object sender, MouseEventArgs e)
        {
            Passord2.BackColor = SystemColors.Window;
        }

        private void Brukernavn_MouseDown(object sender, MouseEventArgs e)
        {
            Brukernavn.BackColor = SystemColors.Window;
        }

        private void fornavn_MouseDown(object sender, MouseEventArgs e)
        {
            fornavn.BackColor = SystemColors.Window;
        }

        private void etternavn_MouseDown(object sender, MouseEventArgs e)
        {
            etternavn.BackColor = SystemColors.Window;
        }
    }
}