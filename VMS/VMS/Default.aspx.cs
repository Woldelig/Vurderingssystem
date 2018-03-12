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
            //Setter StudentID inn i labelen
            try
            {
                StudIDLabel.Text = "StudentID: " + Session["studentID"].ToString();
            }
            catch (Exception)
            {
                StudIDLabel.Text = "StudentID: Ingen session registrert";
            }
        }
    }
}