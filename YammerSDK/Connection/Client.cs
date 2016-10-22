using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using YammerSDK.Helpers;
using YammerSDK.Token;

namespace YammerSDK.Connection
{
    public static class Client
    {
        public static string CLIENT_ID { get; set; }
        public static string CLIENT_SECRET { get; set; }
        public static string CLIENT_CODE { get; set; }
        public static string REDIR_URL { get; set; }
        public static string AccessToken { get; set; }

       
        public static string LogIn(string iusr,string ipwd)
        {
            string permUrl = Constants.permUrl + CLIENT_ID + "&redirect_uri=" + REDIR_URL;
            string authurl1 = Constants.authUrl1+ CLIENT_ID;
            string accesstokenurl = Constants.accTokenUrl + CLIENT_ID + "&client_secret=" + CLIENT_SECRET + "&code=" + CLIENT_CODE;

            string accessToken = "";
            try
            {

                string qsCode = string.Empty;

                string postResults = string.Empty;
                string response = string.Empty;

                if (string.IsNullOrEmpty(accessToken))
                {
                    while (string.IsNullOrEmpty(qsCode))
                    {
                        response = Helper.MakeGetRequest(permUrl);

                        //look for authenticity token
                        string authToken = Helper.GetAuthenticityToken(response);

                        if (!string.IsNullOrEmpty(authToken))
                        {

                            string postBody = "utf8=%E2%9C%93&authenticity_token=" + HttpUtility.UrlEncode(authToken) + "&network_permalink=&login=" +
                                iusr + "&password=" + ipwd + "&remember_me=on";

                            //make the first post for code
                            postResults = Helper.MakePostRequest(postBody,authurl1,"POST" );

                            //get the next auth token that was returned and can be used to get an access code
                            string preCodeToken = Helper.GetAuthenticityToken(postResults);


                            response = Helper.MakeGetRequest(permUrl, string.Empty, true);

                        }

                        //now look for the query string
                        qsCode = Constants.wResp.ResponseUri.Query;
                    }

                    if (qsCode.IndexOf("code") > -1)
                    {
                        string accessCode = qsCode.Substring(qsCode.IndexOf("=") + 1);

                        response = Helper.MakeGetRequest( accesstokenurl + accessCode);

                        if (!string.IsNullOrEmpty(response))
                        {
                            TokenResponse tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(response);
                            if (!string.IsNullOrEmpty(tokenResponse.AccessToken.Token))
                                accessToken = tokenResponse.AccessToken.Token;
                         
                        }
                    }
                }




                //close our response object
                Constants.wResp.Close();


            }
            catch (Exception ex)
            {
                throw ex;

            }
            return accessToken;
        }


    }
}
