using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VMS
{
    public partial class ForeleserSide : System.Web.UI.Page
    {
        private Database db = new Database();
        private String sidensForleserId = "666";

        /*
         * Setter en standard foreleserId så det alltid vil vises noe informasjon
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hvis noen blir redirected til forelesersiden med et parameter vil forelsersiden bytte om fagkoden til parameteret ved hjelp av en stringQuery
            String uformatertQueryString = Request.Url.Query;
            String formatertQueryString = uformatertQueryString.Replace("?", String.Empty);
            //StringQuery inneholder et spørsmålstegn som vi her fjerner

            if (formatertQueryString != "" || formatertQueryString == null)
            {
                sidensForleserId = formatertQueryString;
            }

            //Henter ut navn, fagkode, fagnavn, fakultet, studieretning
            String query = "SELECT CONCAT(f.fornavn, ' ', f.etternavn) as navn, fag.fagkode, fag.fagnavn, fag.studieretning, s.fakultet from foreleser as f, fag, studier as s WHERE f.foreleserid = @SidensForeleser AND fag.foreleserid = f.foreleserid AND fag.studieretning = s.studieretning";
            var cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@SidensForeleser", sidensForleserId);

            db.OpenConnection();

            using (MySqlDataReader leser = cmd.ExecuteReader())
            {
                if (!leser.HasRows)
                {
                    //Hvis sql feilet/ugyldig parameter til siden blir man sendt til default.aspx
                    Server.Transfer("Default.aspx");
                }
            }
        }
    }
}