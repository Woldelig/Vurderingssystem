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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            
            String connString = "server=localhost;user=root;database=vurderingssystem;";
            MySqlConnection dbConn = new MySqlConnection(connString);

            //Henter ut tidsstempel fra databasen og setter den inn i LasLogin-panelet
            //slik at brukeren kan se sist innlogging
            try
            {
                dbConn.Open();
                String sql = "SELECT tidsstempel FROM innloggingshistorikk WHERE bruker = @Brukernavn;";
                MySqlCommand cmd = new MySqlCommand(sql, dbConn);
                cmd.Parameters.AddWithValue("@Brukernavn", UserInfo.Username);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        LastLogin.Text = reader.GetString("tidsstempel");
                        Console.WriteLine(reader.GetString("tidsstempel"));
                    }
                }
                else
                {
                    Console.WriteLine("Fant ingen brukere");
                }
            }
            catch (MySqlException DBexception)
            {
                Console.WriteLine("Feilmelding: ", DBexception);
            }
            dbConn.Close();

            //Henter ut brukertype og navnet på brukeren som logget inn for så å
            //vise det i hjempanelet.
            try
            {
                dbConn.Open();
                String sql = "SELECT brukertype FROM formlogin WHERE bruker = @Brukernavn;";
                MySqlCommand cmd = new MySqlCommand(sql, dbConn);
                cmd.Parameters.AddWithValue("@Brukernavn", UserInfo.Username);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if(reader.GetString("brukertype") == "1")
                        {
                            UsertypeLbl.Text = "Admin";
                            NameLbl.Text = UserInfo.Username;
                        }
                        else
                        {
                            UsertypeLbl.Text = "Bruker";
                            NameLbl.Text = UserInfo.Username;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Fant ingen rader");
                }
            }
            catch (MySqlException DBexception)
            {
                Console.WriteLine("Feilmelding: ", DBexception);
            }
            dbConn.Close();
        }
    }
}
