


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Users;

namespace YammerSDK.Users
{
    public class NetworkSettings
    {

        [JsonProperty("message_prompt")]
        public string MessagePrompt { get; set; }

        [JsonProperty("allow_attachments")]
        public string AllowAttachments { get; set; }

        [JsonProperty("show_communities_directory")]
        public bool ShowCommunitiesDirectory { get; set; }

        [JsonProperty("enable_groups")]
        public bool EnableGroups { get; set; }

        [JsonProperty("allow_yammer_apps")]
        public bool AllowYammerApps { get; set; }

        [JsonProperty("admin_can_delete_messages")]
        public string AdminCanDeleteMessages { get; set; }

        [JsonProperty("allow_inline_document_view")]
        public bool AllowInlineDocumentView { get; set; }

        [JsonProperty("allow_inline_video")]
        public bool AllowInlineVideo { get; set; }

        [JsonProperty("enable_private_messages")]
        public bool EnablePrivateMessages { get; set; }

        [JsonProperty("allow_external_sharing")]
        public bool AllowExternalSharing { get; set; }

        [JsonProperty("enable_chat")]
        public bool EnableChat { get; set; }
    }

}
