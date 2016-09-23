using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LURecCenter.BAL;
using LURecCenter.Entity;

namespace LURecCenterWeb.UI.forms
{
    public partial class ViewLoginHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (Session["USERID"] != null)
                {
                    int userid = Convert.ToInt32(Session["USERID"]);
                    this.BindGrid(userid);
                }

            }
        }
        private void BindGrid(int userid)
        {
            try
            {
                IPersonBAL _Bal = new PersonBAL();
                GridViewEquipment.DataSource = _Bal.GetPersonLoggedinHisbyId(userid);
                GridViewEquipment.DataBind();
            }
            catch (Exception ex)
            {

            }

        }

        protected void GridViewEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}