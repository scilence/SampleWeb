using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleWeb.Entities;

namespace SampleWeb.Helpers
{
    public class CurrentUser
    {
        private const string sessionName = "CurrentUser";

        private CurrentUser() { }

        public static User Get()
        {
            return HttpContext.Current.Session[sessionName] as User;
        }

        public static void Save(User user)
        {
            HttpContext.Current.Session.Add(sessionName, user);
        }

        public static void Clear()
        {
            HttpContext.Current.Session.Remove(sessionName);
        }

    }
}