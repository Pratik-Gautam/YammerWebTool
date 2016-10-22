


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Messages;

namespace YammerSDK.Messages
{

    public class Name
    {

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }

}
