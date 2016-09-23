using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LURecCenterWeb.UI.forms
{
    public partial class EmployeeDashboard : System.Web.UI.Page
    {
        protected void Page_Load2(object sender, EventArgs e)
        {
            if (Session["USERNAME"] != null)
            {
                lblusername.Text = Session["USERNAME"].ToString();
            }
        }
    }
}