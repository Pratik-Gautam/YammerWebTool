

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Messages;

namespace YammerSDK
{

    public class RootMessages
    {

        [JsonProperty("threaded_extended")]
        public ThreadedExtended ThreadedExtended { get; set; }

        [JsonProperty("messages")]
        public Message[] Messages { get; set; }

        [JsonProperty("references")]
        public Reference[] References { get; set; }

        [JsonProperty("meta")]
        public  Meta Meta { get; set; }

     
    }

}
