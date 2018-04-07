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
        List<String> fagkoder = new List<string>();
        

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
                while (leser.Read())
                {
                    fagkoder.Add(leser["fagkode"].ToString());
                    fagkoder.Add(leser["fagnavn"].ToString());
                    fagkoder.Add(leser["navn"].ToString());
                }
            }
            db.CloseConnection();

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
            foreach (String fagkode in fagkoder)
            {
                sb.Append("availableTags.push('" + fagkode + "');");
            }
            sb.Append("$('#SearchTxt').autocomplete({ source: availableTags});});");
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
            if (String.IsNullOrWhiteSpace(SearchTxt.Text))
            {
                return;
            }
            else if (fagkoder.Contains(SearchTxt.Text))
            {
                String url = "fagside.aspx?"+SearchTxt.Text;
                Response.Redirect(url, true);
            }
        }
    }
}