using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.utils
{
    public static class ApnsUtils
    {
        public class Payload
        {
            private static string APS = "aps";

            private Dictionary<string, object> paramss;

            private string alert;

            private int badge;

            private string sound = "";

            private string alertBody;

            private string alertActionLocKey;

            private string alertLocKey;

            private string[] alertLocArgs;

            private string alertLaunchImage;

            private int contentAvailable;

            public Dictionary<string, object> Paramss
            {
                get
                {
                    return this.paramss;
                }
                set
                {
                    this.paramss = value;
                }
            }

            public string Alert
            {
                get
                {
                    return this.alert;
                }
                set
                {
                    this.alert = value;
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
                    this.badge = value;
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
                    this.sound = value;
                }
            }

            public string AlertBody
            {
                get
                {
                    return this.alertBody;
                }
                set
                {
                    this.alertBody = value;
                }
            }

            public string AlertActionLocKey
            {
                get
                {
                    return this.alertActionLocKey;
                }
                set
                {
                    this.alertActionLocKey = value;
                }
            }

            public string AlertLocKey
            {
                get
                {
                    return this.alertLocKey;
                }
                set
                {
                    this.alertLocKey = value;
                }
            }

            public string[] AlertLocArgs
            {
                get
                {
                    return this.alertLocArgs;
                }
                set
                {
                    this.alertLocArgs = value;
                }
            }

            public string AlertLaunchImage
            {
                get
                {
                    return this.alertLaunchImage;
                }
                set
                {
                    this.alertLaunchImage = value;
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
                    this.contentAvailable = value;
                }
            }

            public void addParam(string key, object obj)
            {
                if (this.paramss == null)
                {
                    this.paramss = new Dictionary<string, object>();
                }
                if (ApnsUtils.Payload.APS.Equals(key.ToLower()))
                {
                    throw new Exception("the key can't be aps");
                }
                this.paramss.Add(key, obj);
            }

            public override string ToString()
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
                if (this.Alert != null)
                {
                    dictionary2.Add("alert", this.Alert);
                }
                else if (this.AlertBody != null || this.AlertLocKey != null)
                {
                    Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
                    this.putIntoJson("body", this.AlertBody, dictionary3);
                    this.putIntoJson("action-loc-key", this.AlertActionLocKey, dictionary3);
                    this.putIntoJson("loc-key", this.AlertLocKey, dictionary3);
                    this.putIntoJson("launch-image", this.AlertLaunchImage, dictionary3);
                    if (this.AlertLocArgs != null)
                    {
                        List<string> list = new List<string>();
                        string[] array = this.AlertLocArgs;
                        for (int i = 0; i < array.Length; i++)
                        {
                            string item = array[i];
                            list.Add(item);
                        }
                        dictionary3.Add("loc-args", list);
                    }
                    dictionary2.Add("alert", dictionary3);
                }
                dictionary2.Add("badge", this.Badge);
                if (!"com.gexin.ios.silence".Equals(this.Sound))
                {
                    this.putIntoJson("sound", this.Sound, dictionary2);
                }
                if (this.contentAvailable == 1)
                {
                    dictionary2.Add("content-available", this.ContentAvailable);
                }
                dictionary.Add(ApnsUtils.Payload.APS, dictionary2);
                if (this.Paramss != null)
                {
                    foreach (KeyValuePair<string, object> current in this.Paramss)
                    {
                        dictionary.Add(current.Key, current.Value);
                    }
                }
                string result;
                try
                {
                    result = JsonConvert.SerializeObject(dictionary);
                }
                catch (Exception innerException)
                {
                    throw new Exception("build apn payload json error", innerException);
                }
                return result;
            }

            private void putIntoJson(string key, string value, Dictionary<string, object> obj)
            {
                if (value != null)
                {
                    obj.Add(key, value);
                }
            }
        }

        public static int validatePayloadLength(string locKey, string locArgs, string message, string actionLocKey, string launchImage, string badge, string sound, string payload, int contentAvailable)
        {
            string s = ApnsUtils.processPayload(locKey, locArgs, message, actionLocKey, launchImage, badge, sound, payload, contentAvailable);
            int result;
            try
            {
                result = Encoding.UTF8.GetBytes(s).Length;
            }
            catch (Exception innerException)
            {
                throw new Exception("payload json get bytese error", innerException);
            }
            return result;
        }

        public static bool validatePayload(string locKey, string locArgs, string message, string actionLocKey, string launchImage, string badge, string sound, string payload, int contentAvailable)
        {
            return ApnsUtils.validatePayloadLength(locKey, locArgs, message, actionLocKey, launchImage, badge, sound, payload, contentAvailable) <= 256;
        }

        private static string processPayload(string locKey, string locArgs, string message, string actionLocKey, string launchImage, string badge, string sound, string payload, int contentAvailable)
        {
            bool flag = false;
            ApnsUtils.Payload payload2 = new ApnsUtils.Payload();
            if (locKey != null && locKey.Length > 0)
            {
                payload2.AlertLocKey = locKey;
                if (locArgs != null && locArgs.Length > 0)
                {
                    payload2.AlertLocArgs = locArgs.Split(new char[]
                    {
                        ','
                    });
                }
                flag = true;
            }
            if (message != null && message.Length > 0)
            {
                payload2.AlertBody = message;
                flag = true;
            }
            if (actionLocKey != null && actionLocKey.Length > 0)
            {
                payload2.AlertActionLocKey = actionLocKey;
            }
            if (launchImage != null && launchImage.Length > 0)
            {
                payload2.AlertLaunchImage = launchImage;
            }
            int num = -1;
            try
            {
                num = int.Parse(badge);
            }
            catch (Exception innerException)
            {
                throw new Exception("unBindAlias失败 {0}", innerException);
            }
            if (num >= 0)
            {
                payload2.Badge = num;
                flag = true;
            }
            if (!string.IsNullOrEmpty(sound))
            {
                payload2.Sound = sound;
            }
            else
            {
                payload2.Sound = "default";
            }
            if (!string.IsNullOrEmpty(payload))
            {
                payload2.addParam("payload", payload);
            }
            if (contentAvailable == 1)
            {
                payload2.ContentAvailable = 1;
            }
            if (!flag)
            {
                throw new Exception("one of the params(locKey,message,badge) must not be null or contentAvailable must be 1");
            }
            string expr_F8 = payload2.ToString();
            if (expr_F8 == null)
            {
                throw new Exception("payload json is null");
            }
            return expr_F8;
        }
    }
}
