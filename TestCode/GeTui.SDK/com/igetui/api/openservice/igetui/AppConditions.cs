using System;
using System.Collections.Generic;

namespace com.igetui.api.openservice.igetui
{
    public class AppConditions
    {
        public enum OptType
        {
            or,
            and,
            not
        }

        public static string PHONE_TYPE = "phoneType";

        public static string REGION = "region";

        public static string TAG = "tag";

        private List<Dictionary<string, object>> condition = new List<Dictionary<string, object>>();

        public AppConditions addCondition(string key, List<string> values, int optType)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("key", key);
            dictionary.Add("values", values);
            dictionary.Add("optType", optType);
            this.condition.Add(dictionary);
            return this;
        }

        public AppConditions addCondition(string key, List<string> values, AppConditions.OptType optType)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("key", key);
            dictionary.Add("values", values);
            dictionary.Add("optType", optType);
            this.condition.Add(dictionary);
            return this;
        }

        public AppConditions addCondition(string key, List<string> values)
        {
            return this.addCondition(key, values, 0);
        }

        public List<Dictionary<string, object>> getCondition()
        {
            return this.condition;
        }
    }
}
