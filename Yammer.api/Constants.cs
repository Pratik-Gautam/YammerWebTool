using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Yammer.api
{
    internal static class Constants
    {


        public const string permUrl = "https://www.yammer.com/dialog/oauth?client_id=";
        public const string authUrl1 = "https://www.yammer.com/session?client_id=";
        public const string accTokenUrl = "https://www.yammer.com/oauth2/access_token.json?client_id=";
        public const string graphPostUrl = "https://www.yammer.com/api/v1/activity.json";
        public const string paramMessageUrl = "https://www.yammer.com/api/v1/messages/[:id].json";
        public const string publicMessageUrl = "https://www.yammer.com/api/v1/messages.json";
        public const string privateMessageUrl = "https://www.yammer.com/api/v1/messages/private.json";
        public const string receivedMessageUrl = "https://www.yammer.com/api/v1/messages/received.json";
        public const string followingMessageUrl = "https://www.yammer.com/api/v1/messages/following.json";
        public const string myfeedMessageUrl = "https://www.yammer.com/api/v1/messages/my_feed.json";
        public const string algoMessageUrl = "https://www.yammer.com/api/v1/messages/algo.json";
        public const string sentMessageUrl = "https://www.yammer.com/api/v1/messages/sent.json";

        public const string notificationUrl = "https://www.yammer.com/api/v1/streams/notifications.json";

        public const string currentUserUrl = "https://www.yammer.com/api/v1/users/current.json";
        public const string allUsersUrl = "https://www.yammer.com/api/v1/users.json";
        public const string allGroupsUrl = "https://www.yammer.com/api/v1/groups.json";
        public const string oneUserUrl = "https://www.yammer.com/api/v1/users/[:id].json";
        public const string networkUrl = "https://www.yammer.com/api/v1/networks/current.json";



        public static string sessionCookie = string.Empty;
        public static string yamtrackCookie = string.Empty;
        public static CookieContainer cc = new CookieContainer(2);
        public static HttpWebResponse wResp;
        public static HttpWebRequest wr;
    }
}
