


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Messages;

namespace YammerSDK.Messages
{

    public class Ymodule
    {

        [JsonProperty("web_app_id")]
        public string WebAppId { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }
    }

}
