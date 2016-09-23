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
    public partial class RequestEquipment : System.Web.UI.Page
    {
        protected void Page_Load1(object sender, EventArgs e)
        {

        }
        protected void btnSubmit1_click(object sender, EventArgs e)
        {
            RequestEquipmentModel request = new RequestEquipmentModel()
            {
            //    WritesUpText = txtwritesup1.Text,
              //  touser = txtemail1.Text
            };
            IUtilityBAL bal = new UtilityBAL();
            ResponseModel response = bal.RequestEquipment(request);
            if (response.MessageCode == ResponseMessageCode.SUCCESS)
            {

            }
            else
            {

            }
        }
    }
}