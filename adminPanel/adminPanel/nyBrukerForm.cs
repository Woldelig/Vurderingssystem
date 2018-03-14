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
        }

        private void AvsluttBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LagBrukerBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            try
            {
                db.OpenConnection();
                string query = "SELECT bruker FROM formlogin WHERE bruker = @Brukernavn;";
                var mySqlCommand = db.SqlCommand(query);
                mySqlCommand.Parameters.AddWithValue("@Brukernavn", Brukernavn.Text);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    NyBrukerFeilmelding.Show();
                } else
                {
                    //Jobbe videre her!
                    //Huske å legge inn det hasha passordet og saltet
                    // i databasen, det må også skrives en sjekker
                    Hasher hasher = new Hasher();
                   string hash = hasher.PassordHasher(Passord.Text);
                    Console.WriteLine("test: " + hash);
                }
            }
            catch (MySqlException DBException)
            {
                Console.WriteLine(DBException.ToString());
                //Under testing og debugging skriver vi til konsollen.
                //Kan bytte til å skrive til feilmelding label når vi nærmer oss et produkt
            }
        }
            /*Database db = new Database();//Oppretter database-objekt
            try
            {

                db.OpenConnection();
                string query = "SELECT * FROM formlogin WHERE bruker = @Brukernavn;";

                var mySqlCommand = db.SqlCommand(query);

                mySqlCommand.Parameters.AddWithValue("@Brukernavn", Username.Text);//Hindrer SQLinjection

                MySqlDataReader reader = mySqlCommand.ExecuteReader(); //Bruker ExecuteReader-metoden til å returnere resulatet til MySqlDataReader-objektet
                if (reader.HasRows) //Sjekker om det finnes rader
                {
                    while (reader.Read())//Så lenge det er rader igjen så printer vi ut innholdet
                    {
                        Console.WriteLine(reader.GetString("bruker"));//Skriver ut brukernavnet
                        Console.WriteLine(reader.GetString("passord"));//Skriver ut passordet
                        Console.WriteLine(reader.GetString("brukertype"));//Skriver ut brukertypen
                    }*/
    }
}
