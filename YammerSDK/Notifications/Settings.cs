﻿


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Notifications;

namespace YammerSDK.Notifications
{

    public class Settings
    {

        [JsonProperty("xdr_proxy")]
        public string XdrProxy { get; set; }
    }

}
