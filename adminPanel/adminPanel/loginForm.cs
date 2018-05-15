using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace adminPanel
{
    public partial class LoginForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public LoginForm()
        {
            InitializeComponent();
            // Setter feilmeldingene på loginForm til rød
            HelpText.ForeColor = Color.Red;
            Username.Text = "Brukernavn";
            Password.Text = "Passord";
            Username.ForeColor = Color.FromArgb(52, 52, 52);
            Password.ForeColor = Color.FromArgb(52, 52, 52);
        }

        private void Login()
        {
            // Oppretter database-objekt
            Database db = new Database();
            try
            {
                db.OpenConnection();
                string query = "SELECT passord FROM formlogin WHERE bruker = @Brukernavn;";

                var mySqlCommand = db.SqlCommand(query);
                // Hindrer SQL-injection
                mySqlCommand.Parameters.AddWithValue("@Brukernavn", Username.Text);

                // Bruker ExecuteReader-metoden til å returnere resulatet til MySqlDataReader-objektet
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                // Sjekker om det finnes rader
                if (!reader.HasRows)
                {
                    HelpText.Text = "Brukernavnet eller passordet er feil!";
                } else
                {
                    Hasher hash = new Hasher();
                    string hashpw = "";
                    while (reader.Read())
                    {
                        hashpw = reader.GetString("passord");
                    }
                    // Sjekker om passordet er riktig
                    if (!hash.SjekkHash(Password.Text, hashpw))
                    {
                        HelpText.Text = "Feil passord!";
                    } else
                    {
                        UserInfo.Username = Username.Text;
                        DialogResult = DialogResult.OK;
                        this.Dispose();
                    }
                }
                // Stenger MySqlDataReader-objektet
                reader.Close();
                // Stenger databasetilgangen
                db.CloseConnection();
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // IF-setningen sjekker om både brukernavn og passord er fylt ut.
            if (Username.Text == "Brukernavn" || Password.Text == "Passord" || Username.Text == String.Empty || Password.Text == String.Empty)
            {
                HelpText.Text = "Brukernavn og passord må fylles ut!";
            }
            else
            {
                Login();
            }
        }

        private void ShutdownBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Placeholder - Cue banner
        private void Username_Enter(object sender, EventArgs e)
        {
            if(Username.Text == "Brukernavn")
            {
                Username.Text = "";
                Username.ForeColor = SystemColors.Window;
            }
        }

        // Placeholder - Cue banner
        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text.Length == 0)
            {
                Username.Text = "Brukernavn";
                Username.ForeColor = Color.FromArgb(52, 52, 52);
            }
        }

        // Placeholder - Cue banner
        private void Password_Enter(object sender, EventArgs e)
        {
            if(Password.Text == "Passord")
            {
                Password.Text = "";
                Password.ForeColor = SystemColors.Window;
                // Setter egenskapen til PasswordChar til å maskere passordet med '*'.
                Password.PasswordChar = '*';
            }
        }

        // Placeholder - Cue banner
        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text.Length == 0)
            {
                Password.Text = "Passord";
                Password.ForeColor = Color.FromArgb(52, 52, 52);
                // Skrur av maskering av passord for å kunne vise placeholder
                Password.PasswordChar = '\0';
            }
        }

        private void LoginBoarder_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            // Setter koordinatene til lastLocation i det brukeren holder museknappen nede.
            lastLocation = e.Location;
        }

        private void LoginBoarder_MouseMove(object sender, MouseEventArgs e)
        {
            // Så lenge museknappen er nede skal man kunne flytte på vinduet
            if (mouseDown)
            {
                // Kunne flytte på vinduet ved å klikke og dra i LoginBoarder
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                FormPosition.Pos = this.Location;
                this.Update();
            }
        }

        private void LoginBoarder_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Avslutter applikasjonen
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            // Minimerer vinduet
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginBtn_MouseEnter(object sender, EventArgs e)
        {
            LoginBtn.ForeColor = Color.SteelBlue;
        }

        private void LoginBtn_MouseLeave(object sender, EventArgs e)
        {
            LoginBtn.ForeColor = Color.Black;
        }

        private void ShutdownBtn_MouseEnter(object sender, EventArgs e)
        {
            ShutdownBtn.ForeColor = Color.SteelBlue;
        }

        private void ShutdownBtn_MouseLeave(object sender, EventArgs e)
        {
            ShutdownBtn.ForeColor = Color.Black;
        }

        private void NyBrukerBtn_MouseLeave(object sender, EventArgs e)
        {
            nyBrukerBtn.ForeColor = Color.SteelBlue;
        }

        private void NyBrukerBtn_MouseEnter(object sender, EventArgs e)
        {
            nyBrukerBtn.ForeColor = Color.FromArgb(37, 69, 95);
        }

        private void NyBrukerBtn_MouseDown(object sender, MouseEventArgs e)
        {
            nyBrukerBtn.ForeColor = Color.FromArgb(120, 163, 201);
        }

        private void NyBrukerBtn_MouseUp(object sender, MouseEventArgs e)
        {
            nyBrukerBtn.ForeColor = Color.SteelBlue;
        }

        // Bruker Multithreading
        private void NyBrukerBtn_Click(object sender, EventArgs e)
        {
            /*
             * Sjekker om det allerede finnes en nyBrukerForm,
             * hvis ikke starter vi en ny thread.
            */

            if (!SjekkForm())
            {
                new Multithread().StartThread();
            }
        }

        // En sjekker som går igjennom alle åpne form
        private bool SjekkForm()
        {
            // Går igjennom alle åpne forms
            foreach (Form form in Application.OpenForms)
            {
                // Hvis nyBrukerForm er en av disse betyr det at den er åpen
                if (typeof(NyBrukerForm).Name == form.Name)
                {
                    return true;
                }
            }
            // Returnerer false om den ikke finner formen
            return false;
        }

        // Kjører nyBrukerForm
        public void NyThread()
        {
            Application.Run(new NyBrukerForm());
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            Username.Text = UserInfo.Username;
        }
    }
}