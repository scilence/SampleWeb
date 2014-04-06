using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleWeb.Entities;
using SampleWeb.Models;
using System.Web.Services;

namespace SampleWeb.Memo
{
    public partial class Memo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static Result Confirm(SampleWeb.Entities.Memo memo)
        {
            bool isSuccess = UserMemo.AddMemo(memo);

            Result result = new Result();
            result.IsSuccess = isSuccess;
            result.Message = isSuccess ? "新增成功" : "新增失敗";
            return result;
        }

    }
}