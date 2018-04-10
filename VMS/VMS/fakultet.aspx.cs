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
    public partial class fakultet : System.Web.UI.Page
    {
        private Database db = new Database();
        private String sidensFakultet = "Handelshøyskolen";
        private List<FakultetInfo> fakultetInfoListe = new List<FakultetInfo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Hvis noen blir redirected til forelesersiden med et parameter vil forelesersiden bytte om fagkoden til parameteret ved hjelp av en stringQuery
            String uformatertQueryString = Request.Url.Query;

            /*
             * Under fjernes ? fra tekststrengen %20 blir gjort om til mellomrom og %C3%B8 blir gjort om til ø.
             * + blir gjort om til mellomrom, dette er fordi hvis man går frem og tilbake mellom søkeresultater er at mellomrommet 
             * blir gjort om til + tegn i urlen
             */
            String formatertQueryString = uformatertQueryString.Replace("?", String.Empty).Replace("%20", " ").Replace("%C3%B8", "ø").Replace("+", " ");

            if (formatertQueryString != "" || formatertQueryString == null)
            {
                sidensFakultet = formatertQueryString;
            }

            String query = "SELECT s.fakultet, s.grad, s.studieretning, f.fagkode, f.fagnavn FROM studier as s, fag as f WHERE s.fakultet = @SidensFakultet AND f.studieretning = s.studieretning";
            var cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@SidensFakultet", sidensFakultet);

            db.OpenConnection();

            String fakultetNavn = null;
            using (MySqlDataReader leser = cmd.ExecuteReader())
            {
                if (!leser.HasRows)
                {
                    //Hvis sql feilet/ugyldig parameter til siden blir man sendt til default.aspx
                    Server.Transfer("Default.aspx");
                }
                while (leser.Read())
                {
                    fakultetNavn = leser["fakultet"].ToString();
                    fakultetInfoListe.Add(new FakultetInfo()
                    {
                        Fagkode = leser["fagkode"].ToString(),
                        Fagnavn = leser["fagnavn"].ToString(),
                        Studielinje = leser["studieretning"].ToString(),
                        Grad = leser["grad"].ToString()
                    });
                }
            }
            db.CloseConnection();

            fakultetLbl.Text = "Fakultet: " + fakultetNavn;

            StringBuilder sb = new StringBuilder();

            foreach (var info in fakultetInfoListe)
            {
                sb.Append(
                    "<tr>" +
                        "<td>" + info.Grad + "</td>" +
                        "<td><a href = 'linjeside.aspx?" + info.Studielinje + "'>" + info.Studielinje + "</a></td>"+
                        "<td><a href = 'fagside.aspx?" + info.Fagkode + "'>" + info.Fagnavn + "</a></td>" +
                        "<td><a href = 'fagside.aspx?" + info.Fagkode + "'>" + info.Fagkode + "</a></td>" +
                    "</tr>");
            }
            tableBody.InnerHtml = sb.ToString();
        }

        private class FakultetInfo
        {
            public String Fagnavn { get; set; }
            public String Fagkode { get; set; }
            public String Studielinje { get; set; }
            public String Grad { get; set; }
        }
    }
}