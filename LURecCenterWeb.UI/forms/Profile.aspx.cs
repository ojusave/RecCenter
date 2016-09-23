using LURecCenter.BAL;
using LURecCenter.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LURecCenterWeb.UI.forms
{
    public partial class Profile : System.Web.UI.Page
    {
        PersonBAL _personbal;
        public static int Userid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USERID"] != null)
            {
                Userid = Convert.ToInt32(Session["USERID"]);
            }
            if (!IsPostBack)
            {
                this.bindUserDetails(Userid);
            }

        }


        public void bindUserDetails(int Userid)
        {
            _personbal = new PersonBAL();

            PersonModel person = _personbal.GetPersonById(Userid);
            hdnuserid.Value = person.userID.ToString();
            txtfrstname.Text = person.firstname;
            txtlastname.Text = person.lastname;
            txtemail.Text = person.emailid;

            txtPhone.Text = person.phone;
            txtpin.Text = person.pincode;

            txtDOB.Text = person.dateofbirth.ToString();
            txtAddress.Text = person.address;
            txtfrstname.Enabled = false;
            txtlastname.Enabled = false;
            txtemail.Enabled = false;

            txtPhone.Enabled = false;
            txtpin.Enabled = false;

            txtDOB.Enabled = false;
            txtAddress.Enabled = false;


        }


        protected void btnSubmit_click(object sender, EventArgs e)
        {

            if (btnSubmit.Text == "Update")
            {
                PersonModel request = new PersonModel()
                {
                    userID = Convert.ToInt32(hdnuserid.Value),
                    firstname = txtfrstname.Text,
                    lastname = txtlastname.Text,
                    emailid = txtemail.Text,
                    phone = txtPhone.Text,
                    pincode = txtpin.Text,
                    dateofbirth = Convert.ToDateTime(txtDOB.Text),
                    address = txtAddress.Text,

                };
                IUserBAL _bal = new UserBAL();
                ResponseModel response = _bal.UpdateUser(request);

            }
            else
            {
                txtfrstname.Enabled = true;
                txtlastname.Enabled = true;
                txtemail.Enabled = true;

                txtPhone.Enabled = true;
                txtpin.Enabled = true;

                txtDOB.Enabled = true;
                txtAddress.Enabled = true;
                btnSubmit.Text = "Update";
            }
        }


    }
}