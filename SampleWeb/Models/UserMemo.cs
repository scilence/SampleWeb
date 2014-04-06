using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleWeb.Helpers;
using SampleWeb.Entities;

namespace SampleWeb.Models
{
    public class UserMemo
    {
        public static bool AddMemo(SampleWeb.Entities.Memo memo)
        {
            var result = DBHelper.Run(context =>
            {
                memo.Creater = "user";//CurrentUser.Get().ID;
                memo.CreatedTime = DateTime.Now;
                SampleWeb.Entities.Memo.Add(context, memo);
                context.SubmitChanges();
                return new Result() { IsSuccess = true };
            });

            return result.IsSuccess;
        }
    }
}