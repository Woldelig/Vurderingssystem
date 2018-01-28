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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (brukernavnText.Text == string.Empty || passordText.Text == string.Empty)
            {
                feilmelding.Text = "Brukernavn og passord må fylles ut";
            }
            else
            {


                String connString = "server=localhost;user=root;database=test;"; //databasen på min pc heter test, bytt ettersom hva deres heter. Evt finner vi nytt navn
                MySqlConnection conn = new MySqlConnection(connString);         //OBS OBS denne skal egentlig være egen klasse!

                try
                {
                    conn.Open();
                    String sql = "SELECT * FROM formlogin WHERE brukernavn = @Brukernavn AND passord = @Passord;"; //har får vi ut 3 verdier brukernavn, passord og brukertype. Brukertype er INT
                    MySqlCommand cb = new MySqlCommand(sql, conn);
                    MySqlDataReader dbdr = cb.ExecuteReader();

                    String brukernavn = brukernavnText.Text;
                    String passord = passordText.Text;

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
