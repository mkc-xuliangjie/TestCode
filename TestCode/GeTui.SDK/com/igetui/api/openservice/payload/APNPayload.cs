using GetuiServerApiSDK_Core.payload;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using com.igetui.api.openservice.utils;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.payload
{
    public class APNPayload : ApnsUtils.Payload
    {
        public const string APN_SOUND_SILENCE = "com.gexin.ios.silence";

        public const int PAYLOAD_MAX_BYTES = 2048;

        private int voicePlayType;

        private string voicePlayMessage;

        private string apnsCollapseId;

        private List<MultiMedia> multiMedias = new List<MultiMedia>();

        private Dictionary<string, object> customMsg = new Dictionary<string, object>();

        private int badge = -1;

        private string sound = "default";

        private int contentAvailable;

        private string category;

        private string autoBadge;

        private AlertMsg alertMsg;

        public int VoicePlayType
        {
            get
            {
                return this.voicePlayType;
            }
            set
            {
                this.voicePlayType = value;
            }
        }

        public string VoicePlayMessage
        {
            get
            {
                return this.voicePlayMessage;
            }
            set
            {
                this.voicePlayMessage = value;
            }
        }

        public Dictionary<string, object> CustomMsg
        {
            get
            {
                return this.customMsg;
            }
            set
            {
                this.customMsg = value;
            }
        }

        public int Badge
        {
            get
            {
                return this.badge;
            }
            set
            {
                if (value > 0)
                {
                    this.badge = value;
                }
            }
        }

        public string Sound
        {
            get
            {
                return this.sound;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.sound = "default";
                    return;
                }
                this.sound = value;
            }
        }

        public int ContentAvailable
        {
            get
            {
                return this.contentAvailable;
            }
            set
            {
                if (value > 0)
                {
                    this.contentAvailable = value;
                }
            }
        }

        public string Category
        {
            get
            {
                return this.category;
            }
            set
            {
                this.category = value;
            }
        }

        public AlertMsg AlertMsg
        {
            get
            {
                return this.alertMsg;
            }
            set
            {
                this.alertMsg = value;
            }
        }

        public List<MultiMedia> MultiMedias
        {
            get
            {
                return this.multiMedias;
            }
            set
            {
                this.multiMedias = value;
            }
        }

        public string getApnsCollapseId()
        {
            return this.apnsCollapseId;
        }

        public void addCustomMsg(string key, object value)
        {
            if (!string.IsNullOrEmpty(key) && value != null)
            {
                this.customMsg.Add(key, value);
            }
        }

        public string getAutoBadge()
        {
            return this.autoBadge;
        }

        public APNPayload setAutoBadge(string autoBadge)
        {
            Match match = Regex.Match(autoBadge, "^(-|\\+)?\\d+$");
            if (autoBadge == null || !match.Success)
            {
                throw new Exception("autoBadge invalid");
            }
            this.autoBadge = autoBadge;
            return this;
        }

        public string getPayload()
        {
            string result;
            try
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                if (this.alertMsg != null && APNPayload.isNotEmpty(this.alertMsg.getAlertMsg()))
                {
                    dictionary.Add("alert", this.alertMsg.getAlertMsg());
                }
                if (this.autoBadge != null)
                {
                    dictionary.Add("autoBadge", this.autoBadge);
                }
                else if (this.badge >= 0)
                {
                    dictionary.Add("badge", this.badge);
                }
                if ("com.gexin.ios.silence" != this.sound)
                {
                    dictionary.Add("sound", this.sound);
                }
                if (!APNPayload.isNotEmpty(dictionary))
                {
                    throw new Exception("format error");
                }
                if (this.contentAvailable > 0)
                {
                    dictionary.Add("content-available", this.contentAvailable);
                }
                if (APNPayload.isNotEmpty(this.category))
                {
                    dictionary.Add("category", this.category);
                }
                Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
                foreach (KeyValuePair<string, object> current in this.customMsg)
                {
                    dictionary2.Add(current.Key, current.Value);
                }
                dictionary2.Add("aps", dictionary);
                if (this.apnsCollapseId != null)
                {
                    dictionary2.Add("apns-collapse-id", this.apnsCollapseId);
                }
                if (this.multiMedias != null && this.multiMedias.Count > 0)
                {
                    dictionary2.Add("_grinfo_", this.checkMultiMedias());
                }
                if (this.voicePlayType == 1)
                {
                    dictionary2.Add("_gvp_t_", 1);
                }
                else if (this.voicePlayType == 2 && string.IsNullOrEmpty(this.voicePlayMessage))
                {
                    dictionary2.Add("_gvp_t_", 2);
                    dictionary2.Add("_gvp_m_", this.voicePlayMessage);
                }
                result = JsonConvert.SerializeObject(dictionary2);
            }
            catch (Exception innerException)
            {
                throw new Exception("create apn payload error", innerException);
            }
            return result;
        }

        public void setApnsCollapseId(string apnsCollapseId)
        {
            if (!string.IsNullOrEmpty(apnsCollapseId))
            {
                this.apnsCollapseId = apnsCollapseId;
            }
        }

        private List<MultiMedia> checkMultiMedias()
        {
            if (this.multiMedias.Count > 3)
            {
                throw new Exception("MultiMedias size overlimit");
            }
            bool flag = false;
            HashSet<string> hashSet = new HashSet<string>();
            foreach (MultiMedia current in this.multiMedias)
            {
                if (current.rid == null)
                {
                    flag = true;
                }
                else
                {
                    hashSet.Add(current.rid);
                }
                bool flag2 = false;
                foreach (MultiMedia.MediaType mediaType in Enum.GetValues(typeof(MultiMedia.MediaType)))
                {
                    if (mediaType.Equals(current.type))
                    {
                        flag2 = true;
                    }
                }
                if (!flag2 || current.url == null)
                {
                    throw new Exception("MultiMedia resType and resUrl can't be null");
                }
            }
            if (hashSet.Count != this.multiMedias.Count)
            {
                flag = true;
            }
            int num = 0;
            if (flag)
            {
                using (List<MultiMedia>.Enumerator enumerator = this.multiMedias.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        enumerator.Current.rid = "grid-" + num++;
                    }
                }
            }
            return this.multiMedias;
        }

        private static bool isNotEmpty(object item)
        {
            return item != null && ((item is string && (string)item != "") || (item is Array && ((Array)item).Length > 0) || (item is List<string> && ((List<string>)item).Count > 0) || (item is Dictionary<string, object> && ((Dictionary<string, object>)item).Count > 0));
        }
    }
}
