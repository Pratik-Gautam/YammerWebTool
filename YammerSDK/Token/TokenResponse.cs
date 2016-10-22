using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YammerSDK.Token
{
    internal class TokenResponse
    {
        [JsonProperty("access_token")]
        public  AccessToken AccessToken { get; set; }

        [JsonProperty("user")]
        public User CurrentUser { get; set; }

        [JsonProperty("network")]
        public Network Network { get; set; }
        //missing Network
        public TokenResponse()
        {
            this.AccessToken = new AccessToken();
            this.CurrentUser = new User();
            this.Network = new Network();
        }
    }
}
