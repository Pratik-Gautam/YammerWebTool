


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Messages;

namespace YammerSDK.Messages
{

    public class Reference
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("mugshot_url")]
        public string MugshotUrl { get; set; }

        [JsonProperty("mugshot_url_template")]
        public string MugshotUrlTemplate { get; set; }

        [JsonProperty("activated_at")]
        public string ActivatedAt { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("sender_id")]
        public int? SenderId { get; set; }

        [JsonProperty("replied_to_id")]
        public int? RepliedToId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("network_id")]
        public int? NetworkId { get; set; }

        [JsonProperty("group_id")]
        public int? GroupId { get; set; }

        [JsonProperty("sender_type")]
        public string SenderType { get; set; }

        [JsonProperty("thread_id")]
        public int? ThreadId { get; set; }

        [JsonProperty("message_type")]
        public string MessageType { get; set; }

        [JsonProperty("system_message")]
        public bool? SystemMessage { get; set; }

        [JsonProperty("content_excerpt")]
        public string ContentExcerpt { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("privacy")]
        public string Privacy { get; set; }

        [JsonProperty("direct_message")]
        public bool? DirectMessage { get; set; }

        [JsonProperty("body")]
        public Body2 Body { get; set; }

        [JsonProperty("thread_starter_id")]
        public int? ThreadStarterId { get; set; }

        [JsonProperty("topics")]
        public Topic[] Topics { get; set; }

        [JsonProperty("has_attachments")]
        public bool? HasAttachments { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mugshot_id")]
        public string MugshotId { get; set; }

        [JsonProperty("office365_url")]
        public object Office365Url { get; set; }

        [JsonProperty("show_in_directory")]
        public string ShowInDirectory { get; set; }

        [JsonProperty("normalized_name")]
        public string NormalizedName { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }
    }

}
