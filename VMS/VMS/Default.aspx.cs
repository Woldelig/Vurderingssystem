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
            if (Session["logginn"] == null)
            {
                Server.Transfer("velkomstside.aspx", true);
            }
            else
            {
                //Setter StudentID inn i labelen
                StudIDLabel.Text = "StudentID: " + Session["studentID"].ToString();
            }
        }
    }
}