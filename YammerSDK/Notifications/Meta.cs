


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Notifications;

namespace YammerSDK.Notifications
{

    public class Meta
    {

        [JsonProperty("ymodules")]
        public object[] Ymodules { get; set; }

        [JsonProperty("followed_references")]
        public FollowedReference[] FollowedReferences { get; set; }

        [JsonProperty("older_available")]
        public bool OlderAvailable { get; set; }

        [JsonProperty("requested_poll_interval")]
        public int RequestedPollInterval { get; set; }

        [JsonProperty("followed_user_ids")]
        public int[] FollowedUserIds { get; set; }
    }

}
