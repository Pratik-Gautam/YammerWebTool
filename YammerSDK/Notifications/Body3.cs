


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Notifications;

namespace YammerSDK.Notifications
{

    public class Body3
    {

        [JsonProperty("plain")]
        public string Plain { get; set; }

        [JsonProperty("parsed")]
        public string Parsed { get; set; }

        [JsonProperty("rich")]
        public string Rich { get; set; }
    }

}
