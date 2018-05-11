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
            if (Session["studentID"] == null)
            {
                Response.Redirect("velkomstside.aspx", true);
            }

            /*
             * Her starter vi må å kjøre en SQL spørring med COUNT.
             * Vi trenger denne tellingen for å instansiere vårt
             * multidimensjonelle array. Dette arrayet kommer til å 
             * tilsvare en tabell. Vi bruker array istedenfor DataTable,
             * dette er fordi vi kommer til å utføre en del operasjoner på arrayet
             * som hadde vært veldig vanskelig på DataTable og array er generelt raskere
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

            
            sql = "SELECT fag.fagkode, fag.fagnavn, CONCAT(f.fornavn, ' ', f.etternavn) FROM student as s, fag, foreleser as f WHERE s.studentid = @Studentid and s.studieretning = fag.studieretning and f.foreleserid = fag.foreleserid";
            cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            db.OpenConnection();
            leser = cmd.ExecuteReader();
            String[,] faginfo = new String[antallRader, 3];
            /* Her lages et jagged array, første parameter representerer rader og andre parameter representerer kolonner
             * siden vi er usikre på hvor mange rader vi skal ha blir dette definert ved hjelp av en egen spørring som teller
             * resultatet. Kolonner er definert som 3 fordi det er kun 3 kolonner vi bruker. Vi selecter egentlig 4 kolonner
             * men vi bruker concat-funksjonen i mysql for å slå sammen fornavn og etternavnet til foreleseren.
             */

            //Her leses verdiene inn i et jagged array
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

            //Vi bruker stringbuilder til å bygge vår html
            StringBuilder sb = new StringBuilder();
            int spanNr = 1;
            
            //I denne for løkken blir det laget rader med klikkbare bokser som inneholder fagkode, fagnavn og foreleser navn
            for (int i = 0; i < antallRader; i++)
            {
                String span1 = "FagkodeLbl" + spanNr;
                String span2 = "FagnavnLbl" + spanNr;
                String span3 = "ForeleserLbl" + spanNr;

                sb.AppendFormat(
                    "<div class='Row'>" +
                        "<div class='col-md-4'>" +
                            "<div class='divKnappBorder'>" +
                                "<a href='fagside.aspx?{6}' style='text-decoration: none'>" +
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
                    , span1, span2, span3, "Fagkode: " + faginfo[i, 0], "Fagnavn: " + faginfo[i, 1], "Foreleser: " + faginfo[i, 2], faginfo[i,0]);
                //span1-3 angir span navn, de får et høyere nr per loop. [i,0] er fagkode for første rad [i,1] er fagnavn og [i,2] er foreleser navn

                /*
                 * testsomething.InnerHtml = sb.ToString();
                 * PlaceHolder1.Controls.Add(new Literal() { Text = sb.ToString() });
                 * 
                 * De to linjene ovenfor er to andre tilnærminger vi forsøkte å bruke. Begge fungerer, men vi
                 * valgte og bruke Literal. I html koden ville linjene ovenfor kunne ha skrevet ut til disse:
                 * <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                 * <div id="testsomething" runat="server"></div>
                 */

                //lit er forkortelsen for literal kontroll vi skriver ut stringbuilderen sin tekst til
                lit.Text = sb.ToString();
            }
        }
    }
}
