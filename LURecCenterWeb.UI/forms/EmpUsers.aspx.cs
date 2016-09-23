using LURecCenter.BAL;
using LURecCenter.BAL.Interface;
using LURecCenter.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LURecCenterWeb.UI.forms
{
    public partial class ViewUsers : System.Web.UI.Page
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
            IUserBAL _Bal = new UserBAL();
            GridViewUser.DataSource = _Bal.GetUsers();
            GridViewUser.DataBind();

        }
        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridViewUser.Rows[e.RowIndex];
            int userId = Convert.ToInt32(GridViewUser.DataKeys[e.RowIndex].Values[0]);
            string firstname = (row.FindControl("txtfirstname") as TextBox).Text;
            string lastname = (row.FindControl("txtlastname") as TextBox).Text;
            string email = (row.FindControl("txtemailid") as TextBox).Text;
            string phone = (row.FindControl("txtphone") as TextBox).Text;

            string address = (row.FindControl("txtaddress") as TextBox).Text;
            PersonModel request = new PersonModel()
            {
                userID = userId,
                firstname = firstname,
                lastname = lastname,
                emailid = email,
                phone = phone,
                address = address
            };
            IUserBAL _usbal = new UserBAL();
            ResponseModel response = _usbal.UpdateUser(request);

            GridViewUser.EditIndex = -1;
            this.BindGrid();
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
            GridViewUser.EditIndex = -1;
            this.BindGrid();
        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userid = Convert.ToInt32(GridViewUser.DataKeys[e.RowIndex].Values[0]);
            IUserBAL _userbal = new UserBAL();
            ResponseModel response = _userbal.DeleteUser(userid);
            this.BindGrid();
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != GridViewUser.EditIndex)
            {
                (e.Row.Cells[6].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this User?');";
            }
        }


        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewUser.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }


        protected void Link_Click(object sender, EventArgs e)
        {
            Response.Redirect("Adduser.aspx");
        }
    }
}