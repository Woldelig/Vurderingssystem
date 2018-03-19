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
            }
        }
    }
}