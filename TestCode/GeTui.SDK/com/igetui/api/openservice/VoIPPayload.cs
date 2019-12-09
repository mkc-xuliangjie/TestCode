using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace com.igetui.api.openservice
{
    public class VoIPPayload : Payload
    {
        public string voIPPayload
        {
            get;
            set;
        }

        public string getPayload()
        {
            string voIPPayload = this.voIPPayload;
            if (string.IsNullOrEmpty(voIPPayload))
            {
                throw new Exception("payload cannot be empty");
            }
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("payload", voIPPayload);
            dictionary.Add("isVoIP", 1);
            return JsonConvert.SerializeObject(dictionary);
        }
    }
}
