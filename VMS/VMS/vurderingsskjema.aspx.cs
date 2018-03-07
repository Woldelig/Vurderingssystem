using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace VMS
{
    public partial class vurderingsskjema : System.Web.UI.Page
    {
        //Denne siden skal ikke være tilgjengelig med mindre du er student med gyldig session
        //session må gi oss en studentid, med den kan vi få tak i studieretning og fagkode som gir
        //oss tilgangen til skjemaene.
        Database db = new Database();

        protected void Page_Load(object sender, EventArgs e)
        {
            String query = "SELECT spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10 FROM student as s, fag as f, vurderingsskjema as v WHERE s.studentid = @Studentid AND s.studieretning = f.studieretning AND v.fagkode = f.fagkode";
            //betingelsen må endres! den er satt til 1 kun for testing!!!!!!!!!!!!!
            //Denne setningen får tak i spørsmålene ved hjelp av betingelser på kryss av tabeller
            var cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            db.OpenConnection();
            MySqlDataReader leser = cmd.ExecuteReader();

            String[] skjemaSpm = new String[10];
            while (leser.Read())
            {
                for (int i = 0; i < 10; i++)
                {
                    skjemaSpm[i] = leser[i].ToString();
                }
            }
            db.CloseConnection();
            Label[] spmLabel = new Label[10] { spm1Lbl, spm2Lbl, spm3Lbl, spm4Lbl, spm5Lbl, spm6Lbl, spm7Lbl, spm8Lbl, spm9Lbl, spm10Lbl };
            int spmIndex = 0;
            foreach (Label lbl in spmLabel)
            {
                lbl.Text = skjemaSpm[spmIndex];
                spmIndex++;
            }
        }
        protected void SendInnSkjemaBtn_Click(object sender, EventArgs e)
        {
            int spm1 = Int32.Parse(spm1rating.Value);
            int spm2 = Int32.Parse(spm2rating.Value);
            int spm3 = Int32.Parse(spm3rating.Value);
            int spm4 = Int32.Parse(spm4rating.Value);
            int spm5 = Int32.Parse(spm5rating.Value);
            int spm6 = Int32.Parse(spm6rating.Value);
            int spm7 = Int32.Parse(spm7rating.Value);
            int spm8 = Int32.Parse(spm8rating.Value);
            int spm9 = Int32.Parse(spm9rating.Value);
            int spm10 = Int32.Parse(spm10rating.Value);
            
            int[] ratingArray = new int[10] { spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10 };
            foreach (var rating in ratingArray)
            {
                if (rating.Equals(0))
                {
                    feilmeldingLbl.Text = "Du må fylle ut hele skjemaet";
                }
                else
                {
                    String skjemaid = "";
                    String fagkode = "";
                    String sql = "SELECT skjemaid, f.fagkode FROM student as s, fag as f, vurderingsskjema as v WHERE s.studentid = @Studentid AND s.studieretning = f.studieretning AND v.fagkode = f.fagkode";
                    var cmd = db.SqlCommand(sql);
                    cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
                    db.OpenConnection();
                    MySqlDataReader leser = cmd.ExecuteReader();
                    while (leser.Read())
                    {
                        fagkode = leser[0].ToString();
                        skjemaid = leser[1].ToString();
                    }
                    db.CloseConnection();
                    

                    
                    sql = "INSERT INTO vurderingshistorikk VALUES (@Skjemaid, @Studentid, @Fagkode, @Spm1rating, @Spm2rating, @Spm3rating, @Spm4rating, @Spm5rating, @Spm6rating, @Spm7rating, @Spm8rating, @Spm9rating, @Spm10rating);";
                    cmd = db.SqlCommand(sql);
                    cmd.Parameters.AddWithValue("@Skjemaid", skjemaid);
                    cmd.Parameters.AddWithValue("@Fagkode", fagkode);
                    cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
                    cmd.Parameters.AddWithValue("@Spm1rating", spm1);
                    cmd.Parameters.AddWithValue("@Spm2rating", spm2);
                    cmd.Parameters.AddWithValue("@Spm3rating", spm3);
                    cmd.Parameters.AddWithValue("@Spm4rating", spm4);
                    cmd.Parameters.AddWithValue("@Spm5rating", spm5);
                    cmd.Parameters.AddWithValue("@Spm6rating", spm6);
                    cmd.Parameters.AddWithValue("@Spm7rating", spm7);
                    cmd.Parameters.AddWithValue("@Spm8rating", spm8);
                    cmd.Parameters.AddWithValue("@Spm9rating", spm9);
                    cmd.Parameters.AddWithValue("@Spm10rating", spm10);
                    db.OpenConnection();
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();

                }
            }
        }
    }
}