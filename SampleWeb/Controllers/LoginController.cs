using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using SampleWeb.Helpers;

namespace SampleWeb.Controllers
{
    public class LoginController
    {
        public static bool Login(string account, string password)
        {
            var db = new SampleWeb.Models.DBSampleDB();
            var user = db.Users.First(item => item.Account.Equals(account) && item.Password.Equals(password));
            if (user == null)
            {
                return false;
            }
            else
            {
                CurrentUser.Save(user);
                return true;
            }
        }

        public static void Logout()
        {
            CurrentUser.Clear();
        }
    }
}