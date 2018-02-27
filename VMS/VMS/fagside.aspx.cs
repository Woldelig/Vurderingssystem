using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace VMS
{
    public partial class Fagside : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String sidensFagkode = "OBJ2100";
            /*
             * Denne variabelen skal bestemme hva fagsiden handler om. Planen er at man kun skal trenge å 
             * bytte ut denne variabelen så vil all info byttes ut dynamisk
             */

            Database db = new Database();
            int foreleserId; //Denne trenger vi for å få informasjon om foreleser

            String fagkodeQuery = "SELECT * FROM fag WHERE fagkode = @SidensFagkode";
            var cmd1 = db.SqlCommand(fagkodeQuery);
            cmd1.Parameters.AddWithValue("@SidensFagkode", sidensFagkode);

            db.OpenConnection();
            MySqlDataReader leser = cmd1.ExecuteReader();
            leser.Read();
            foreleserId = (int)leser[2]; //her henter vi ut foreleser id, så vi får hentet ut all info om personen senere
            fagkodeLbl.Text = "Fagkode: " + leser[0].ToString();
            fagnavnLbl.Text = "Fagnavn: " + leser[1].ToString();
            studieretningLbl.Text = "Studieretning: " + leser[3].ToString();
            leser.Close();
            db.CloseConnection();

            String foreleserQuery = "SELECT fornavn, etternavn FROM foreleser WHERE foreleserid = @ForeleserId";
            var cmd2 = db.SqlCommand(foreleserQuery);
            cmd2.Parameters.AddWithValue("@ForeleserId", foreleserId);

            db.OpenConnection();
            leser = cmd2.ExecuteReader();
            leser.Read();
            String foreleserNavn = leser[0].ToString() + " " + leser[1].ToString();
            leser.Close();
            db.CloseConnection();
            foreleserLbl.Text = "Foreleser: " + foreleserNavn;
        }
    }
}