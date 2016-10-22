


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Messages;

namespace YammerSDK.Messages
{

    public class Stats
    {

        [JsonProperty("following")]
        public int Following { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }

        [JsonProperty("updates")]
        public int Updates { get; set; }

        [JsonProperty("shares")]
        public int? Shares { get; set; }

        [JsonProperty("first_reply_id")]
        public int? FirstReplyId { get; set; }

        [JsonProperty("first_reply_at")]
        public string FirstReplyAt { get; set; }

        [JsonProperty("latest_reply_id")]
        public int? LatestReplyId { get; set; }

        [JsonProperty("latest_reply_at")]
        public string LatestReplyAt { get; set; }
    }

}
