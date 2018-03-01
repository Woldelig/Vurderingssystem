using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
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
            //Her får vi ut studieretning
            String query = "SELECT studieretning FROM student WHERE studentid=1"; //betingelsen må endres! den er satt til 1 kun for testing!!!!!!!!!!!!!
            var cmd = db.SqlCommand(query);
            db.OpenConnection();
            var result = cmd.ExecuteScalar(); //executescalar returner kun 1 rad.

            //Her får vi ut fagkode
            query = "SELECT fagkode FROM fag WHERE studieretning = '" + result + "'"; //Bruker ikke parameter overføring her siden injection er lite sannsynlig
            cmd = db.SqlCommand(query);
            var fagkode = cmd.ExecuteScalar(); //studentens fagkode blir lagt in i var fagkode

            //Her får vi ut skjemaets spørsmål og mater det inn i et array
            query = "SELECT spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10 FROM vurderingsskjema WHERE fagkode = '" + fagkode + "'";
            cmd = db.SqlCommand(query);
            MySqlDataReader leser = cmd.ExecuteReader();

            String[] skjemaSpm = new String[10];
            while(leser.Read())
            {
                for (int i = 0; i < 10; i++)
                {
                    skjemaSpm[i] = leser[i].ToString();

                }
            }
            db.CloseConnection();


            //Kun for å se hvilke verdier jeg får
            Label1.Text = skjemaSpm[0];
            Label2.Text = skjemaSpm[1];
            Label3.Text = skjemaSpm[2];
            Label4.Text = skjemaSpm[3];
            Label5.Text = skjemaSpm[4];
            Label6.Text = skjemaSpm[5];
            Label7.Text = skjemaSpm[6];
            Label8.Text = skjemaSpm[7];
            Label9.Text = skjemaSpm[8];
            Label10.Text = skjemaSpm[9];


            /*
             TODO
             1. Må vite hvem studenten er (Studentid)
             2. Må velge hvilket fag studenten vil ta vurdering i
             3. Må hente ut riktig skjema
                - Printe ut spm
                - Lage 5 radioknapper verdi 1-5 (muligens en annen type knapp kommer an på stjerne tingen)
            4. Send inn registrerte svar til databasen
             */
        }
    }
}