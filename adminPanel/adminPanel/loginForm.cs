using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Username.Text == string.Empty || Password.Text == "Passord")
            {
                HelpText.Text = "Brukernavn og passord må fylles ut!";
            }
            else
            {
                try
                {
                    Database db = new Database();//Oppretter database-objekt
                    db.DBConnect();//Kjører DBConnect-metoden som ligger i Databaseklassen
                    String brukernavn = Username.Text;
                    String passord = Password.Text;
                    if (db.Login(brukernavn, passord))//Sender brukernavn og passord til dummymetoden
                    {
                        UserInfo.Username = brukernavn;
                        this.Dispose();//Stenger loginForm /avslutter når innloggin er vellykket
                        DialogResult = DialogResult.OK;//Setter innlogging status til 'OK'
                    }
                    else
                    {
                        HelpText.Text = "Brukernavnet eller passordet er feil!";
                    }
                    db.DBClose();//Stenger databasetilgangen
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    //Under testing og debugging skriver vi til konsollen.
                    //Kan bytte til å skrive til feilmelding label når vi nærmer oss et produkt
                }
            }
        }

        private void ShutdownBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Watermark
        private void Username_Enter(object sender, EventArgs e)
        {
            if(Username.Text == "Brukernavn")
            {
                Username.Text = "";
                Username.ForeColor = SystemColors.Window;
            }
        }

        //Watermark
        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text.Length == 0)
            {
                Username.Text = "Brukernavn";
                Username.ForeColor = Color.FromArgb(52, 52, 52);
            }
        }

        //Watermark
        private void Password_Enter(object sender, EventArgs e)
        {
            if(Password.Text == "Passord")
            {
                Password.Text = "";
                Password.ForeColor = SystemColors.Window;
                Password.PasswordChar = '*';//Setter egenskapen til PasswordChar til å maskere passordet med *
            }
        }

        //Watermark
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
            lastLocation = e.Location;
        }

        private void LoginBoarder_MouseMove(object sender, MouseEventArgs e)
        {
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
    }
}