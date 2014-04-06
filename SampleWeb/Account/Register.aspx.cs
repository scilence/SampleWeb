using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleWeb.Entities;
using System.Web.Services;
using SampleWeb.Models;

namespace SampleWeb.Account
{
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        }

        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {
            //FormsAuthentication.SetAuthCookie(RegisterUser.UserName, false /* createPersistentCookie */);

            //string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            //if (String.IsNullOrEmpty(continueUrl))
            //{
            //    continueUrl = "~/";
            //}
            //Response.Redirect(continueUrl);
        }

        [WebMethod]
        public static Result AddUser(string account, string password, string email)
        {
            Result result = new Result();

            result.IsSuccess = UserAccount.AddUser(account, password, email);
            result.Message = result.IsSuccess ? "註冊成功" : "註冊失敗";
            if (!result.IsSuccess)
            {
                return result;
            }
            HttpContext.Current.Response.Redirect(@"~\Default.aspx");

            return result;
        }

    }
}
