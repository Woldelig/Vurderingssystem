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
            HtmlTable[] spmKnappDiv = new HtmlTable[10] { spm1RadioknappDiv, spm2RadioknappDiv, spm3RadioknappDiv, spm4RadioknappDiv, spm5RadioknappDiv, spm6RadioknappDiv, spm7RadioknappDiv, spm8RadioknappDiv, spm9RadioknappDiv, spm10RadioknappDiv };
            foreach (var div in spmKnappDiv)
            {
                LagRadioKnapper(div);
            }
            Label[] spmLabel = new Label[10] { spm1Lbl, spm2Lbl, spm3Lbl, spm4Lbl, spm5Lbl, spm6Lbl, spm7Lbl, spm8Lbl, spm9Lbl, spm10Lbl };
            int spmIndex = 0;
            foreach (Label lbl in spmLabel)
            {
                lbl.Text = skjemaSpm[spmIndex];
                spmIndex++;
            }

            /*
             TODO
             1. Må vite hvem studenten er (Studentid)
             2. Må velge hvilket fag studenten vil ta vurdering i
             3. Må hente ut riktig skjema
                - Printe ut spm
                - Lage 5 radioknapper verdi 1-5 (muligens en annen type knapp kommer an på stjerne tingen)
            4. Send inn registrerte svar til databasen
             */
            //MyPlaceholder.Controls.Add(new Literal() { Text = "<div class='col-md-4'>test</div> < div class='col-md-4'>test</div><div class='col-md-4'>test</div></div>" });
            //Kommer til å bruke literal class for å få ut skjema dynamisk, for den fungerer bedre enn innerhtml. 
            //i placeholder skal vi få ut spørreskjema. Skrive at vi prøvde div1.innerhtml i rapporten?
            //https://stackoverflow.com/questions/5508666/dynamically-add-html-to-asp-net-page

        }
        protected void SendInnSkjemaBtn_Click(object sender, EventArgs e)
        {
            
        }
        void LagRadioKnapper(HtmlTable radioKnappDiv)
        {

            HtmlTableRow row = new HtmlTableRow();
            for (int i = 0; i < 5; i++)
            {
                HtmlTableCell cell = new HtmlTableCell();
                RadioButton radioButton = new RadioButton();
                cell.Controls.Add(radioButton);
                row.Cells.Add(cell);
            }
            radioKnappDiv.Rows.Add(row);
        }

    }
}