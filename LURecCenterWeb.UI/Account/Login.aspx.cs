using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using LURecCenterWeb.UI.Models;
using LURecCenter.BAL;
using LURecCenter.Entity;

namespace LURecCenterWeb.UI.Account
{
    public partial class Login : Page
    {
        UserBAL _userBal = new UserBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
           if( Session["USERNAME"]!= null)
           {

           }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Validate the user password
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();
                UserModel user = new UserModel()
                {
                    UserName = Email.Text,
                    UserPassword = Password.Text,
                };
                LoginResponse respon = _userBal.LoginUser(user);
                if (respon.MessageCode == ResponseMessageCode.SUCCESS)
                {
                    Session["USERNAME"] = respon.UserName;
                    Session["USERID"] = respon.UserId;
                   // Response.Write(Session["USERNAME"].ToString());
                    if (respon.UserRole=="1")
                    {
                        Response.Redirect("../forms/VisitorDashboard.aspx");
                    }
                    else if (respon.UserRole == "2")
                    {
                        Response.Redirect("../forms/EmployeeDashboard.aspx");

                    }
                    else if (respon.UserRole == "3" || respon.UserRole == "4")
                    {
                        Response.Redirect("../forms/AdminDashboard.aspx");

                    }                    
                   
                }
                else
                {
                    FailureText.Text = "Invalid login attempt";
                    ErrorMessage.Visible = true;
                }

                // This doen't count login failures towards account lockout
                // To enable password failures to trigger lockout, change to shouldLockout: true
              //   var result = signinManager.PasswordSignIn(Email.Text, Password.Text, RememberMe.Checked, shouldLockout: false);

                //switch (result)
                //{
                //    case SignInStatus.Success:
                //        IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                //        break;
                //    case SignInStatus.LockedOut:
                //        Response.Redirect("/Account/Lockout");
                //        break;
                //    case SignInStatus.RequiresVerification:
                //        Response.Redirect(String.Format("/Account/TwoFactorAuthenticationSignIn?ReturnUrl={0}&RememberMe={1}", 
                //                                        Request.QueryString["ReturnUrl"],
                //                                        RememberMe.Checked),
                //                          true);
                //        break;
                //    case SignInStatus.Failure:
                //    default:
                //        FailureText.Text = "Invalid login attempt";
                //        ErrorMessage.Visible = true;
                //        break;
                //}
            }
        }
        }
}