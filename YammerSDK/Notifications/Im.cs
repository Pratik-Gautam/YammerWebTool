


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Notifications;

namespace YammerSDK.Notifications
{

    public class Im
    {

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

}
