using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LURecCenter.Entity;
using LURecCenter.BAL;

namespace LURecCenterWeb.UI.forms
{
    public partial class AddUser : System.Web.UI.Page
    {
        PersonBAL _personbal;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindDropDown();
            }
        }

        public void bindDropDown()
        {
            UserBAL _bal = new UserBAL();
            ddUserType.DataSource = _bal.GetUserTypes();
            ddUserType.DataTextField = "Type";
            ddUserType.DataValueField = "UserTypeId";
            ddUserType.DataBind();
        }

        protected void btnSubmit_click(object sender, EventArgs e)
        {
            PersonModel request = new PersonModel()
            {
                firstname = txtfrstname.Text,
                lastname = txtlastname.Text,
                userName = txtusername.Text,
                password = txtpassword.Text,
                emailid = txtemail.Text,
                phone = txtPhone.Text,
                pincode = txtpin.Text,
                IdNumber = txtIdNumber.Text,
                dateofbirth = Convert.ToDateTime(txtDOB.Text),
                address = txtAddress.Text,
                roleID = Convert.ToInt32(ddUserType.SelectedItem.Value)
            };
            _personbal = new PersonBAL();
            ResponseModel response = _personbal.AddPerson(request);
            if (response.MessageCode == ResponseMessageCode.SUCCESS)
            {
                Response.Redirect("ViewUsers.aspx");
            }
            else
            {
                Response.Redirect("ViewUsers.aspx");
            }
        }
    }
}