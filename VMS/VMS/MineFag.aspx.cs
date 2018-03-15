using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VMS
{
    public partial class MineFag : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logginn"] == null || Session["studentID"] == null)
            {
                Response.Redirect("velkomstside.aspx", true);
            }
            Database db = new Database();

            String sql = "SELECT f.fagkode FROM student as s, fag as f WHERE s.studentid = @Studentid and s.studieretning = f.studieretning";
            var cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            List<String> studentendsFagkoder = new List<string>();
            db.OpenConnection();
            MySqlDataReader leser = cmd.ExecuteReader();
            /*while (leser.Read())
            {
                studentendsFagkoder.Add(Convert.ToString(leser[i]));
                i++;
            }
            Label1.Text = studentendsFagkoder[0]+ studentendsFagkoder[1];*/
            db.CloseConnection();
            


            /*
             TODO
             1. Hente ut fag
             2. Legge til fag i knapper
             3. Lage en session variabel som blir hentet når man trykker på knappen
             4. knappen videresender deg til fagsiden hvor vi henter ut den nye session variabelen og setter fagsiden til den fagkoden
             5. Legg knappene i to kolonner
             6. Design knappene store og pene muligens trykkbare paneler?

             */
        }
    }
}