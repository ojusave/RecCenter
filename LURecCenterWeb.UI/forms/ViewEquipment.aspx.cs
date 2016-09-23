using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LURecCenter.Entity;
using LURecCenter.BAL;
using LURecCenter.BAL.Interface;

namespace LURecCenterWeb.UI.forms
{
    public partial class ViewEquipment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }

        private void BindGrid()
        {
            IUtilityBAL _Bal = new UtilityBAL();
            GridViewEquipment.DataSource = _Bal.GetEquipment();
            GridViewEquipment.DataBind();

        }

        protected void Insert(object sender, EventArgs e)
        {
            EquipmentModel request = new EquipmentModel()
            {
                EquipmentName = txtEquipmentName.Text,
                EquipmentPrice = txtEquipmentPrice.Text,
                EquipmentAddDate = DateTime.UtcNow,
                EquipmentBARCode = txtEquipmentBARCode.Text,
                EquipmentBrand = txtEquipmentBrand.Text
            };
            IUtilityBAL _utilitybal = new UtilityBAL();
            ResponseModel response = _utilitybal.insertEquipment(request);
            if (response.MessageCode == ResponseMessageCode.SUCCESS)
            {
                this.BindGrid();
                txtEquipmentName.Text = "";
                txtEquipmentPrice.Text = "";
                txtEquipmentBARCode.Text = "";
                txtEquipmentBrand.Text = "";
            }
        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridViewEquipment.Rows[e.RowIndex];
            int equipmentId = Convert.ToInt32(GridViewEquipment.DataKeys[e.RowIndex].Values[0]);
            string EquipmentName = (row.FindControl("txtEquipmentName") as TextBox).Text;
            string EquipmentBARCode = (row.FindControl("txtEquipmentBARCode") as TextBox).Text;
            string EquipmentBrand = (row.FindControl("txtEquipmentBrand") as TextBox).Text;
            string EquipmentPrice = (row.FindControl("txtEquipmentPrice") as TextBox).Text;
            EquipmentModel request = new EquipmentModel()
            {
                EquipmentID = equipmentId,
                EquipmentName = EquipmentName,
                EquipmentPrice = EquipmentPrice,
                EquipmentBARCode = EquipmentBARCode,
                EquipmentBrand = EquipmentBrand
            };
            IUtilityBAL _utilitybal = new UtilityBAL();
            ResponseModel response = _utilitybal.UpdateEquipment(request);

            GridViewEquipment.EditIndex = -1;
            this.BindGrid();
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
            GridViewEquipment.EditIndex = -1;
            this.BindGrid();
        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int equipmentid = Convert.ToInt32(GridViewEquipment.DataKeys[e.RowIndex].Values[0]);
            IUtilityBAL _utilitybal = new UtilityBAL();
            ResponseModel response = _utilitybal.DeleteEquipment(equipmentid);
            this.BindGrid();
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != GridViewEquipment.EditIndex)
            {
                (e.Row.Cells[4].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this Equipment?');";
            }
        }


        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewEquipment.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }
    }
}