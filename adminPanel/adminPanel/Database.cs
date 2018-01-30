using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace adminPanel
{
    class Database
    {
        MySqlConnection dbConn;

        public void DBConnect()//Metoden er satt til public, mulig vi kan sette den til private. Kalle vil da se slikt ut: Database.DBOppkobling()
        {
            String connString = "server=localhost;user=root;database=vurderingssystem;";//OBS OBS! HUSK Å ENDRE DATABSEN!
            dbConn = new MySqlConnection(connString);
            try
            {
                dbConn.Open();
            }
            catch (MySqlException DBexception)
            {
                Console.WriteLine("Feilmelding: ", DBexception); //Viser foreløpig bare i debugging
            }
         }

        public void DBClose()
        {
            try
            {
                dbConn.Close();
            }
            catch (MySqlException DBexception)
            {
                Console.WriteLine("Feilmelding: ", DBexception); //Viser foreløpig bare i debugging
            }
        }

        public bool Test(String username, String password) // Tester om DBConnect og DBClose funker med en SELECT-spørring
        {
            try
            {
                String sql = "SELECT * FROM formlogin WHERE bruker = @Brukernavn AND passord = @Passord;"; //har får vi ut 3 verdier brukernavn, passord og brukertype. Brukertype er INT
                MySqlCommand cmd = new MySqlCommand(sql, dbConn); //Bruker MySqlCommand-objektet til å utføre databaseoperasjoner

                cmd.Parameters.AddWithValue("@Brukernavn", username);//Hindrer SQLinjection
                cmd.Parameters.AddWithValue("@Passord", password);
                MySqlDataReader reader = cmd.ExecuteReader(); //Bruker ExecuteReader-metoden til å returnere resulatet til MySqlDataReader-objektet
                if (reader.HasRows) //Sjekker om det finnes rader
                {
                    while (reader.Read())//Så lenge det er rader igjen så printer vi ut innholdet
                    {
                        Console.WriteLine(reader.GetString("bruker"));//Skriver ut brukernavnet
                        Console.WriteLine(reader.GetString("passord"));//Skriver ut passordet
                        Console.WriteLine(reader.GetString("brukertype"));//Skriver ut brukertypen

                    }
                    reader.Close();//Stenger MySqlDataReader-objektet
                    return true;//Brukeren finnes
                }
                else
                {
                    Console.WriteLine("Fant ingen rader");
                    reader.Close();//Stenger MySqlDataReader-objektet
                    return false;//Brukeren finnes ikke
                }
            }
            catch (MySqlException DBexception)
            {
                Console.WriteLine("Feilmelding: ", DBexception);
            }
        }

    }
}
