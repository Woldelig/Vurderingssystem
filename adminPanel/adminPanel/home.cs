using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace adminPanel
{
    // Underside - Hjem
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Oppretter en databaseobjekt.
            Database db = new Database();

            /*
             * Henter ut tidsstempel fra databasen og setter den inn i LasLogin-panelet
             * slik at brukeren kan se sist innlogging.
            */
            try
            {
                
                db.OpenConnection();

                String sql = "SELECT tidsstempel FROM innloggingshistorikk WHERE bruker = @Brukernavn;";
                var mySqlCommand = db.SqlCommand(sql);
                mySqlCommand.Parameters.AddWithValue("@Brukernavn", UserInfo.Username);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                // Sjekker om det finnes rader i databasen.
                if (reader.HasRows)
                {
                    // Henter ut tidsstempelet og legger det inn i tekstboksen LastLogin
                    while (reader.Read())
                    {
                        LastLogin.Text = reader.GetString("tidsstempel");
                    }
                }
                else
                {
                    Console.WriteLine("Fant ingen brukere");
                }
                reader.Close();
                db.CloseConnection();
            }
            catch (MySqlException DBexception)
            {
                /*
                 * Skriver til konsollvinduet nå under prototypetesting.
                */
                Console.WriteLine("Feilmelding: ", DBexception);
            }
            

            /*
             * Henter ut brukertype og navnet på brukeren som logget inn for så å
             * vise det i hjempanelet.
            */
            try
            {
                db.OpenConnection();
                String sql = "SELECT brukertype, fornavn, etternavn FROM formlogin WHERE bruker = @Brukernavn;";
                var mySqlCommand = db.SqlCommand(sql);
                mySqlCommand.Parameters.AddWithValue("@Brukernavn", UserInfo.Username);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                // Sjekker om det finnes rader i databasen
                if (reader.HasRows)
                {
                    // Henter ut data fra databasen
                    while (reader.Read())
                    {
                        // Hvis brukertypen er satt til 1 betyr det at vi har en admin.
                        if (reader.GetString("brukertype") == "1")
                        {
                            UsertypeLbl.Text = "Admin";
                            NameLbl.Text = reader.GetString("fornavn") + " " + reader.GetString("etternavn");
                        }
                        // Hvis ikke har vi en vanlig bruker.
                        else
                        {
                            UsertypeLbl.Text = "Bruker";
                            NameLbl.Text = reader.GetString("fornavn") + " " + reader.GetString("etternavn");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Fant ingen rader");
                }
                reader.Close();
                db.CloseConnection();
            }
            catch (MySqlException DBexception)
            {
                Console.WriteLine("Feilmelding: ", DBexception);
            }
        }
    }
}
