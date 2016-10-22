


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Notifications;

namespace YammerSDK.Notifications
{

    public class Item
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("unseen")]
        public bool Unseen { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("icon_name")]
        public string IconName { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("heading")]
        public string Heading { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("objects")]
        public Object[] Objects { get; set; }

        [JsonProperty("actions")]
        public Action[] Actions { get; set; }

        [JsonProperty("subject")]
        public Subject Subject { get; set; }

        [JsonProperty("meta")]
        public object Meta { get; set; }

        [JsonProperty("client_type")]
        public string ClientType { get; set; }

        [JsonProperty("client_url")]
        public string ClientUrl { get; set; }

        [JsonProperty("client_icon")]
        public string ClientIcon { get; set; }

        [JsonProperty("client_large_icon")]
        public string ClientLargeIcon { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("third_party")]
        public bool ThirdParty { get; set; }
    }

}
