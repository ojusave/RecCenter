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
    public partial class ViewWritesUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindGrid();
        }
        private void BindGrid()
        {
            try
            {
                IPersonBAL _Bal = new PersonBAL();
                GridViewwritesp.DataSource = _Bal.GetwritesUp();
                GridViewwritesp.DataBind();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}