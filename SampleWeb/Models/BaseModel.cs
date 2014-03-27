using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using SampleWeb.Helpers;
using System.Data.SQLite;

namespace SampleWeb.Models
{
    public abstract class BaseModel
    {
        //protected DataContext GetContext()
        //{
        //    var connection = new SQLiteConnection(WebSettings.ConnectionString);
        //    return new DataContext(connection);
        //}

    }
}