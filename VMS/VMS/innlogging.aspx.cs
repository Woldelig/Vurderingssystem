using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VMS
{
    public partial class innlogging : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                StudentID.Text = "00000";
            }
            this.Master.loggutBtnShow = false;
        }
        
        protected void Login_Click(object sender, EventArgs e)
        {
            int parsedStudID;
            //Sjekker om StudentID inneholder tall
            if(!int.TryParse(StudentID.Text, out parsedStudID))
            {
                Feilmelding.ForeColor = System.Drawing.Color.Red;
                Feilmelding.Text = "Student-ID må inneholde tall!";
                return;
            }
            else
            {
                //Setter studentID inn i sessionvariabelen
                Session["studentID"] = parsedStudID;
                //Sender brukeren videre til velkomstsiden
                Response.Redirect("Default.aspx", true);
            }
        }
    }
}