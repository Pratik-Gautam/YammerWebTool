﻿


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Notifications;

namespace YammerSDK.Notifications
{

    public class PhoneNumber
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }
    }

}
