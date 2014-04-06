using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using SampleWeb.Helpers;
using System.Data.Linq;
using SampleWeb.Entities;

namespace SampleWeb.Models
{
    public class UserAccount
    {
        public static bool Login(string account, string password)
        {
            LogHelper.Logger.Info(string.Format("Login: {0}", account));
            var result = DBHelper.Run(context => {
                var user = User.Get(context, account, password);

                if (user == null)
                {
                    return new Result() { IsSuccess = false };
                }
                else
                {
                    CurrentUser.Save(user);
                    return new Result() { IsSuccess = true };
                }
            });

            return result.IsSuccess;
        }

        public static void Logout()
        {
            LogHelper.Logger.Info(string.Format("Logout: {0}", CurrentUser.Get().Account));
            CurrentUser.Clear();
        }

        public static bool AddUser(string account, string password, string email = "")
        {
            var result = DBHelper.Run(context =>
            {
                var user = User.Get(context, account);
                if (user != null)
                {
                    return new Result() { IsSuccess = false };
                }

                User.Add(context, account, password, email);
                context.SubmitChanges();
                return new Result() { IsSuccess = true };
            });

            return result.IsSuccess;
        }
    }
}