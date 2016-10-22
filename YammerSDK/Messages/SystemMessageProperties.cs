


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Messages;

namespace YammerSDK.Messages
{

    public class SystemMessageProperties
    {

        [JsonProperty("subtype")]
        public string Subtype { get; set; }
    }

}
