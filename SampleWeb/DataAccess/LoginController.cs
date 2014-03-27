using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using SampleWeb.Helpers;
using System.Data.Linq;
using SampleWeb.Models;

namespace SampleWeb.DataAccess
{
    public class LoginController
    {
        public static bool Login(string account, string password)
        {
            using (var connection = new SQLiteConnection(WebSettings.ConnectionString))
            using (var context = new DataContext(connection))
            {
                var user = User.GetUser(context, account, password);
                connection.Close();

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
        }

        public static void Logout()
        {
            CurrentUser.Clear();
        }
    }
}