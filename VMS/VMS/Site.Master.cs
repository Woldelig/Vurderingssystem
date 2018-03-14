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
            try
            {
                if (!SjekkInnlogging())
                {
                    minefag.Visible = false;
                    minevurderinger.Visible = false;
                    loggutBtn.Text = "Logg inn";

                }

            }
            catch (Exception)
            {

            }
        }
        private Boolean SjekkInnlogging()
        {
            if((int)Session["logginn"] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string loggutBtnText
        {
            get
            {
                return loggutBtn.Text;
            }
            set
            {
                loggutBtn.Text = value;
            }
        }

        public Boolean loggutBtnShow
        {
            get
            {
                return loggutBtn.Visible = true;
            }
            set
            {
                loggutBtn.Visible = value;
            }
        }

        protected void loggutBtn_Click(object sender, EventArgs e)
        {
            if (loggutBtn.Text == "Logg ut")
            {
                Session["logginn"] = 0;
                Response.Redirect("velkomstside.aspx", true);
            } else if(loggutBtn.Text == "Logg inn")
            {
                Response.Redirect("velkomstside.aspx", true);
            }
        }
    }
}