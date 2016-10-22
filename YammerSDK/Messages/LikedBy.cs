


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Messages;

namespace YammerSDK.Messages
{

    public class LikedBy
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("names")]
        public Name[] Names { get; set; }
    }

}
