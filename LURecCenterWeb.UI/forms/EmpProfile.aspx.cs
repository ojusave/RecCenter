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
        PersonBAL _personbal1;
        public static int Userid1;
        protected void Page_Load1(object sender, EventArgs e)
        {
            if (Session["USERID"] != null)
            {
                Userid = Convert.ToInt32(Session["USERID"]);
            }
            if (!IsPostBack)
            {
                this.bindUserDetails1(Userid);
            }

        }


        public void bindUserDetails1(int Userid)
        {
            _personbal1 = new PersonBAL();

            PersonModel person = _personbal1.GetPersonById(Userid);
            hdnuserid1.Value = person.userID.ToString();
            txtfrstname1.Text = person.firstname;
            txtlastname1.Text = person.lastname;
            txtemail1.Text = person.emailid;

            txtPhone1.Text = person.phone;
            txtpin1.Text = person.pincode;

            txtDOB1.Text = person.dateofbirth.ToString();
            txtAddress1.Text = person.address;
            txtfrstname1.Enabled = false;
            txtlastname1.Enabled = false;
            txtemail1.Enabled = false;

            txtPhone1.Enabled = false;
            txtpin1.Enabled = false;

            txtDOB1.Enabled = false;
            txtAddress1.Enabled = false;


        }


        protected void btnSubmit1_click(object sender, EventArgs e)
        {

            if (btnSubmit1.Text == "Update")
            {
                PersonModel request = new PersonModel()
                {
                    userID = Convert.ToInt32(hdnuserid1.Value),
                    firstname = txtfrstname1.Text,
                    lastname = txtlastname1.Text,
                    emailid = txtemail1.Text,
                    phone = txtPhone1.Text,
                    pincode = txtpin1.Text,
                    dateofbirth = Convert.ToDateTime(txtDOB1.Text),
                    address = txtAddress1.Text,

                };
                IUserBAL _bal = new UserBAL();
                ResponseModel response = _bal.UpdateUser(request);

            }
            else
            {
                txtfrstname1.Enabled = true;
                txtlastname1.Enabled = true;
                txtemail1.Enabled = true;

                txtPhone1.Enabled = true;
                txtpin1.Enabled = true;

                txtDOB1.Enabled = true;
                txtAddress1.Enabled = true;
                btnSubmit1.Text = "Update";
            }
        }


    }
}