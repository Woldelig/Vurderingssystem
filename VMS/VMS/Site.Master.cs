using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;


namespace VMS
{
    public partial class SiteMaster : MasterPage
    {
        private class Faginfo
        {
            /*
             * Denne klassen brukes for å holde styr på hvilke fagkoder som tilhører hvilke forelesere og fagnavn.
             * Vi bruker en liste for dette så vi slipper å sende flere spørringer mot databasen
             */
            public String Fagkode { get; set; }
            public String Fagnavn { get; set; }
            public String ForeleserNavn { get; set; }

        }

        private List<Faginfo> faginfoListe = new List<Faginfo>();
        private List<String> søkeResultatListe = new List<String>();
        private List<String> søkeResultatlisteUtenDuplikat;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Hvis man ikke er logget inn blir knapper skjult
            if (Session["studentID"] == null)
            {
                minefag.Style["visibility"] = "hidden";
                minevurderinger.Style["visibility"] = "hidden";
                loggutBtn.Style["visibility"] = "hidden";
            }
            else
            {
                LoggInnNavbarBtn.Style["visibility"] = "hidden";
            }

            Database db = new Database();
            String query = "SELECT fag.fagkode, fag.fagnavn, CONCAT(foreleser.fornavn, ' ', foreleser.etternavn) as navn FROM fag, foreleser WHERE foreleser.foreleserid = fag.foreleserid";
            var cmd = db.SqlCommand(query);
            db.OpenConnection();
            using (MySqlDataReader leser = cmd.ExecuteReader())
            {
                /*
                 * Siden DataReader objektet kun kan leses en gang må det mellomlagres i string x,y,z
                 * Dette er fordi vi trenger 2 typer lister. En liste som inneholder alt uten rekkefølge som
                 * skal brukes i autocomplete funksjonen. Og en egendefinert liste klasse som vi trenger struktur på
                 */
                String x, y, z;
                while (leser.Read())
                {
                    x = leser["fagkode"].ToString();
                    y = leser["fagnavn"].ToString();
                    z = leser["navn"].ToString();

                    faginfoListe.Add(new Faginfo() { Fagkode = x, Fagnavn = y, ForeleserNavn = z });

                    søkeResultatListe.Add(x);
                    søkeResultatListe.Add(z);
                    søkeResultatListe.Add(y);
                }
            }
            db.CloseConnection();

            //Må lage en ny liste uten duplikater. Ellers vil foreleser med flere fag kommer flere ganger i søkefeltet
            søkeResultatlisteUtenDuplikat = søkeResultatListe.Distinct().ToList();


            /*
             * Clienscriptmanager gjør at vi kan lage et script server side,
             * dette gjør det enkelt å bruke variabler på kryss av C# og js.
             * RegisterStartupScript gjør at scriptet vil bli startet mens siden blir åpnet
             */
            ClientScriptManager cs = Page.ClientScript;
            StringBuilder sb = new StringBuilder();
            sb.Append("<script>");
            sb.Append("$(function () {");
            sb.Append("var availableTags = new Array;");
            foreach (String resultat in søkeResultatlisteUtenDuplikat)
            {
                sb.Append("availableTags.push('" + resultat + "');");
            }
            sb.Append("$('#SearchTxt').autocomplete({ source: availableTags });});");
            sb.Append("</script>");
            cs.RegisterStartupScript(this.GetType(), "AutoCompleteArrayScript", sb.ToString());
        }

        public Boolean loggutBtnShow
        {
            get
            {
                return loggutBtn.Visible = true;
            }
            set
            {
                loggutBtn.Visible = value;
            }
        }

        protected void loggutBtn_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("velkomstside.aspx", true);
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            /*
             * Under bruker vi Lambda får å finne ut om søkestrengen til brukeren
             * finnes i vår list<t>. Hvis den finnes blir den lagt inn i et faginfo objekt(resultat)
             * og i dette objektet kan vi hente ut fagkoden (selv om brukeren søker på forelesernavn/fagnavn
             * Brukeren blir deretter sendt til fagsiden med fagkoden til faget han søkte på
             */
            String søkestreng = SearchTxt.Text;
            Faginfo resultat = faginfoListe.Find(x => x.Fagkode == søkestreng || x.Fagnavn == søkestreng || x.ForeleserNavn == søkestreng);
            if (String.IsNullOrWhiteSpace(SearchTxt.Text))
            {
                return;
            }
            else if (resultat != null)
            {
                String fagkode = resultat.Fagkode;
                String url = "fagside.aspx?" + fagkode;
                Response.Redirect(url, true);
            }
        }
    }
}