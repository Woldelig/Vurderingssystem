using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
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
            HelpText.ForeColor = System.Drawing.Color.Red; // Setter feilmeldingene på loginForm til rød
            Username.Text = "Brukernavn";
            Password.Text = "Passord";
            Username.ForeColor = Color.FromArgb(52, 52, 52);
            Password.ForeColor = Color.FromArgb(52, 52, 52);
        }

        private void Login()
        {
            Database db = new Database();//Oppretter database-objekt
            try
            {
                db.OpenConnection();
                string query = "SELECT passord FROM formlogin WHERE bruker = @Brukernavn;";

                var mySqlCommand = db.SqlCommand(query);

                mySqlCommand.Parameters.AddWithValue("@Brukernavn", Username.Text);//Hindrer SQLinjection
                
                MySqlDataReader reader = mySqlCommand.ExecuteReader(); //Bruker ExecuteReader-metoden til å returnere resulatet til MySqlDataReader-objektet
                if (!reader.HasRows) //Sjekker om det finnes rader
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
                    //Sjekker om passordet er riktig
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
                reader.Close();//Stenger MySqlDataReader-objektet
                db.CloseConnection();//Stenger databasetilgangen
            }
            catch (MySqlException DBException)
            {
                Console.WriteLine(DBException.ToString());
                //Under testing og debugging skriver vi til konsollen.
                //Kan bytte til å skrive til feilmelding label når vi nærmer oss et produkt
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //IF-setningen ser har litt ekstra i scopet nå fordi watermark er lagt til. Mulig vi finner en bedre løsning på det
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

        //Watermark - Cue banner
        private void Username_Enter(object sender, EventArgs e)
        {
            if(Username.Text == "Brukernavn")
            {
                Username.Text = "";
                Username.ForeColor = SystemColors.Window;
            }
        }

        //Watermark - Cue banner
        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text.Length == 0)
            {
                Username.Text = "Brukernavn";
                Username.ForeColor = Color.FromArgb(52, 52, 52);
            }
        }

        //Watermark - Cue banner
        private void Password_Enter(object sender, EventArgs e)
        {
            if(Password.Text == "Passord")
            {
                Password.Text = "";
                Password.ForeColor = SystemColors.Window;
                Password.PasswordChar = '*';//Setter egenskapen til PasswordChar til å maskere passordet med *
            }
        }

        //Watermark - Cue banner
        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text.Length == 0)
            {
                Password.Text = "Passord";
                Password.ForeColor = Color.FromArgb(52, 52, 52);
                Password.PasswordChar = '\0';//Skrur av maskering av passord for å kunne vise watermark
            }
        }

        private void LoginBoarder_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location; //Setter koordinatene til lastLocation i det brukeren holder museknappen nede
        }

        private void LoginBoarder_MouseMove(object sender, MouseEventArgs e)
        {
            //Så lenge museknappen er nede skal man kunne flytte på vinduet
            if (mouseDown)
            {
                //Kunne flytte på vinduet ved å klikke og dra i LoginBoarder
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void LoginBoarder_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();//Avslutter applikasjonen
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//Minimerer vinduet
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

        private void nyBrukerBtn_MouseLeave(object sender, EventArgs e)
        {
            nyBrukerBtn.ForeColor = Color.SteelBlue;
        }

        private void nyBrukerBtn_MouseEnter(object sender, EventArgs e)
        {
            nyBrukerBtn.ForeColor = Color.FromArgb(37, 69, 95);
        }

        private void nyBrukerBtn_MouseDown(object sender, MouseEventArgs e)
        {
            nyBrukerBtn.ForeColor = Color.FromArgb(120, 163, 201);
        }

        private void nyBrukerBtn_MouseUp(object sender, MouseEventArgs e)
        {
            nyBrukerBtn.ForeColor = Color.SteelBlue;
        }

        //Bruker Multithreading
        private void nyBrukerBtn_Click(object sender, EventArgs e)
        {
            ThreadStart nyBrukerThread = new ThreadStart(new LoginForm().nyThread);
            Thread thread = new Thread(nyBrukerThread);
            thread.Start();
        }
        public void nyThread()
        {
            Application.Run(new nyBrukerForm());
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            Username.Text = UserInfo.Username;
        }
    }
}