﻿


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Messages;

namespace YammerSDK.Messages
{

    public class Body2
    {

        [JsonProperty("plain")]
        public string Plain { get; set; }
    }

}
