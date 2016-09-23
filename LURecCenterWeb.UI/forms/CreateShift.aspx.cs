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
    public partial class CreateShift : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(100);
            string date = DateTime.Now.Date.ToString("MM-dd-yyyy");
            string month = DateTime.Now.Month.ToString();
            string years = DateTime.Now.Year.ToString();
            lblcurrentDay.Text = DateTime.Now.ToString("dddd") + " , " + date;
            string currenttime = DateTime.Now.ToLongTimeString();
            lblcurrenttime.Text = currenttime;
        }
        protected void btnSubmit_click(object sender, EventArgs e)
        {
            ShiftModel request = new ShiftModel()
            {
                ShiftComment = txtComment.Text,
                ShiftName = txtShiftName.Text,
                ShiftDate = Shiftfromclanderdate.SelectedDate,
                //shiftto = txttimeto.Text,
                ShiftFrom = ddtimeFrom.SelectedItem.Value + " : " + ddampm.SelectedItem.Value,
            };
            IUtilityBAL bal = new UtilityBAL();
            ResponseModel response = bal.createShift(request);
            if (response.MessageCode == ResponseMessageCode.SUCCESS)
            {
                Label1.Text = "Shift has been created.";
            }
            else
            {

            }
            
        }

       protected void ddtimeFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddtimeFrom.SelectedItem.Value == "11")
            {
                if (ddampm.SelectedItem.Value == "AM")
                {
                    //txttimeto.Text = "01 : PM";
                }
                else
                {
                 //   txttimeto.Text = "02 : AM";
                }
            }
            else
                if (ddtimeFrom.SelectedItem.Value == "12")
                {
                    if (ddampm.SelectedItem.Value == "AM")
                    {
                        //txttimeto.Text = "02 : PM";
                    }
                    else
                    {
                        //txttimeto.Text = "02 : AM";
                    }
                }
                else
                {
                  //  txttimeto.Text = Convert.ToInt32(ddtimeFrom.SelectedItem.Value) + 2 + " : " + ddampm.SelectedItem.Value;
                }

        }
    }
}