using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VMS
{
    public partial class velkomstside : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //Jallaløsning - men vi skal jo ikke ha modal uansett
            //Prøver å få programmet til å trykke på logg-innknappen av seg selv
            //Sliter med javascript
            if (Page.IsPostBack)
            {
                string s = "<script> document.getElementById(\"LoginBtn\").click();</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", s);
            }


            Session["logginn"] = 0;
            this.Master.loggutBtnShow = false;
        }


        protected void Logginn_Click(object sender, EventArgs e)
        {
            int parsedStudID;
            //Sjekker om StudentID inneholder tall
            if (!int.TryParse(StudentID.Text, out parsedStudID))
            {
                Feilmelding.ForeColor = System.Drawing.Color.Red;
                Feilmelding.Text = "Student-ID må inneholde tall!";
                
                return;
            }
            else
            {
                //Setter innlogging til 1
                Session["logginn"] = 1;
                //Setter studentID inn i sessionvariabelen
                Session["studentID"] = parsedStudID;
                //Sender brukeren videre til velkomstsiden
                Response.Redirect("Default.aspx", true);
            }
        }

        protected void continue_Click(object sender, EventArgs e)
        {
            Session["logginn"] = 0;
            Session["studentID"] = "Ukjent";
            Response.Redirect("Default.aspx", true);
        }
    }
}