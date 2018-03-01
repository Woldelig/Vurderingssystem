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
            String query = "SELECT studieretning FROM student WHERE studentid=1"; //betingelsen må endres! den er satt til 1 kun for testing!!!!!!!!!!!!!
            var cmd = db.SqlCommand(query);
            db.OpenConnection();
            var result = cmd.ExecuteScalar(); //executescalar returner kun 1 rad.
            query = "SELECT fagkode FROM fag WHERE studieretning = '" + result + "'"; //Bruker ikke parameter overføring her siden injection er lite sannsynlig
            cmd = db.SqlCommand(query);
            var fagkode = cmd.ExecuteScalar(); //studentens fagkode blir lagt in i var fagkode
            Label1.Text = fagkode.ToString();
            db.CloseConnection();

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