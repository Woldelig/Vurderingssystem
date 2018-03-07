using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VMS
{
    public partial class SiteMaster : MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["logginn"] == null)
            {
                Server.Transfer("velkomstside.aspx", true);
            }
            else if(!SjekkInnlogging())
            {
                minefag.Visible = false;
                minevurderinger.Visible = false;

            } 
        }
        private Boolean SjekkInnlogging()
        {
            if((int)Session["logginn"] == 0)
            {
                return false;
            }
            else if((int)Session["logginn"] == 1)
            {
                return true;
            }
            return false;
        }
    }
}