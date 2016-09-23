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
    public partial class IsssueEquipment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Bindequipment();
                this.BindUser();
                BindGrid();
            }
        }

        public void Bindequipment()
        {
            IUtilityBAL _bal = new UtilityBAL();
            ddEquipmentlist.DataSource = _bal.GetEquipment();
            ddEquipmentlist.DataTextField = "EquipmentName";
            ddEquipmentlist.DataValueField = "EquipmentID";
            ddEquipmentlist.DataBind();
        }

        public void BindGrid()
        {
            IUtilityBAL _bal = new UtilityBAL();
            GridViewEquipment.DataSource = _bal.GetIssuedEquipments();
            GridViewEquipment.DataBind();
        }

        public void BindUser()
        {
            IUserBAL _bal = new UserBAL();
            Dduserlist.DataSource = _bal.GetUsers();
            Dduserlist.DataTextField = "fullname";
            Dduserlist.DataValueField = "userID";
            Dduserlist.DataBind();
        }

        protected void btnSubmit_click(object sender, EventArgs e)
        {
            IssueEquipment issuee = new IssueEquipment()
            {
                EquipmentId = Convert.ToInt32(ddEquipmentlist.SelectedItem.Value),
                UserId = Convert.ToInt32(Dduserlist.SelectedItem.Value),
                isRerurned = false,
                issueComments = txtcomment.Text,
            };

            IUtilityBAL _bal = new UtilityBAL();
            ResponseModel resp = _bal.IssueEquipment(issuee);
            if (resp.MessageCode == ResponseMessageCode.SUCCESS)
            {
                BindGrid();
            }

        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int equipmentid = Convert.ToInt32(GridViewEquipment.DataKeys[e.RowIndex].Values[0]);
            IUtilityBAL _utilitybal = new UtilityBAL();
            IssuedEquipments request = new IssuedEquipments()
            {
                IssueEqipmentId = equipmentid
            };
            ResponseModel response = _utilitybal.ReturnEquipment(request);
            this.BindGrid();
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != GridViewEquipment.EditIndex)
            {
                (e.Row.Cells[5].Controls[0] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to Retrun this Equipment?');";
            }
        }

    }
}