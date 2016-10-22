

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Networks;

namespace YammerSDK.Networks
{

    public class ProfileFieldsConfig
    {

        [JsonProperty("enable_job_title")]
        public bool EnableJobTitle { get; set; }

        [JsonProperty("enable_work_phone")]
        public bool EnableWorkPhone { get; set; }

        [JsonProperty("enable_mobile_phone")]
        public bool EnableMobilePhone { get; set; }
    }

}
