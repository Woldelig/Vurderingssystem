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
            Session["logginn"] = null;
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("innlogging.aspx", true);
        }

        protected void continue_Click(object sender, EventArgs e)
        {
            Session["logginn"] = 0;
            Session["studentID"] = "Ukjent";
            Server.Transfer("Default.aspx", true);
        }
    }
}