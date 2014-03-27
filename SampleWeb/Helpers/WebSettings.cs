using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SampleWeb.Helpers
{
    public class WebSettings
    {
        private WebSettings() { }

        public static string ConnectionString
        {
            get 
            {
                return WebConfigurationManager.ConnectionStrings["SQLITE"].ToString(); 
            }
        }

    }
}