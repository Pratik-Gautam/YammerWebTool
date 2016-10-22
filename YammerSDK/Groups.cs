
using Newtonsoft.Json;
using YammerSDK.Users;

namespace YammerSDK
{

    public class Groups
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("privacy")]
        public string Privacy { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("mugshot_url")]
        public string MugshotUrl { get; set; }

        [JsonProperty("mugshot_url_template")]
        public string MugshotUrlTemplate { get; set; }

        [JsonProperty("mugshot_id")]
        public string MugshotId { get; set; }

        [JsonProperty("office365_url")]
        public object Office365Url { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("show_in_directory")]
        public string ShowInDirectory { get; set; }

        [JsonProperty("creator_type")]
        public string CreatorType { get; set; }

        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        public Groups() { }
    }

}
