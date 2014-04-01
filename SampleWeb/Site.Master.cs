using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleWeb.Helpers;

namespace SampleWeb
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (CurrentUser.Get() != null)
                {
                    NavigationMenu.Items.Add(new MenuItem("Memo", "Memo", "", @"~\Memo\Memo.aspx"));
                }
                //
            }
        }
    }
}
