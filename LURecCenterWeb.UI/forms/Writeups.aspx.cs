using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LURecCenter.BAL.Interface;
using LURecCenter.Entity;
using LURecCenter.BAL;

namespace LURecCenterWeb.UI.forms
{
     public partial class Writeups : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_click(object sender, EventArgs e)
        {
            WritesUpModel request = new WritesUpModel()
            {
                WritesUpText = txtwritesup.Text,
                touser = txtemail.Text
            };
            IUtilityBAL bal = new UtilityBAL();
            ResponseModel response = bal.createWriteSup(request);
            if (response.MessageCode == ResponseMessageCode.SUCCESS)
            {

            }
            else
            {

            }
        }
    }
}