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
            String sql = "SELECT fag.fagkode, fag.fagnavn, CONCAT(f.fornavn, ' ', f.etternavn) FROM student as s, fag, foreleser as f WHERE s.studentid = @Studentid and s.studieretning = fag.studieretning and f.foreleserid = fag.foreleserid";
            var cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            List<String> sqlResultat = new List<string>();
            db.OpenConnection();
            MySqlDataReader leser = cmd.ExecuteReader();
            String[,] faginfo = new String[3, 3];
            leser.Read();
            for (int i = 0, j = 0, h = 1,k = 2; i < 1; i++, j += 3, h += 3, k += 3)
            {
                faginfo[i,0] = leser[j].ToString();
                faginfo[i,1] = leser[h].ToString();
                faginfo[i,2] = leser[k].ToString();
            }/*
            faginfo[0, 0] = leser[0].ToString();
            faginfo[0, 1] = leser[1].ToString();
            faginfo[0, 2] = leser[2].ToString();*/
            leser.Close();
                /* while (leser.Read())
                 {
                     for (int i = 0; i < leser.FieldCount; i++)
                     {
                         sqlResultat.Add(Convert.ToString(leser[i]));
                     }
                 }
                 Label1.Text = leser.FieldCount.ToString();
                 leser.Close();*/
                db.CloseConnection();
            //deler på 3 fordi et fag består av 3 verdier i denne sammenhengen
            int antallFag = sqlResultat.Count()/3;
            FagkodeLbl.Text = "Fagkode: " + faginfo[0,0];
            FagnavnLbl.Text = "Fagnavn: " + faginfo[0,1];
            ForleserLbl.Text = "Foreleser: " + faginfo[0,2];


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