using System;
using System.Collections.Generic;

namespace com.igetui.api.openservice.payload
{
    public class DictionaryAlertMsg : AlertMsg
    {
        private string title;

        private string body;

        private string titleLocKey;

        private List<string> titleLocArgs = new List<string>();

        private string actionLocKey;

        private string locKey;

        private List<string> locArgs = new List<string>();

        private string launchImage;

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public string Body
        {
            get
            {
                return this.body;
            }
            set
            {
                this.body = value;
            }
        }

        public string TitleLocKey
        {
            get
            {
                return this.titleLocKey;
            }
            set
            {
                this.titleLocKey = value;
            }
        }

        public List<string> TitleLocArgs
        {
            get
            {
                return this.titleLocArgs;
            }
            set
            {
                this.titleLocArgs = value;
            }
        }

        public string ActionLocKey
        {
            get
            {
                return this.actionLocKey;
            }
            set
            {
                this.actionLocKey = value;
            }
        }

        public string LocKey
        {
            get
            {
                return this.locKey;
            }
            set
            {
                this.locKey = value;
            }
        }

        public List<string> LocArgs
        {
            get
            {
                return this.locArgs;
            }
            set
            {
                this.locArgs = value;
            }
        }

        public string LaunchImage
        {
            get
            {
                return this.launchImage;
            }
            set
            {
                this.launchImage = value;
            }
        }

        public void addTitleLocArg(string titleLocArg)
        {
            if (!string.IsNullOrEmpty(titleLocArg))
            {
                this.titleLocArgs.Add(titleLocArg);
            }
        }

        public void addLocArg(string locArg)
        {
            if (!string.IsNullOrEmpty(locArg))
            {
                this.locArgs.Add(locArg);
            }
        }

        public object getAlertMsg()
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            if (DictionaryAlertMsg.isNotEmpty(this.title))
            {
                dictionary.Add("title", this.title);
            }
            if (DictionaryAlertMsg.isNotEmpty(this.body))
            {
                dictionary.Add("body", this.body);
            }
            if (DictionaryAlertMsg.isNotEmpty(this.titleLocKey))
            {
                dictionary.Add("title-loc-key", this.titleLocKey);
            }
            if (DictionaryAlertMsg.isNotEmpty(this.titleLocArgs))
            {
                dictionary.Add("title-loc-args", this.titleLocArgs);
            }
            if (DictionaryAlertMsg.isNotEmpty(this.actionLocKey))
            {
                dictionary.Add("action-loc-key", this.actionLocKey);
            }
            if (DictionaryAlertMsg.isNotEmpty(this.locKey))
            {
                dictionary.Add("loc-key", this.locKey);
            }
            if (DictionaryAlertMsg.isNotEmpty(this.locArgs))
            {
                dictionary.Add("loc-args", this.locArgs);
            }
            if (DictionaryAlertMsg.isNotEmpty(this.launchImage))
            {
                dictionary.Add("launch-image", this.launchImage);
            }
            return dictionary;
        }

        private static bool isNotEmpty(object item)
        {
            return item != null && ((item is string && (string)item != "") || (item is Array && ((Array)item).Length > 0) || (item is List<string> && ((List<string>)item).Count > 0) || (item is Dictionary<string, object> && ((Dictionary<string, object>)item).Count > 0));
        }
    }
}
