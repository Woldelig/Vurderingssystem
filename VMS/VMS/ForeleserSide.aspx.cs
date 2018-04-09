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
    public partial class ForeleserSide : System.Web.UI.Page
    {
        private Database db = new Database();
        private String sidensForeleser = "SteveJobs";

        private List<ForeleserInfo> foreleserInfoListe = new List<ForeleserInfo>();
        /*
         * Setter en standard foreleserId så det alltid vil vises noe informasjon
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hvis noen blir redirected til forelesersiden med et parameter vil forelsersiden bytte om fagkoden til parameteret ved hjelp av en stringQuery
            String uformatertQueryString = Request.Url.Query;

            //Under blir ?, % og '20' fjernet fra strengen. De kommer fordi det var mellomrom i parameter som ble sendt med query stringen
            String formatertQueryString = uformatertQueryString.Replace("?", String.Empty).Replace("%", String.Empty).Replace("20", String.Empty);
            

            if (formatertQueryString != "" || formatertQueryString == null)
            {
                sidensForeleser = formatertQueryString;
            }

            //Henter ut navn, fagkode, fagnavn, fakultet, studieretning
            String query = "SELECT CONCAT(f.fornavn, ' ', f.etternavn) as navn, fag.fagkode, fag.fagnavn, fag.studieretning, s.fakultet from foreleser as f, fag, studier as s WHERE CONCAT(f.fornavn, f.etternavn) = @SidensForeleser AND fag.foreleserid = f.foreleserid AND fag.studieretning = s.studieretning";
            var cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@SidensForeleser", sidensForeleser);

            db.OpenConnection();
            String foreleserNavn = null;

            using (MySqlDataReader leser = cmd.ExecuteReader())
            {
                if (!leser.HasRows)
                {
                    //Hvis sql feilet/ugyldig parameter til siden blir man sendt til default.aspx
                    //Server.Transfer("Default.aspx");
                    Response.Write(sidensForeleser);
                }
                while (leser.Read())
                {
                    foreleserNavn = leser["navn"].ToString();

                    //Lager et foreleserinfoobjekt og legger det i en liste
                    foreleserInfoListe.Add(new ForeleserInfo()
                    {
                        Fagkode = leser["fagkode"].ToString(),
                        Fagnavn = leser["fagnavn"].ToString(),
                        Fakultet = leser["fakultet"].ToString(),
                        Studieretning = leser["studieretning"].ToString()
                    });
                }

            }
            db.CloseConnection();

            foreleserLbl.Text = "Foreleser: " + foreleserNavn;
            //Må ha et stringbuilder objekt, eller så vil innerHtml skrive over de tidligere loopene
            StringBuilder sb = new StringBuilder();

            foreach (var info in foreleserInfoListe)
            {
                sb.Append(
                    "<tr>" +
                        "<td><a href = 'fagside.aspx?" + info.Fagkode + "'>"+ info.Fagkode + "</a></td>" +
                        "<td><a href = 'fagside.aspx?" + info.Fagkode + "'>" + info.Fagnavn + "</a></td>" +
                        "<td>" + info.Studieretning + "</td>" +
                        "<td>" + info.Fakultet + "</td>" +
                    "</tr>");
            }
            tableBody.InnerHtml = sb.ToString();
        }


        private class ForeleserInfo
        {
            public String Fagkode { get; set; }
            public String Fagnavn { get; set; }
            public String Studieretning { get; set; }
            public String Fakultet { get; set; }
        }
    }
}