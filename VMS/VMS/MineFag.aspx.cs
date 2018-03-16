using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
            /*
             * Vi må kjøre to spørringer her. Vi må vite antall rader som kommer ut for å lage arrayet
             * Problemet er blitt stilt før på stack uten løsninger. Og klone datareader objektet er jo en mulighet
             * men da er det mye mer hensiktmessig og kun kjøre en ekstra spørring
                https://stackoverflow.com/questions/37726983/clone-sqldatareader-to-get-number-of-rows
             */

            Database db = new Database();
            String sql = "SELECT COUNT(*) FROM student as s, fag, foreleser as f WHERE s.studentid = @Studentid and s.studieretning = fag.studieretning and f.foreleserid = fag.foreleserid";
            var cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            db.OpenConnection();
            MySqlDataReader leser = cmd.ExecuteReader();
            leser.Read();
            int antallRader = leser.GetInt32(0);
            leser.Close();
            db.CloseConnection();
            Label1.Text = antallRader.ToString();
            sql = "SELECT fag.fagkode, fag.fagnavn, CONCAT(f.fornavn, ' ', f.etternavn) FROM student as s, fag, foreleser as f WHERE s.studentid = @Studentid and s.studieretning = fag.studieretning and f.foreleserid = fag.foreleserid";
            cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            List<String> sqlResultat = new List<string>();
            db.OpenConnection();
            leser = cmd.ExecuteReader();
            String[,] faginfo = new String[antallRader, 3];

            int arrayIndexTilsvarerRadIdb = 0;
            while (leser.Read())
            {
                faginfo[arrayIndexTilsvarerRadIdb, 0] = leser.GetString(0);
                faginfo[arrayIndexTilsvarerRadIdb, 1] = leser.GetString(1);
                faginfo[arrayIndexTilsvarerRadIdb, 2] = leser.GetString(2);
                arrayIndexTilsvarerRadIdb++;
            }
            leser.Close();
            db.CloseConnection();
            StringBuilder sb = new StringBuilder();
            int lblNr = 1;


            for (int i = 0; i < antallRader; i++)
            {
                String lbl1 = "FagkodeLbl" + lblNr;
                String lbl2 = "FagnavnLbl" + lblNr;
                String lbl3 = "ForeleserLbl" + lblNr;

                sb.AppendFormat(
                    "<div class='Row'>" +
                        "<div class='col-md-4'>" +
                            "<div class='divKnappBorder'>" +
                                "<a href='fagside.aspx' style='text-decoration: none'>" +
                                    "<div>" +
                                        "<span ID='{0}' style='color:Black;font-weight:bold;'>{3}</span><br />" +
                                        "<span ID='{1}' style='color:Black'>{4}</span><br />" +
                                        "<span ID='{2}' style='color:Black'>{5}</span><br />" +
                                    "</div>" +
                                "</a>" +
                            "</div >" +
                        "</div >" +
                    "</div >" +
                    "<br />" +
                    "<br />" +
                    "<br />" +
                    "<br />" +
                    "<br />"
                    , lbl1, lbl2, lbl3, "Fagkode: " + faginfo[i, 0], "Fagnavn: " + faginfo[i, 1], "Foreleser: " + faginfo[i, 2], i);

                //testsomething.InnerHtml = sb.ToString();
                //PlaceHolder1.Controls.Add(new Literal() { Text = sb.ToString() });
                //Ovenfor er to andre metoder vi kunne ha brukt

                //lit er forkortelsen for literal kontroll vi skriver ut stringbuilderen sin tekst til
                lit.Text = sb.ToString();
            }



            //FagkodeLbl.Text = "Fagkode: " + faginfo[0, 0];
            //FagnavnLbl.Text = "Fagnavn: " + faginfo[0, 1];
            //ForeleserLbl.Text = "Foreleser: " + faginfo[0, 2];

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