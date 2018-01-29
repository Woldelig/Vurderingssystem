using System;
using System.Collections.Generic;
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
            String connString = "server=localhost;user=root;database=vurderingssystem;";
            dbConn = new MySqlConnection(connString);
            try
            {
                dbConn.Open();
            }
            catch (MySqlException DBexception)
            {
                Console.WriteLine("Feilmelding: ", DBexception); //Viser foreløpig bare i debugging
                throw; //Her kan vi sette vår egen feilmelding
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
                throw; //Her kan vi sette vår egen feilmelding
            }
        }


    }
}
