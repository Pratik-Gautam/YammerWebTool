

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Users;

namespace YammerSDK.Users
{
    public class WebPreferences
    {

        [JsonProperty("show_full_names")]
        public string ShowFullNames { get; set; }

        [JsonProperty("absolute_timestamps")]
        public string AbsoluteTimestamps { get; set; }

        [JsonProperty("threaded_mode")]
        public string ThreadedMode { get; set; }

        [JsonProperty("network_settings")]
        public NetworkSettings NetworkSettings { get; set; }

        [JsonProperty("home_tabs")]
        public HomeTab[] HomeTabs { get; set; }

        [JsonProperty("enter_does_not_submit_message")]
        public string EnterDoesNotSubmitMessage { get; set; }

        [JsonProperty("preferred_my_feed")]
        public string PreferredMyFeed { get; set; }

        [JsonProperty("prescribed_my_feed")]
        public string PrescribedMyFeed { get; set; }

        [JsonProperty("sticky_my_feed")]
        public bool StickyMyFeed { get; set; }

        [JsonProperty("enable_chat")]
        public string EnableChat { get; set; }

        [JsonProperty("dismissed_feed_tooltip")]
        public bool DismissedFeedTooltip { get; set; }

        [JsonProperty("dismissed_group_tooltip")]
        public bool DismissedGroupTooltip { get; set; }

        [JsonProperty("dismissed_profile_prompt")]
        public bool DismissedProfilePrompt { get; set; }

        [JsonProperty("dismissed_invite_tooltip")]
        public bool DismissedInviteTooltip { get; set; }

        [JsonProperty("dismissed_apps_tooltip")]
        public bool DismissedAppsTooltip { get; set; }

        [JsonProperty("dismissed_invite_tooltip_at")]
        public string DismissedInviteTooltipAt { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("yammer_now_app_id")]
        public int YammerNowAppId { get; set; }

        [JsonProperty("has_yammer_now")]
        public bool HasYammerNow { get; set; }
    }

}
