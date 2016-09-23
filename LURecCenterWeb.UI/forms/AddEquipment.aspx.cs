using LURecCenter.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LURecCenter.BAL.Interface;
using LURecCenter.BAL;

namespace LURecCenterWeb.UI.forms
{
    public partial class AddEquipment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_click(object sender, EventArgs e)
        {
            EquipmentModel request = new EquipmentModel()
            {
                EquipmentName = txtEquipmentName.Text,
                EquipmentPrice = txtEquipmentPrice.Text,
                EquipmentAddDate = Convert.ToDateTime(txtEquipmentAddDate.Text),
                EquipmentBARCode = txtEquipmentBARCode.Text,
                EquipmentBrand = txtEquipmentBrand.Text
            };
            IUtilityBAL _utilitybal = new UtilityBAL();
            ResponseModel response = _utilitybal.insertEquipment(request);
            if (response.MessageCode == ResponseMessageCode.SUCCESS)
            {

            }
            else
            {

            }

        }
    }
}