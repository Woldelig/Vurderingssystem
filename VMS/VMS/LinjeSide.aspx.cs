using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VMS
{
    public partial class LinjeSide : System.Web.UI.Page
    {
        private Database db = new Database();
        private String sidensStudielinje = "Dataingeniør";
        private List<StudieInfo> studieInfoListe = new List<StudieInfo>();


        protected void Page_Load(object sender, EventArgs e)
        {
            //Hvis noen blir redirected til forelesersiden med et parameter vil forelsersiden bytte om fagkoden til parameteret ved hjelp av en stringQuery
            String uformatertQueryString = Request.Url.Query;

            /*
             * Under fjernes ? fra tekststrengen %20 blir gjort om til mellomrom og %C3%B8 blir gjort om til ø.
             * + blir gjort om til mellomrom, dette er fordi hvis man går frem og tilbake mellomsøke resultater er at mellomrommet 
             * blir gjort om til + tegn
             */
            String formatertQueryString = uformatertQueryString.Replace("?", String.Empty).Replace("%20", " ").Replace("%C3%B8", "ø").Replace("+", " ");
            
            if (formatertQueryString != "" || formatertQueryString == null)
            {
                sidensStudielinje = formatertQueryString;
            }

            String query = "SELECT f.studieretning, f.fagnavn, f.fagkode, s.fakultet FROM fag as f, studier as s WHERE f.studieretning = @SidensStudielinje AND f.studieretning = s.studieretning";
            var cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@SidensStudielinje", sidensStudielinje);

            db.OpenConnection();
            String studieNavn = null;

            using (MySqlDataReader leser = cmd.ExecuteReader())
            {
                if (!leser.HasRows)
                {
                    //Hvis sql feilet/ugyldig parameter til siden blir man sendt til default.aspx
                    Server.Transfer("Default.aspx");
                }
                while (leser.Read())
                {
                    studieNavn = leser["studieretning"].ToString();
                    studieInfoListe.Add(new StudieInfo()
                    {
                        Fagnavn = leser["fagnavn"].ToString(),
                        Fagkode = leser["fagkode"].ToString(),
                        Fakultet = leser["fakultet"].ToString()
                    });
                }
            }
            db.CloseConnection();


            studielinjeLbl.Text = studieNavn;
            StringBuilder sb = new StringBuilder();

            foreach (var info in studieInfoListe)
            {
                sb.Append(
                    "<tr>" +
                        "<td><a href = 'fagside.aspx?" + info.Fagkode + "'>" + info.Fagnavn + "</a></td>" +
                        "<td><a href = 'fagside.aspx?" + info.Fagkode + "'>" + info.Fagkode + "</a></td>" +
                        "<td>" + info.Fakultet + "</td>" +
                    "</tr>");
            }
            tableBody.InnerHtml = sb.ToString();

        }

        private class StudieInfo
        {
            public String Fagnavn { get; set; }
            public String Fagkode { get; set; }
            public String Fakultet { get; set; }
        }
    }
}