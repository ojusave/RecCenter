using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LURecCenterWeb.UI.forms
{
    public partial class VisiterDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["USERID"] != null)
            {
                int Userid = Convert.ToInt32(Session["USERID"]);
            }
        }
    }
}