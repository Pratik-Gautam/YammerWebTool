using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Yammer.api;

namespace YammerWebTool
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var myConfig = new ClientConfigurationContainer
            {
                ClientCode = null,
                ClientId = "PJm3xZoYURsWFlwjd4ffyA",
                ClientSecret = "712YAIXaXT8UuF5k1DTR3UxyvL4MmRcYXt9Xk02Y7U",
                RedirectUri = "http://localhost:28876/"
            };
            var myYammer = new YammerClient(myConfig);
            var url = myYammer.GetLoginLinkUri();
        }
    }
}