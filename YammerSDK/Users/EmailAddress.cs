﻿


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Users;

namespace YammerSDK.Users
{
    public class EmailAddress
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

}
