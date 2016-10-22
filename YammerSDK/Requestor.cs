using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Hosting;
using Newtonsoft.Json;
using YammerSDK.Connection;
using YammerSDK.Helpers;
using YammerSDK.Messages;
using YammerSDK.Token;


namespace YammerSDK
{
    public class Requestor
    {

        private string _accesstoken { get; set; }
        public void Connection(string _clientid,string _clientsecret, string _clientcode, string _uri)
        {
            Client.CLIENT_ID = _clientid;
            Client.CLIENT_SECRET = _clientsecret;
            Client.CLIENT_CODE = _clientcode;
            Client.REDIR_URL = _uri;
            Client.AccessToken = _accesstoken;
        }

        public string Credentials(string username, string password)
        {
            return _accesstoken=Client.LogIn(username,password );
        }

        public User GetCurrentUser()
        {
            
            return JsonConvert.DeserializeObject<User>(Helper.MakeGetRequest(Constants.currentUserUrl, _accesstoken));
             
        }

        public User GetUserById(string _id)
        {
            return JsonConvert.DeserializeObject<User>(Helper.MakeGetRequest(Constants.oneUserUrl.Replace("[:id]", _id), _accesstoken));
        }

        public List<User> GetAllUsers()
        {
            return  Helper.PaginatedData<User>(Constants.allUsersUrl, _accesstoken);
        }

        public List<Groups> GetAllGroups()
        {
           return  Helper.PaginatedData<Groups>(Constants.allGroupsUrl, _accesstoken);
       
        }

        public List<Groups> GetPublicGroups()
        {
           
            return GetAllGroups().Where(x => x.Privacy == "public").ToList<Groups>();
        }

        public List<Groups> GetPrivateGroups()
        {
            return GetAllGroups().Where(x => x.Privacy == "private").ToList<Groups>();
        }

        public  RootMessages GetPublicMessages()
        {
            return JsonConvert.DeserializeObject<RootMessages>(Helper.MakeGetRequest(Constants.publicMessageUrl, _accesstoken));
        }

        public RootMessages GetPrivateMessages()
        {
            return JsonConvert.DeserializeObject<RootMessages>(Helper.MakeGetRequest(Constants.privateMessageUrl, _accesstoken));
        }

        public RootMessages GetReceivedMessages()
        {
            return JsonConvert.DeserializeObject<RootMessages>(Helper.MakeGetRequest(Constants.receivedMessageUrl, _accesstoken));
        }

        public RootMessages GetFollowingMessages()
        {
            return JsonConvert.DeserializeObject<RootMessages>(Helper.MakeGetRequest(Constants.followingMessageUrl, _accesstoken));
        }

        public RootMessages GetSentMessages()
        {
            return JsonConvert.DeserializeObject<RootMessages>(Helper.MakeGetRequest(Constants.sentMessageUrl, _accesstoken));
        }
        public RootMessages GetMyFeedMessages()
        {
            return JsonConvert.DeserializeObject<RootMessages>(Helper.MakeGetRequest(Constants.myfeedMessageUrl, _accesstoken));
        }
        public RootMessages GetAlgoMessages()
        {
            return JsonConvert.DeserializeObject<RootMessages>(Helper.MakeGetRequest(Constants.algoMessageUrl, _accesstoken));
        }

        public Notification GetNotification()
        {
            return JsonConvert.DeserializeObject<Notification>(Helper.MakeGetRequest(Constants.notificationUrl, _accesstoken));
        }

        public List<Network> GetNetworksNoPaginated()
        {
            return Helper.NoPaginatedData<Network>(Constants.networkUrl, _accesstoken);
            
        }

        public bool PostMessage(string body, string groupid,bool brodcasting)
        {
            bool isPosted = false;
            if (!String.IsNullOrEmpty(_accesstoken))
            {
                string msg = "body=" + body + "&group_id=" + groupid+"&broadcast="+brodcasting;
                if (!String.IsNullOrEmpty(Helper.MakePostRequest(msg, Constants.publicMessageUrl,"POST",_accesstoken)))
                {
                    isPosted= true;
                }
            }
            else
            {
                Console.WriteLine("Empty Access Token");
            }
            return isPosted;
        }

        public bool PostMessage(string body, string groupid, bool brodcasting,List<string> topics)
        {
            bool isPosted = false;
            if (!String.IsNullOrEmpty(_accesstoken))
            {
                string strTopics = string.Empty;
                if (topics.Any())
                {
                    strTopics += String.Format("&topic{0}={1}", 1, topics[0]);
                    
                    int j = 1;
                    for (int i = 1; i < topics.Count; i++)
                    {
                        j++;
                        strTopics += String.Format("&topic{0}={1}", j, topics[i]);
                    }

                }
                string msg = "body=" + body + "&group_id=" + groupid + "&broadcast=" + brodcasting + strTopics ;

                if (!String.IsNullOrEmpty(Helper.MakePostRequest(msg, Constants.publicMessageUrl, "POST", _accesstoken)))
                {
                    isPosted = true;
                }
            }
            else
            {
                Console.WriteLine("Empty Access Token");
            }
            return isPosted;
        }

        public bool DeleteMessage(string messageid,string accessToken)
        {
            bool isDeleted = false;
            if (!String.IsNullOrEmpty(accessToken))
            {

                if (!String.IsNullOrEmpty(Helper.MakePostRequest("", Constants.paramMessageUrl.Replace("[:id]", messageid), "DELETE", accessToken)))
                {
                    isDeleted = true;
                }
            }
            else
            {
                Console.WriteLine("Empty Access Token");
            }
            return isDeleted;
        }
    }
}
