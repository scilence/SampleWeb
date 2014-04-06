using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using SampleWeb.Entities;
using SampleWeb.Models;
using System.Web.Security;

namespace SampleWeb.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }

        [WebMethod(EnableSession=true)]
        public static Result LoginAccount(string account, string password)
        {
            Result result = new Result();

            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
            {
                result.IsSuccess = false;
                result.Message = "必須填寫 帳號/密碼";
                return result;
            }

            result.IsSuccess = UserAccount.Login(account, password);
            result.Message = result.IsSuccess ? "登入成功" : "登入失敗";
            FormsAuthentication.SetAuthCookie(account, false);
            //HttpContext.Current.Response.Redirect(@"~\Memo\Memo.aspx");
            return result;
        }

        [WebMethod]
        public static string GetDate()
        {
            return DateTime.Now.ToString();
        }
    }
}
