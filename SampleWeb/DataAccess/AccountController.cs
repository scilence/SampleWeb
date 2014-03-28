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
    public class AccountController
    {
        public static bool Login(string account, string password)
        {
            using (var connection = new SQLiteConnection(WebSettings.ConnectionString))
            using (var context = new DataContext(connection))
            {
                var user = User.Get(context, account, password);
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

        public static bool AddUser(string account, string password, string email = "")
        {
            using (var connection = new SQLiteConnection(WebSettings.ConnectionString))
            using (var context = new DataContext(connection))
            {
                var user = User.Get(context, account);
                if (user != null)
                {
                    return false;
                }

                User.Add(context, account, password, email);
                context.SubmitChanges();
                connection.Close();

                return true;

            }
        }
    }
}