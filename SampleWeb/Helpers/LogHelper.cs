using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace SampleWeb.Helpers
{
    public class LogHelper
    {
        private LogHelper() { }

        private static ILog mLogger = null;

        public static ILog Logger
        {
            get
            {
                if (mLogger == null)
                {
                    mLogger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
                }

                return mLogger;
            }
        }
    }
}