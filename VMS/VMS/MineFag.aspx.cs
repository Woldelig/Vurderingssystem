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
            Database db = new Database();
            String sql = "SELECT fag.fagkode, fag.fagnavn, CONCAT(f.fornavn, ' ', f.etternavn) FROM student as s, fag, foreleser as f WHERE s.studentid = @Studentid and s.studieretning = fag.studieretning and f.foreleserid = fag.foreleserid";
            var cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            List<String> sqlResultat = new List<string>();
            db.OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataReader leser = cmd.ExecuteReader();
            MySqlDataReader leserForÅTelleRader = leser;
            //dt.Load(leserForÅTelleRader);
            String[,] faginfo = new String[10, 3];

            int arrayIndexTilsvarerRadIdb = 0;
            while (leser.Read())
            {
                faginfo[arrayIndexTilsvarerRadIdb, 0] = leser.GetString(0);
                faginfo[arrayIndexTilsvarerRadIdb, 1] = leser.GetString(1);
                faginfo[arrayIndexTilsvarerRadIdb, 2] = leser.GetString(2);
                arrayIndexTilsvarerRadIdb++;
            }
            Label1.Text = "Verdi: " + faginfo[1, 0];
            Label2.Text = "Verdi: " + faginfo[1, 1];
            Label3.Text = "Verdi: " + faginfo[1, 2];
            StringBuilder sb = new StringBuilder();
            int lblNr = 1;
            //foreach (DataRow rad in dt.Rows)
            //{

                String lbl1 = "FagkodeLbl" + lblNr;
                String lbl2 = "FagnavnLbl" + lblNr;
                String lbl3 = "ForeleserLbl" + lblNr;

                sb.AppendFormat("" +
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
                            "</ div >" +
                        "</ div >" +
                    "</ div >", lbl1, lbl2, lbl3, "Fagkode: " + faginfo[1, 0], "Fagnavn: " + faginfo[1, 1], "Foreleser: " + faginfo[1, 2]);
                testsomething.InnerHtml = sb.ToString();
           // }

            leser.Close();

            db.CloseConnection();
            //deler på 3 fordi et fag består av 3 verdier i denne sammenhengen
            int antallFag = sqlResultat.Count() / 3;
            FagkodeLbl.Text = "Fagkode: " + faginfo[0, 0];
            FagnavnLbl.Text = "Fagnavn: " + faginfo[0, 1];
            ForeleserLbl.Text = "Foreleser: " + faginfo[0, 2];

            //testsomething.InnerHtml = "<a href='fagside.aspx' style='text-decoration: none'><div><asp:Label ID='FagkodeLbl1' runat='server' Text='Label' ForeColor='Black' Font-Bold='true'></asp:Label><br /><asp:Label ID='FagnavnLbl1' runat='server' Text='Label' ForeColor='Black'></asp:Label><br /><asp:Label ID='ForleserLbl1' runat='server' Text='Label' ForeColor='Black'></asp:Label><br /></div> </a>";










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