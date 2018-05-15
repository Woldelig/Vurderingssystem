using System;
using System.Web.UI;

namespace VMS
{
    public partial class Innlogging : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Setter en placeholder for studentID
            if (!Page.IsPostBack)
            {
                StudentID.Text = "00000";
            }
            this.Master.LoggutBtnShow = false;
        }
        
        protected void Login_Click(object sender, EventArgs e)
        {
            int parsedStudID;
            // Sjekker om StudentID inneholder tall
            if(!int.TryParse(StudentID.Text, out parsedStudID))
            {
                // Feilmelding i modal
                Feilmelding.ForeColor = System.Drawing.Color.Red;
                Feilmelding.Text = "Student-ID må inneholde tall!";
                return;
            }
            else
            {
                // Setter studentID inn i sessionvariabelen
                Session["studentID"] = parsedStudID;
                // Sender brukeren videre til velkomstsiden
                Response.Redirect("Default.aspx", true);
            }
        }
    }
}