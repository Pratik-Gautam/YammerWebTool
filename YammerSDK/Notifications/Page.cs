


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Notifications;

namespace YammerSDK.Notifications
{

    public class Page
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("api_preview_url")]
        public string ApiPreviewUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("paddie_host")]
        public string PaddieHost { get; set; }

        [JsonProperty("paddie_id")]
        public string PaddieId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("owner_type")]
        public string OwnerType { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("official")]
        public bool Official { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("last_published_by")]
        public int LastPublishedBy { get; set; }

        [JsonProperty("last_published_at")]
        public string LastPublishedAt { get; set; }

        [JsonProperty("latest_revision")]
        public int LatestRevision { get; set; }

        [JsonProperty("unpublished_contributor_ids")]
        public object[] UnpublishedContributorIds { get; set; }

        [JsonProperty("topics")]
        public object[] Topics { get; set; }

        [JsonProperty("privacy")]
        public string Privacy { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("latest_version")]
        public LatestVersion LatestVersion { get; set; }

        [JsonProperty("stats")]
        public Stats2 Stats { get; set; }
    }

}
