using System;
using System.Web.UI.WebControls;

namespace VMS
{
    public partial class Velkomstside : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Master.loggutBtnShow = false;
            // Gjør logginnknappen usynlig på logginnsiden så vi ikke får dobbelt med logginnknapper
            ((Button)this.Master.FindControl("LoggInnNavbarBtn")).Visible = false;
        }

        // Simulere studentinnlogging
        protected void Logginn_Click(object sender, EventArgs e)
        {

            // Sjekker om StudentID inneholder tall
            if (!int.TryParse(StudentID.Text, out int parsedStudID))
            {
                Feilmelding.ForeColor = System.Drawing.Color.Red;
                Feilmelding.Text = "Student-ID må inneholde tall!";
                
                return;
            }
            else
            {
                // Setter studentID inn i sessionvariabelen
                Session["studentID"] = parsedStudID;
                // Sender brukeren videre til hovedsiden
                Response.Redirect("Default.aspx", true);
            }
        }

        /*
         * Sender brukeren videre til hovesiden uten å være innlogget.
         * Brukeren vil da miste muligheten til å benytte visse funksjoner.
        */
        protected void continue_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", true);
        }
    }
}