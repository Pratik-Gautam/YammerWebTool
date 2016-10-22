using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YammerSDK.Helpers
{
    public static class Helper
    {
        public static string GetAuthenticityToken(string rawHtml)
        {
            string result = string.Empty;

            try
            {
                int at = rawHtml.IndexOf("<meta name=\"authenticity_token\" id=\"authenticity_token\"");

                if (at > -1)
                {
                    //get the authenticity token string
                    int et = rawHtml.IndexOf("/>", at + 1);
                    string tokenText = rawHtml.Substring(at, et - at);

                    //get the token value
                    int ts = tokenText.IndexOf("content=");
                    int es = tokenText.LastIndexOf("\"");

                    result = tokenText.Substring(ts + 9, es - ts - 9);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetAuthenticityToken: " + ex.Message);
            }

            return result;
        }
        public static string MakePostRequest(string postBody, string url,string method, string authHeader = null, string contentType = null)
        {
            string results = string.Empty;

            try
            {
                //get the session and yamtrack cookie
                SetCookies();

                Constants.wr = WebRequest.CreateHttp(url);
                Constants.wr.Method = method;
                Constants.wr.CookieContainer = Constants.cc;

                //if an authHeader was provided, add it as a Bearer token to the request
                if (!string.IsNullOrEmpty(authHeader))
                    Constants.wr.Headers.Add("Authorization", "Bearer " + authHeader);

                byte[] postByte = Encoding.UTF8.GetBytes(postBody);

                if (string.IsNullOrEmpty(contentType))
                    Constants.wr.ContentType = "application/x-www-form-urlencoded";
                else
                    Constants.wr.ContentType = contentType;

                Constants.wr.ContentLength = postByte.Length;
                Stream postStream = Constants.wr.GetRequestStream();
                postStream.Write(postByte, 0, postByte.Length);
                postStream.Close();

                Constants.wResp = (HttpWebResponse)Constants.wr.GetResponse();
                postStream = Constants.wResp.GetResponseStream();
                StreamReader postReader = new StreamReader(postStream);

                results = postReader.ReadToEnd();

                postReader.Close();
                postStream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in MakePostRequest: " + ex.Message);
            }

            return results;
        }

        public static string MakeGetRequest(string Url, string authHeader = null, bool AddCookies = false)
        {
            string results = string.Empty;

            try
            {
                Constants.wr = WebRequest.CreateHttp(Url);
                Constants.wr.Method = "GET";

                //******************************************************************
                //ADDED 12/17/2013 TO REFLECT CHANGES YAMMER MADE IN AUTH PROCEDURE
                if (AddCookies)
                {
                    SetCookies();
                    Constants.wr.CookieContainer = Constants.cc;
                }
                //******************************************************************                           

                if (!string.IsNullOrEmpty(authHeader))
                    Constants.wr.Headers.Add("Authorization", "Bearer " + authHeader);

                Constants.wResp = (HttpWebResponse)Constants.wr.GetResponse();

                Stream dataStream = Constants.wResp.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                results = reader.ReadToEnd();

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in MakeGetRequest: " + ex.Message);
            }

            return results;
        }

        public static void SetCookies()
        {
            try
            {
                const string YAMTRAK_COOKIE = "yamtrak_id";
                const string SESSION_COOKIE = "_workfeed_session_id";

                //no normalization to Set-Cookie content and Cookies on WebRequest is not populated so 
                //we are doing guesstimating parsing
                //Set-Cookie: yamtrak_id=2f1621f7-7452-4f7e-a974-6a85eb5ca22d; path=/; expires=Fri, 26-Sep-2014 15:20:54 GMT; secure; HttpOnly,_workfeed_session_id=34a53fdeab7da22fc4ae088fb19a2307; path=/; secure; HttpOnly
                string cookies = Constants.wResp.Headers["Set-Cookie"];

                if (string.IsNullOrEmpty(cookies))
                {
                    Constants.cc = new CookieContainer();
                }
                else
                {
                    int cStart = cookies.IndexOf("=");
                    int cEnd = cookies.IndexOf("HttpOnly,");

                    //sometimes the cookie ends with "HttpOnly," and sometimes it ends with "secure"
                    if (
                        (cookies.Substring(cStart + 1, cEnd + 8 - cStart - 1).IndexOf(YAMTRAK_COOKIE) > -1) ||
                         (cookies.Substring(cStart + 1, cEnd + 8 - cStart - 1).IndexOf(SESSION_COOKIE) > -1)
                        )
                    {
                        //change the end to look for secure
                        cEnd = cookies.IndexOf("secure,");
                    }

                    string tempCook1 = cookies.Substring(cStart + 1, cEnd + 8 - cStart - 1);
                    tempCook1 = tempCook1.Remove(tempCook1.IndexOf(";"));

                    cStart = cookies.IndexOf("=", cEnd);
                    string tempCook2 = cookies.Substring(cStart + 1);
                    tempCook2 = tempCook2.Remove(tempCook2.IndexOf(";"));

                    if (cookies.StartsWith("yamtrak"))
                    {
                        Constants.yamtrackCookie = tempCook1;
                        Constants.sessionCookie = tempCook2;
                    }
                    else
                    {
                        Constants.sessionCookie = tempCook1;
                        Constants.yamtrackCookie = tempCook2;
                    }

                    //yamtrackCookie = wResp.Cookies[YAMTRAK_COOKIE].Value;
                    //sessionCookie = wResp.Cookies[SESSION_COOKIE].Value;

                    Constants.cc = new CookieContainer();
                    Constants.cc.Add(new Cookie(YAMTRAK_COOKIE, Constants.yamtrackCookie, "/", "www.yammer.com"));
                    Constants.cc.Add(new Cookie(SESSION_COOKIE, Constants.sessionCookie, "/", "www.yammer.com"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in SetCookies: " + ex.Message);
            }
        }

        public static List<T> PaginatedData<T>(string Url, string accessToken)
        {
            var results = new List<T>();

            try
            {
                //set up paging
                int curPage = 0;
                string response = "start";

                string qsOperator = (Url.IndexOf("?") > -1) ? "&" : "?";

                while (response != "[]")
                {
                    
                    System.Threading.Thread.Sleep(1000);
                    curPage += 1;
                    response = MakeGetRequest(Url + qsOperator + "page=" + curPage, accessToken);
                    List<T> resultSet = JsonConvert.DeserializeObject<List<T>>(response);
                    results.AddRange(resultSet);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return results;
        }

        public static List<T> NoPaginatedData<T>(string Url, string accessToken)
        {
            var results = new List<T>();

            try
            {
                //set up paging
                int curPage = 1;
                string response = "start";

                string qsOperator = (Url.IndexOf("?") > -1) ? "&" : "?";

                

                    System.Threading.Thread.Sleep(1000);
                    
                    response = MakeGetRequest(Url + qsOperator + "page=" + curPage, accessToken);
                    List<T> resultSet = JsonConvert.DeserializeObject<List<T>>(response);
                    results.AddRange(resultSet);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return results;
        } 
    }
}
