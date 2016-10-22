


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Notifications;

namespace YammerSDK
{

    public class Notification
    {

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("objects")]
        public Objects Objects { get; set; }

        [JsonProperty("references")]
        public Reference[] References { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

}
