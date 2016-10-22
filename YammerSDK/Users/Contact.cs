


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YammerSDK.Users;

namespace YammerSDK.Users
{
    public class Contact
    {

        [JsonProperty("im")]
        public Im Im { get; set; }

        [JsonProperty("phone_numbers")]
        public PhoneNumber[] PhoneNumbers { get; set; }

        [JsonProperty("email_addresses")]
        public EmailAddress[] EmailAddresses { get; set; }

        [JsonProperty("has_fake_email")]
        public bool HasFakeEmail { get; set; }
    }

}
