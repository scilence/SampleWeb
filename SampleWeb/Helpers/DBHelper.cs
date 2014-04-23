using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using System.Data.Linq;
using SampleWeb.Entities;

namespace SampleWeb.Helpers
{
    public class DBHelper
    {
        private DBHelper() { }

        public static BaseResult Run(Func<DataContext, BaseResult> func)
        {
            using (var connection = new SQLiteConnection(WebSettings.ConnectionString))
            using (var context = new DataContext(connection))
            {
                try
                {
                    return func(context);
                }
                catch (Exception e)
                {
                    LogHelper.Logger.Debug("DBHelpe", e);
                    return new BaseResult() { IsSuccess = false, Message = e.Message };
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}