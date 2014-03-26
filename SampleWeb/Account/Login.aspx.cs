using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using SampleWeb.Controllers;
using SampleWeb.Models;

namespace SampleWeb.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }

        [WebMethod]
        public static Result Login(string account, string password)
        {
            Result result = new Result();
            result.IsSuccess = LoginController.Login(account, password);

            return result;
        }
    }
}
