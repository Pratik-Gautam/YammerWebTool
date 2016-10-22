


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Notifications;

namespace YammerSDK.Notifications
{

    public class Stats2
    {

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

}
