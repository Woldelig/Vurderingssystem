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
            if (Session["studentID"] == null)
            {
                Response.Redirect("velkomstside.aspx", true);
            }

            //Under får vi ut hvor mange rader med fag studenten har. Dette trenger vi for å lage et array             
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
            int antallRaderMedFag = leser.GetInt32(0);
            leser.Close();
            db.CloseConnection();

            //Her hentes all faginfo ut fra databasen
            sql = "SELECT fag.fagkode, fag.fagnavn, CONCAT(f.fornavn, ' ', f.etternavn) " +
                "FROM student as s, fag, foreleser as f " +
                "WHERE s.studentid = @Studentid " +
                "AND s.studieretning = fag.studieretning " +
                "AND f.foreleserid = fag.foreleserid";
            cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            db.OpenConnection();
            leser = cmd.ExecuteReader();
            String[,] faginfo = new String[antallRaderMedFag, 3];

            //Her legges database infoen inn i et Jagged array
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
             * * Arrayene blir laget utifra hvor mange rader som blir funnet i den første sql spørringen
            * hvis det ikke blir funnet noen rader har brukeren ikke utført en vurdering som blir sjekket i en if setning under
             */
            sql = "SELECT COUNT(*) FROM vurderingshistorikk WHERE studentid = @Studentid";
            cmd = db.SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Studentid", Session["studentID"].ToString());
            db.OpenConnection();
            leser = cmd.ExecuteReader();
            leser.Read();
            int antallRaderIVurderingshistorikk = leser.GetInt32(0);
            leser.Close();


            String[] fagkodeIVurderingshistorikk = null;
            if (antallRaderIVurderingshistorikk > 0)
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
                leser.Close();
            }
            db.CloseConnection();

            /*
            * Under sjekker vi om studenten har tatt en vurdering som er lagret i pågåendevurdering
            * vi sjekker dette så han ikke skal kunne ta en vurdering mer enn en gang
            * Arrayene blir laget utifra hvor mange rader som blir funnet i den første sql spørringen
            * hvis det ikke blir funnet noen rader har brukeren ikke utført en vurdering som blir sjekket i en if setning under
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

            if (antallRaderIpågåendevurdering > 0)
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
                leser.Close();
            }
            db.CloseConnection();

            /*
             * Under kopierer vi ut infoen om fagene som det allerede er tatt vurdering på og legger det inn i et annet array
             * vi må splitte opp informasjonen på denne måten for at kunne vise brukeren hvilke fag man kan ta en vurdering
             * Vi fyller også på arrayet med tomme verdier der hvor fagkoden ikke er lik. Dette er nødvendig siden vi bruker
             * en metode som heter Equals() senere for forgrenning logikk
             */
            String[,] faginfoForVurderteFag = null;
            if (antallRaderIpågåendevurdering + antallRaderIVurderingshistorikk > 0)
            {
                faginfoForVurderteFag = new String[antallRaderMedFag, 3];
                int totalIndexenTilFaginfoForVurdertefag = 0;
                for (int j = 0; j < antallRaderIpågåendevurdering; j++)
                {
                    for (int i = 0; i < antallRaderMedFag; i++)
                    {
                        if (faginfo[i, 0].Contains(fagkoderIPågåendevurdering[j]))
                        {
                            faginfoForVurderteFag[i, 0] = faginfo[i, 0];

                        }
                        else
                        {
                            faginfoForVurderteFag[i, 0] = "";
                        }
                    }
                    totalIndexenTilFaginfoForVurdertefag++;
                }
                for (int j = 0; j < antallRaderIVurderingshistorikk; j++)
                {
                    for (int i = totalIndexenTilFaginfoForVurdertefag; i < antallRaderMedFag; i++)
                    {
                        if (faginfo[i, 0].Contains(fagkodeIVurderingshistorikk[j]))
                        {
                            faginfoForVurderteFag[i, 0] = faginfo[i, 0];
                        }
                        else
                        {
                            faginfoForVurderteFag[i, 0] = "";
                        }
                    }
                    totalIndexenTilFaginfoForVurdertefag++;
                }
            }

            StringBuilder sb = new StringBuilder();
            int spanNr = 1;

            /*
             * Her blir det laget bokser hvor faginfo står. De boksene som brukeren ikke har tatt en vurdering i
             * vil være klikkebare og sende brukeren til et vurderingsskjema. Hvis brukeren har tatt en vurdering i faget
             * vil boksen være grå og ikke mulig å trykke på
             */
            for (int i = 0; i < antallRaderMedFag; i++)
            {
                String span1 = "FagkodeLbl" + spanNr;
                String span2 = "FagnavnLbl" + spanNr;
                String span3 = "ForeleserLbl" + spanNr;

                //Denne if setningen sjekker om et array er null, hvis dette spesifikke arrayet er null har brukeren ikke tatt noen vurderinger
                if (faginfoForVurderteFag == null)
                {
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
                }
                else if (!faginfo[i, 0].Equals(faginfoForVurderteFag[i, 0]))
                {
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

                }
                else
                {
                    sb.AppendFormat(
                        "<div class='Row'>" +
                            "<div class='col-md-4'>" +
                                "<div class='divBorder'>" +
                                        "<div>" +
                                            "<span ID='{0}' style='color:Black;font-weight:bold;'>{3}</span><br />" +
                                            "<span ID='{1}' style='color:Black'>{4}</span><br />" +
                                            "<span ID='{2}' style='color:Black'>{5}</span><br />" +
                                        "</div>" +
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
                }
                //lit er forkortelsen for Literal dette er en kontrollklasse vi skriver ut stringbuilderen sin tekst til
                lit.Text = sb.ToString();
            }
        }
    }
}