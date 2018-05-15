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
            public String Studieretning { get; set; }
            public String Fakultet { get; set; }
        }

        private List<Faginfo> faginfoListe = new List<Faginfo>();
        private List<String> søkeResultatListe = new List<String>();
        private List<String> søkeResultatlisteUtenDuplikat;

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Her sjekkes det om en bruker er innlogget.
             * hvis en bruker ikke er innlogget, vil noen knapper på
             * navbaren skjules siden disse er til brukerfunksjoner
             */

            if (Session["studentID"] == null)
            {
                minefag.Style["visibility"] = "hidden";
                minevurderinger.Style["visibility"] = "hidden";
                LoggutBtn.Style["visibility"] = "hidden";
            }
            else
            {
                LoggInnNavbarBtn.Style["visibility"] = "hidden";
            }

            Database db = new Database();
            String query = "SELECT s.studieretning, s.fakultet, fag.fagkode, fag.fagnavn, CONCAT(f.fornavn, ' ', f.etternavn) as navn FROM fag, foreleser as f, studier as s WHERE f.foreleserid = fag.foreleserid AND fag.studieretning = s.studieretning";
            var cmd = db.SqlCommand(query);
            db.OpenConnection();

            /*
            * Using passer på at objektet som blir definert inne i 
            * parantesene i blir "destroyed" eller tatt hånd om av 
            * garbage collector så fort krøllparantesene tar slutt
            * 
            * Innenfor while løkken legger vi inn informasjonen som er
            * hentet ut fra databasen i Faginfo objekter som legges
            * i en liste.
            */

            using (MySqlDataReader leser = cmd.ExecuteReader())
            {
                /*
                 * Siden DataReader objektet kun kan leses en gang må det mellomlagres i string a,b,c,d,f.
                 * e blir ikke brukt som variabel da dette er standard variabel for Events.
                 * 
                 * De leses inn til egne variabler fordi en leser kan kun lese en verdi engang, og vi trenger
                 * veridene til 2 lister. En liste som inneholder alt uten rekkefølge som skal brukes i autocomplete funksjonen.
                 * Og en liste som inneholder objekter med all informasjon som det kan søkes om.
                 */

                String a, b, c, d, f;
                while (leser.Read())
                {
                    a = leser["fagkode"].ToString();
                    b = leser["fagnavn"].ToString();
                    c = leser["navn"].ToString();
                    d = leser["studieretning"].ToString();
                    f = leser["fakultet"].ToString();

                    faginfoListe.Add(new Faginfo() { Fagkode = a, Fagnavn = b, ForeleserNavn = c, Studieretning = d, Fakultet = f });

                    søkeResultatListe.Add(a);
                    søkeResultatListe.Add(b);
                    søkeResultatListe.Add(c);
                    søkeResultatListe.Add(d);
                    søkeResultatListe.Add(f);
                }
            }
            db.CloseConnection();

            //Her blir duplikater fjernet. Dette gjør vi så vi slipper å få opp duplikater i søkeforslag
            søkeResultatlisteUtenDuplikat = søkeResultatListe.Distinct().ToList();


            /*
             * Clienscriptmanager gjør at vi kan lage et script server side,
             * dette gjør det enkelt å bruke variabler på kryss av C# og js.
             * RegisterStartupScript gjør at scriptet vil bli startet når siden blir åpnet
             */

            ClientScriptManager cs = Page.ClientScript;
            StringBuilder sb = new StringBuilder();
            sb.Append("<script>");
            sb.Append("$(function () {");
            sb.Append("var søkeArray = new Array;");
            foreach (String resultat in søkeResultatlisteUtenDuplikat)
            {
                sb.Append("søkeArray.push('" + resultat + "');");
            }
            sb.Append("$('#SearchTxt').autocomplete({ source: søkeArray });});");
            sb.Append("</script>");
            cs.RegisterStartupScript(this.GetType(), "AutoCompleteArrayScript", sb.ToString());
        }

        public Boolean LoggutBtnShow
        {
            get
            {
                return LoggutBtn.Visible = true;
            }
            set
            {
                LoggutBtn.Visible = value;
            }
        }

        protected void LoggutBtn_Click(object sender, EventArgs e)
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

            //fagkode og fagnavn leder til samme side, derfor den godtar enten fagkode eller fagnavn
            Faginfo fagkodeResultat = faginfoListe.Find(x => x.Fagkode == søkestreng || x.Fagnavn == søkestreng);
            Faginfo foreleserResultat = faginfoListe.Find(x => x.ForeleserNavn == søkestreng);
            Faginfo studieResultat = faginfoListe.Find(x => x.Studieretning == søkestreng);
            Faginfo fakultetResultat = faginfoListe.Find(x => x.Fakultet == søkestreng);

            if (String.IsNullOrWhiteSpace(SearchTxt.Text))
            {
                return;
            }
            else if (fagkodeResultat != null)
            {
                String fagkode = fagkodeResultat.Fagkode;
                String url = "fagside.aspx?" + fagkode;
                Response.Redirect(url, true);
            }
            else if (foreleserResultat != null)
            {
                String foreleser = foreleserResultat.ForeleserNavn;
                String url = "foreleserside.aspx?" + foreleser;
                Response.Redirect(url, true);
            }
            else if (studieResultat != null)
            {
                String studieretning = studieResultat.Studieretning;
                String url = "linjeside.aspx?" + studieretning;
                Response.Redirect(url, true);
            }
            else if (fakultetResultat != null)
            {
                String fakultet = fakultetResultat.Fakultet;
                String url = "fakultet.aspx?" + fakultet;
                Response.Redirect(url, true);
            }
        }
    }
}