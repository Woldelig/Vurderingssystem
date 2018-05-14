using System;
using System.Web.UI.WebControls;

namespace VMS
{
    public partial class Velkomstside : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Master.LoggutBtnShow = false;
            //Gjør logginn knappen usynlig på logginn siden så vi ikke for dobbelt med logg inn knapper
            ((Button)this.Master.FindControl("LoggInnNavbarBtn")).Visible = false;
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
                //Setter studentID inn i sessionvariabelen
                Session["studentID"] = parsedStudID;
                //Sender brukeren videre til velkomstsiden
                Response.Redirect("Default.aspx", true);
            }
        }

        protected void continue_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", true);
        }
    }
}