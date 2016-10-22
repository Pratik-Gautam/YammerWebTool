


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Users;

namespace YammerSDK.Users
{
    public class HomeTab
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("select_name")]
        public string SelectName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("feed_description")]
        public string FeedDescription { get; set; }

        [JsonProperty("ordering_index")]
        public string OrderingIndex { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("group_id")]
        public int? GroupId { get; set; }

        [JsonProperty("private")]
        public bool? Private { get; set; }
    }

}
