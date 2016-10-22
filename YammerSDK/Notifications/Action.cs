


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Notifications;

namespace YammerSDK.Notifications
{

    public class Action
    {

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("decoration")]
        public string Decoration { get; set; }

        [JsonProperty("action")]
        public Action2 Actionn2 { get; set; }
    }

}
