


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Messages;

namespace YammerSDK.Messages
{

    public class Body
    {

        [JsonProperty("parsed")]
        public string Parsed { get; set; }

        [JsonProperty("plain")]
        public string Plain { get; set; }

        [JsonProperty("rich")]
        public string Rich { get; set; }

        [JsonProperty("urls")]
        public string[] Urls { get; set; }
    }

}
