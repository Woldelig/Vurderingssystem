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

        private MySqlConnection mySqlConnection;

        //Lokale konstanter som blir brukt så lenge overload ikke blir brukt
        //under deklarering av nytt objekt.
        private const string Server = "localhost";
        private const string UserID = "root";
        private const string DatabaseName = "vurderingssystem";
        private const string Password = "";
        
        //Dette er en konstruktør med en overload slik at vi kan gjøre det mulig
        //å koble til flere ulike databaser ved deklarering av databaseobjektet
        public Database(string server, string userID, string password, string database)
        {
            //DBConnection returnerer MySqlConnection-objektet som caster connectionString og
            //setter det over i det lokale objektet(mySqlConnection)
            mySqlConnection = DBConnection(server, userID, password, database);
        }

        //Dette er konstruktøren for klassen og bruker de lokale konstantene
        public Database() : this(Server, UserID, Password, DatabaseName)
        {

        }
        
        //Metoden oppretter et MySqlConnection-objekt med databaseinfoen for oppkobling
        private MySqlConnection DBConnection(string server, string userID, string password, string database)
        {
            //Bruker String.Format som gjør koden "renere", letter å lese og vedlikeholde
            var connectionString = String.Format("server={0};user={1};password={2};database={3}", server, userID, password, database);
            return new MySqlConnection(connectionString);
        }

        //Metoden bygger et MySqlCommand-objekt tilkoblingen og en spørring.
        //Spørringen er et argument i metoden som gjør det mulig å bruke metoden
        //i andre klasser. Metoden returnerer "Spørringsobjektet" slik at det kan brukes
        //der den ble kalt på.
        public MySqlCommand SqlCommand(string query)
        {
            var mySqlCommand = new MySqlCommand(query, mySqlConnection);
            return mySqlCommand;
        }

        public MySqlDataAdapter DataAdapter(String query)
        {
            var dataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            return dataAdapter;
        }
        

        //Metoden åpner tilkoblingen til databasen
        public void OpenConnection()
        {
            mySqlConnection.Close();
            try
            {
                mySqlConnection.Open();
            }
            catch (MySqlException mySqlException)
            {
                Console.WriteLine("Feilmelding: Kunne ikke koble til databasen!", mySqlException);   
            }
        }

        //Metoden steger tilkoblingen til databasen
        public void CloseConnection()
        {
            mySqlConnection.Close();
        }
    }
}