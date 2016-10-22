


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Users;

namespace YammerSDK.Users
{
    public class Stats
    {

        [JsonProperty("following")]
        public int Following { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }

        [JsonProperty("updates")]
        public int Updates { get; set; }
    }

}
