using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VMS
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logginn"] == null || Session["studentID"] == null)
            {

                Response.Redirect("velkomstside.aspx", true);
            }
            else
            {
                //Setter StudentID inn i labelen
                StudIDLabel.Text = "StudentID: " + Session["studentID"].ToString();
            }
            //Hvis det ikke er en bruker innlogget fjernes noen elementer fra forsiden
            if (Session["logginn"].Equals(0))
            {
                minefagDiv.InnerHtml = "";
                minevurderingerDiv.InnerHtml = "";
                ingenSessionDiv.InnerHtml = "<h2 class='text-center'>Vurderingssystem</h2>" +
                                            "<p class='text-justify'>I vurderingssystemet kan studentene ved USN ta og utføre fagvurderinger" +
                                            "Og de kan se gjennsomsnittsresultatene til alle vurderte fag på USN." +
                                            "For å kunne se på resultatene vennligst søk etter en fagkode eller et fagnavn i søkefeltet.</p>";
            }
        }
    }
}