


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Notifications;

namespace YammerSDK.Notifications
{

    public class Objects
    {

        [JsonProperty("message")]
        public Message[] Message { get; set; }

        [JsonProperty("user")]
        public User[] User { get; set; }

        [JsonProperty("page")]
        public Page[] Page { get; set; }
    }

}
