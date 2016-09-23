using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LURecCenter.BAL;
using LURecCenter.Entity;
using LURecCenter.BAL.Interface;

namespace LURecCenterWeb.UI.forms
{
    public partial class PickShift : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USERID"] != null)
            {
                int userid = Convert.ToInt32(Session["USERID"]);
                this.BindGrid();
                this.BindGridPicked(userid);
            }
        }

        private void BindGrid()
        {
            try
            {
                IUtilityBAL _Bal = new UtilityBAL();
                GridViewShift.DataSource = _Bal.GetActiveShift();
                GridViewShift.DataBind();
            }
            catch (Exception ex)
            {

            }

        }

        private void BindGridPicked(int userid)
        {
            try
            {
                IUtilityBAL _Bal = new UtilityBAL();
                GridViewPickedShift.DataSource = _Bal.GetPickedshift(userid);
                GridViewPickedShift.DataBind();
            }
            catch (Exception ex)
            {

            }

        }
        protected void OnRowDeletingpk(object sender, GridViewDeleteEventArgs e)
        {
            int shiftid = Convert.ToInt32(GridViewPickedShift.DataKeys[e.RowIndex].Values[0]);
            IUtilityBAL _utilitybal = new UtilityBAL();
            int userid = 1;
            if (Session["USERID"] != null)
            {
                userid = Convert.ToInt32(Session["USERID"]);

            }
            ShiftModel request = new ShiftModel()
            {
                ShiftId = shiftid,
                PickedByUser = userid
            };
            ResponseModel response = _utilitybal.PickedShiftUpdate(request);

            this.BindGrid();
            this.BindGridPicked(userid);

        }

        protected void OnRowDataBoundpk(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != GridViewPickedShift.EditIndex)
            {
                (e.Row.Cells[4].Controls[1] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to drop this Shift?');";
            }
        }


        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int shiftid = Convert.ToInt32(GridViewShift.DataKeys[e.RowIndex].Values[0]);
            IUtilityBAL _utilitybal = new UtilityBAL();
            int userid = 1;
            if (Session["USERID"] != null)
            {
                userid = Convert.ToInt32(Session["USERID"]);

            }
            ShiftModel request = new ShiftModel()
            {
                ShiftId = shiftid,
                PickedByUser = userid
            };
            ResponseModel response = _utilitybal.PickShiftUpdate(request);
            this.BindGrid();
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != GridViewShift.EditIndex)
            {
                (e.Row.Cells[4].Controls[1] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to pick this Shift?');";
            }
        }
    }
}