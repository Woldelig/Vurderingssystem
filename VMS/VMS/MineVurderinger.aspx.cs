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
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logginn"] == null || Session["studentID"] == null)
            {
                Response.Redirect("velkomstside.aspx", true);
            }
            
            Database db = new Database();
            String sql = "SELECT COUNT(*) FROM student as s, fag, foreleser as f " +
                "WHERE s.studentid = @Studentid " +
                "AND s.studieretning = fag.studieretning " +
                "AND f.foreleserid = fag.foreleserid";
            var cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            db.OpenConnection();
            MySqlDataReader leser = cmd.ExecuteReader();
            leser.Read();
            int antallRader = leser.GetInt32(0);
            leser.Close();
            db.CloseConnection();


            sql = "SELECT fag.fagkode, fag.fagnavn, CONCAT(f.fornavn, ' ', f.etternavn) " +
                "FROM student as s, fag, foreleser as f " +
                "WHERE s.studentid = @Studentid " +
                "AND s.studieretning = fag.studieretning " +
                "AND f.foreleserid = fag.foreleserid";
            cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
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


            /*
             * Under sjekker vi om studenten har tatt en vurdering som er lagret i vurderingshistorikk
             * vi sjekker dette så han ikke skal kunne ta en vurdering mer enn en gang
             */
            sql = "SELECT COUNT(fagkode), fagkode FROM vurderingshistorikk WHERE studentid = @Studentid GROUP BY fagkode";
            cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            db.OpenConnection();
            leser = cmd.ExecuteReader();
            leser.Read();
            int antallRaderIVurderingshistorikk = leser.GetInt32(0);
            leser.Close();
            String[] fagkodeIVurderingshistorikk = null;
            if (antallRaderIVurderingshistorikk != 0)
            {
                sql = "SELECT fagkode FROM vurderingshistorikk WHERE studentid = @Studentid";
                cmd = db.SqlCommand(sql);
                cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
                leser = cmd.ExecuteReader();
                fagkodeIVurderingshistorikk = new String[antallRaderIVurderingshistorikk];
                int i = 0;
                while (leser.Read())
                {
                    fagkodeIVurderingshistorikk[i] = leser.GetString(0);
                    i++;
                }
            }
            db.CloseConnection();

            /*
            * Under sjekker vi om studenten har tatt en vurdering som er lagret i pågåendevurdering
            * vi sjekker dette så han ikke skal kunne ta en vurdering mer enn en gang
            */
            sql = "SELECT COUNT(*)FROM pågåendevurdering WHERE studentid = @Studentid";
            cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            db.OpenConnection();
            leser = cmd.ExecuteReader();
            leser.Read();
            int antallRaderIpågåendevurdering = leser.GetInt32(0);
            leser.Close();
            String[] fagkoderIPågåendevurdering = null;
            if (antallRaderIpågåendevurdering != 0)
            {
                sql = "SELECT fagkode FROM pågåendevurdering WHERE studentid = @Studentid";
                cmd = db.SqlCommand(sql);
                cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
                leser = cmd.ExecuteReader();
                fagkoderIPågåendevurdering = new String[antallRaderIpågåendevurdering];
                int i = 0;
                while (leser.Read())
                {
                    fagkoderIPågåendevurdering[i] = leser.GetString(0);
                    i++;
                }
            }
            db.CloseConnection();

            Label1.Text = fagkodeIVurderingshistorikk + antallRaderIVurderingshistorikk.ToString();
            Label2.Text = fagkoderIPågåendevurdering[0] + fagkoderIPågåendevurdering[1] + fagkoderIPågåendevurdering[2];


            StringBuilder sb = new StringBuilder();
            int spanNr = 1;

            //I denne for loopen blir det laget rader med klikkbare bokser som inneholder fagkode, fagnavn og foreleser navn
            for (int i = 0; i < antallRader; i++)
            {
                String span1 = "FagkodeLbl" + spanNr;
                String span2 = "FagnavnLbl" + spanNr;
                String span3 = "ForeleserLbl" + spanNr;

                sb.AppendFormat(
                    "<div class='Row'>" +
                        "<div class='col-md-4'>" +
                            "<div class='divKnappBorder'>" +
                                "<a href='Vurderingsskjema.aspx?{6}' style='text-decoration: none'>" +
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
                    , span1, span2, span3, "Fagkode: " + faginfo[i, 0], "Fagnavn: " + faginfo[i, 1], "Foreleser: " + faginfo[i, 2], faginfo[i, 0]);
                //span1-3 angir span navn, de får et høyere nr per loop. [i,0] er fagkode for første rad [i,1] er fagnavn og [i,2] er foreleser navn
                

                //lit er forkortelsen for literal kontroll vi skriver ut stringbuilderen sin tekst til
                lit.Text = sb.ToString();
            }
        }
    }
}