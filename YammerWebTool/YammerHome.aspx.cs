using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YammerSDK;
using Yammer.api;
using YammerSDK.Helpers;
using System.Net;
using System.Text;
using System.IO;

namespace YammerWebTool
{
    public partial class YammerHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnDeleteMessages_Click(object sender, EventArgs e)
        {
            try {
                lblStatus.Text = string.Empty;
                var myConfig = new ClientConfigurationContainer
                {
                    ClientCode = null,
                    ClientId = "Sf1pc2Mh6oGTzQJbvtjA",
                    ClientSecret = "291JrjyKtkTmislg1haEWZvMF7aILQsqflJJI6sxQE",
                    RedirectUri = "http://localhost:28876/"
                };
                var myYammer = new YammerClient(myConfig);
                var url = myYammer.GetLoginLinkUri();



                if (!string.IsNullOrWhiteSpace(txtMessageIds.Text))
                {
                    string[] messageIds = txtMessageIds.Text.Split(',');
                    var yammer = new YammerClient("Sf1pc2Mh6oGTzQJbvtjA", "291JrjyKtkTmislg1haEWZvMF7aILQsqflJJI6sxQE", "http://localhost:28876/", "f3MxJOzHZ7H26QtfBajQw", null);
                    string accessToken = yammer.GetToken();
                    Requestor req = new Requestor();
                    StringBuilder deleteStatus = new StringBuilder();
                    foreach (string messageid in messageIds)
                    {
                        try
                        {
                            bool isDeleted=req.DeleteMessage(messageid.Trim(), accessToken);
                            if(isDeleted)
                            {
                                deleteStatus.AppendLine("Message with Message ID: " + messageid + " is deleted");
                                deleteStatus.AppendLine("<br/>");
                            }
                        }
                        catch(Exception ex)
                        {
                            Response.Write("Error: " + ex.Message + " while deleting message with id: " + messageid);
                        }
                    }
                    lblStatus.Text = deleteStatus.ToString();
                }
            }
            catch(Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }
    }
}