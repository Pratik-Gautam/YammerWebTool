


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Messages;

namespace YammerSDK.Messages
{

    public class Meta
    {

        [JsonProperty("older_available")]
        public bool OlderAvailable { get; set; }

        [JsonProperty("requested_poll_interval")]
        public int RequestedPollInterval { get; set; }

        [JsonProperty("realtime")]
        public Realtime Realtime { get; set; }

        [JsonProperty("last_seen_message_id")]
        public object LastSeenMessageId { get; set; }

        [JsonProperty("current_user_id")]
        public int CurrentUserId { get; set; }

        [JsonProperty("followed_user_ids")]
        public int[] FollowedUserIds { get; set; }

        [JsonProperty("followed_references")]
        public object[] FollowedReferences { get; set; }

        [JsonProperty("ymodules")]
        public object[] Ymodules { get; set; }

        [JsonProperty("feed_name")]
        public string FeedName { get; set; }

        [JsonProperty("feed_desc")]
        public string FeedDesc { get; set; }

        [JsonProperty("direct_from_body")]
        public bool DirectFromBody { get; set; }
    }

}
