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
        public static DataResult<SampleWeb.Entities.Memo> Confirm(SampleWeb.Entities.Memo memo)
        {
            bool isSuccess = UserMemo.AddMemo(memo);

            DataResult<SampleWeb.Entities.Memo> result = new DataResult<SampleWeb.Entities.Memo>();
            result.IsSuccess = isSuccess;
            result.Message = isSuccess ? "新增成功" : "新增失敗";
            result.Data = memo;
            return result;
        }

    }
}