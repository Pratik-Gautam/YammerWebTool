


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Messages;

namespace YammerSDK.Messages
{

    public class Attachment
    {

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("record_id")]
        public object RecordId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("object_type")]
        public string ObjectType { get; set; }

        [JsonProperty("object_name")]
        public string ObjectName { get; set; }

        [JsonProperty("host_url")]
        public string HostUrl { get; set; }

        [JsonProperty("inline_url")]
        public string InlineUrl { get; set; }

        [JsonProperty("inline_html")]
        public string InlineHtml { get; set; }

        [JsonProperty("ymodule")]
        public Ymodule Ymodule { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("content_class")]
        public string ContentClass { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        [JsonProperty("owner_type")]
        public string OwnerType { get; set; }

        [JsonProperty("official")]
        public bool? Official { get; set; }

        [JsonProperty("small_icon_url")]
        public string SmallIconUrl { get; set; }

        [JsonProperty("large_icon_url")]
        public string LargeIconUrl { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("large_preview_url")]
        public string LargePreviewUrl { get; set; }

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("last_uploaded_at")]
        public string LastUploadedAt { get; set; }

        [JsonProperty("last_uploaded_by_id")]
        public int? LastUploadedById { get; set; }

        [JsonProperty("last_uploaded_by_type")]
        public string LastUploadedByType { get; set; }

        [JsonProperty("uuid")]
        public object Uuid { get; set; }

        [JsonProperty("transcoded")]
        public object Transcoded { get; set; }

        [JsonProperty("streaming_url")]
        public object StreamingUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("y_id")]
        public int? YId { get; set; }

        [JsonProperty("overlay_url")]
        public string OverlayUrl { get; set; }

        [JsonProperty("privacy")]
        public string Privacy { get; set; }

        [JsonProperty("group_id")]
        public int? GroupId { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("scaled_url")]
        public string ScaledUrl { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("real_type")]
        public string RealType { get; set; }
    }

}
