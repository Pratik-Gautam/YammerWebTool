


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Notifications;

namespace YammerSDK.Notifications
{

    public class LatestVersion
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("revert_url")]
        public object RevertUrl { get; set; }

        [JsonProperty("published_by")]
        public int PublishedBy { get; set; }

        [JsonProperty("revision_number")]
        public int RevisionNumber { get; set; }

        [JsonProperty("contributors")]
        public int[] Contributors { get; set; }
    }

}
