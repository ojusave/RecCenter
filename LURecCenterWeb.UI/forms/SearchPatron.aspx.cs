using MODI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using LURecCenter.BAL;
using LURecCenter.Entity;

namespace LURecCenterWeb.UI.forms
{
    public partial class SearchPatron : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Upload(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("~/Uploads/" + Path.GetFileName(FileUpload1.PostedFile.FileName));
            FileUpload1.SaveAs(filePath);
            string extractText = this.ExtractTextFromImage(filePath);
            //lblText.Text = extractText.Replace(Environment.NewLine, "<br />");
            TxtIdNumber.Text = Regex.Replace(extractText, "[^0-9]+", string.Empty);
            // lblText.Text = Regex.Split(extractText, @"\D+").ToString();
        }
        protected void Search_Student(object sender, EventArgs e)
        {

            string idNumber = TxtIdNumber.Text;
            bindUserDetails(idNumber);
            Label1.Text = "Checked-in Successfully.";
        }

        public void bindUserDetails(string idNumber)
        {
            IPersonBAL _personbal = new PersonBAL();

            PersonModel person = _personbal.GetPersonByIdNumber(idNumber);
            hdnuserid.Value = person.userID.ToString();
            txtfrstname.Text = person.firstname;
            txtlastname.Text = person.lastname;
            txtemail.Text = person.emailid;

            txtPhone.Text = person.phone;

            txtAddress.Text = person.address;
            txtfrstname.Enabled = false;
            txtlastname.Enabled = false;
            txtemail.Enabled = false;

            txtPhone.Enabled = false;

            txtAddress.Enabled = false;


        }
        private string ExtractTextFromImage(string filePath)
        {
            Document mDocument = new Document();
            mDocument.Create(filePath);
            mDocument.OCR(MiLANGUAGES.miLANG_ENGLISH);
            MODI.Image modiImage = (mDocument.Images[0] as MODI.Image);
            string extractedText = modiImage.Layout.Text;
            mDocument.Close();
            return extractedText;
        }
    }
}