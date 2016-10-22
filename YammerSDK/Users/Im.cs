


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Users;


namespace YammerSDK.Users
{
    public class Im
    {

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

}
