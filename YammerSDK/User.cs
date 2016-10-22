


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Users;



namespace YammerSDK
{
    public  class User
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("network_id")]
        public int NetworkId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("guid")]
        public object Guid { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("significant_other")]
        public string SignificantOther { get; set; }

        [JsonProperty("kids_names")]
        public string KidsNames { get; set; }

        [JsonProperty("interests")]
        public string Interests { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("expertise")]
        public string Expertise { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("activated_at")]
        public string ActivatedAt { get; set; }

        [JsonProperty("show_ask_for_photo")]
        public bool ShowAskForPhoto { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("network_name")]
        public string NetworkName { get; set; }

        [JsonProperty("network_domains")]
        public object[] NetworkDomains { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mugshot_url")]
        public string MugshotUrl { get; set; }

        [JsonProperty("mugshot_url_template")]
        public string MugshotUrlTemplate { get; set; }

        [JsonProperty("hire_date")]
        public object HireDate { get; set; }

        [JsonProperty("birth_date")]
        public string BirthDate { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("external_urls")]
        public object[] ExternalUrls { get; set; }

        [JsonProperty("admin")]
        public string Admin { get; set; }

        [JsonProperty("verified_admin")]
        public string VerifiedAdmin { get; set; }

        [JsonProperty("can_broadcast")]
        public string CanBroadcast { get; set; }

        [JsonProperty("department")]
        public object Department { get; set; }

        [JsonProperty("previous_companies")]
        public object[] PreviousCompanies { get; set; }

        [JsonProperty("schools")]
        public object[] Schools { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("canonical_network_name")]
        public string CanonicalNetworkName { get; set; }

        [JsonProperty("web_preferences")]
        public WebPreferences WebPreferences { get; set; }

        [JsonProperty("follow_general_messages")]
        public bool FollowGeneralMessages { get; set; }

        [JsonProperty("web_oauth_access_token")]
        public string WebOauthAccessToken { get; set; }

        public User() {
       
        }

    }

}
