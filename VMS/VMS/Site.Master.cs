using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace VMS
{
    public partial class SiteMaster : MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            String query = "SELECT fagkode FROM fag";
            var cmd = db.SqlCommand(query);
            List<String> fagkoder = new List<string>();
            db.OpenConnection();
            using (MySqlDataReader leser = cmd.ExecuteReader())
            {
                while (leser.Read())
                {
                    fagkoder.Add(leser["fagkode"].ToString());
                }
            }
            db.CloseConnection();

            //String [] FagkoderArray = fagkoder.ToArray();
            //Label1.Text = FagkoderArray[0];


            ClientScriptManager cs = Page.ClientScript;
            StringBuilder sb = new StringBuilder();
            sb.Append("<script>");
            sb.Append("$(function () {");
            sb.Append("var availableTags = new Array;");
            foreach (String fagkode in fagkoder)
            {
                sb.Append("availableTags.push('" + fagkode + "');");
            }
            sb.Append("$('#SearchTxt').autocomplete({ source: availableTags });});");
            sb.Append("</script>");

            cs.RegisterStartupScript(this.GetType(), "AutoCompleteArrayScript", sb.ToString());



            try
            {
                if (!SjekkInnlogging())
                {
                    minefag.Visible = false;
                    minevurderinger.Visible = false;
                    loggutBtn.Text = "Logg inn";

                }

            }
            catch (Exception)
            {

            }
        }
        private Boolean SjekkInnlogging()
        {
            if((int)Session["logginn"] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string loggutBtnText
        {
            get
            {
                return loggutBtn.Text;
            }
            set
            {
                loggutBtn.Text = value;
            }
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
            if (loggutBtn.Text == "Logg ut")
            {
                Session["logginn"] = 0;
                Response.Redirect("velkomstside.aspx", true);
            } else if(loggutBtn.Text == "Logg inn")
            {
                Response.Redirect("velkomstside.aspx", true);
            }
        }
    }
}