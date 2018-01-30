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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (brukernavnText.Text == string.Empty || passordText.Text == string.Empty)
            {
                feilmelding.Text = "Brukernavn og passord må fylles ut!";
                feilmelding.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                try
                {
                    feilmelding.Text = "";
                    Database db = new Database();//Oppretter database-objekt
                    db.DBConnect();//Kjører DBConnect-metoden som ligger i Databaseklassen
                    String brukernavn = brukernavnText.Text;
                    String passord = passordText.Text;
                    if (db.Test(brukernavn, passord))//Sender brukernavn og passord til dummymetoden
                    {
                        VelkomstForm vf = new VelkomstForm();//Sender deg videre til velkomstskjermen ved gyldig pålogging
                    }
                    else
                    {
                        feilmelding.Text = "Brukeren eller passordet er feil!";
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
    }
}
