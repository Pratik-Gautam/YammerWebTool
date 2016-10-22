


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Notifications;

namespace YammerSDK.Notifications
{

    public class Reference
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

        [JsonProperty("show_in_directory")]
        public string ShowInDirectory { get; set; }

        [JsonProperty("office365_url")]
        public object Office365Url { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("activated_at")]
        public string ActivatedAt { get; set; }

        [JsonProperty("stats")]
        public Stats3 Stats { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("api_preview_url")]
        public string ApiPreviewUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("group_id")]
        public int? GroupId { get; set; }

        [JsonProperty("paddie_host")]
        public string PaddieHost { get; set; }

        [JsonProperty("paddie_id")]
        public string PaddieId { get; set; }

        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        [JsonProperty("owner_type")]
        public string OwnerType { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("official")]
        public bool? Official { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("last_published_by")]
        public int? LastPublishedBy { get; set; }

        [JsonProperty("last_published_at")]
        public string LastPublishedAt { get; set; }

        [JsonProperty("latest_revision")]
        public int? LatestRevision { get; set; }

        [JsonProperty("unpublished_contributor_ids")]
        public object[] UnpublishedContributorIds { get; set; }

        [JsonProperty("topics")]
        public Topic[] Topics { get; set; }

        [JsonProperty("thread_starter_id")]
        public int? ThreadStarterId { get; set; }

        [JsonProperty("direct_message")]
        public bool? DirectMessage { get; set; }

        [JsonProperty("has_attachments")]
        public bool? HasAttachments { get; set; }

        [JsonProperty("invited_user_ids")]
        public int[] InvitedUserIds { get; set; }

        [JsonProperty("sender_id")]
        public int? SenderId { get; set; }

        [JsonProperty("replied_to_id")]
        public int? RepliedToId { get; set; }

        [JsonProperty("network_id")]
        public int? NetworkId { get; set; }

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

        [JsonProperty("body")]
        public Body3 Body { get; set; }

        [JsonProperty("conversation_id")]
        public int? ConversationId { get; set; }

        [JsonProperty("liked_by")]
        public int? LikedBy { get; set; }

        [JsonProperty("community")]
        public bool? Community { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("show_upgrade_banner")]
        public bool? ShowUpgradeBanner { get; set; }

        [JsonProperty("header_background_color")]
        public string HeaderBackgroundColor { get; set; }

        [JsonProperty("header_text_color")]
        public string HeaderTextColor { get; set; }

        [JsonProperty("navigation_background_color")]
        public string NavigationBackgroundColor { get; set; }

        [JsonProperty("navigation_text_color")]
        public string NavigationTextColor { get; set; }

        [JsonProperty("paid")]
        public bool? Paid { get; set; }

        [JsonProperty("moderated")]
        public bool? Moderated { get; set; }

        [JsonProperty("is_org_chart_enabled")]
        public bool? IsOrgChartEnabled { get; set; }

        [JsonProperty("is_group_enabled")]
        public bool? IsGroupEnabled { get; set; }

        [JsonProperty("is_chat_enabled")]
        public bool? IsChatEnabled { get; set; }

        [JsonProperty("is_translation_enabled")]
        public bool? IsTranslationEnabled { get; set; }

        [JsonProperty("profile_fields_config")]
        public ProfileFieldsConfig ProfileFieldsConfig { get; set; }

        [JsonProperty("participating_users_count")]
        public int? ParticipatingUsersCount { get; set; }

        [JsonProperty("participating_names")]
        public ParticipatingName[] ParticipatingNames { get; set; }
    }

}
