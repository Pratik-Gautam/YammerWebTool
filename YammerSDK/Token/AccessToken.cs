using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YammerSDK.Token
{
    internal class AccessToken
    {
        [JsonProperty("view_subscriptions")]
        public bool ViewSubscriptions { get; set; }

        [JsonProperty("expires_at")]
        public object ExpiresAt { get; set; }

        [JsonProperty("authorized_at")]
        public string AuthorizedAt { get; set; }

        [JsonProperty("modify_subscriptions")]
        public bool ModifySubscriptions { get; set; }

        [JsonProperty("modify_messages")]
        public bool ModifyMessages { get; set; }

        [JsonProperty("network_permalink")]
        public string NetworkPermalink { get; set; }

        [JsonProperty("view_members")]
        public bool ViewMembers { get; set; }

        [JsonProperty("view_tags")]
        public bool ViewTags { get; set; }

        [JsonProperty("network_id")]
        public int NetworkId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("view_groups")]
        public bool ViewGroups { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("network_name")]
        public string NetworkName { get; set; }

        [JsonProperty("view_messages")]
        public bool ViewMessages { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }
}
