using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.style;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.igetui.template
{
    public class LinkTemplate : AbstractTemplate
    {
        private string text;

        private string title;

        private string logo = "";

        private string logoURL = "";

        private string url;

        private bool isRing = true;

        private bool isVibrate = true;

        private bool isClearable = true;

        private AbstractNotifyStyle style;

        private int notifyStyle;

        private int? notifyid;

        public bool IsRing
        {
            get
            {
                return this.isRing;
            }
            set
            {
                this.isRing = value;
            }
        }

        public bool IsVibrate
        {
            get
            {
                return this.isVibrate;
            }
            set
            {
                this.isVibrate = value;
            }
        }

        public bool IsClearable
        {
            get
            {
                return this.isClearable;
            }
            set
            {
                this.isClearable = value;
            }
        }

        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                this.text = value;
            }
        }

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

        public string Logo
        {
            get
            {
                return this.logo;
            }
            set
            {
                this.logo = value;
            }
        }

        public string LogoURL
        {
            get
            {
                return this.logoURL;
            }
            set
            {
                this.logoURL = value;
            }
        }

        public string Url
        {
            get
            {
                return this.url;
            }
            set
            {
                this.url = value;
            }
        }

        public void setNotifyid(int? notifyid)
        {
            if (notifyid < 0)
            {
                throw new Exception("notifyid need greater than 0");
            }
            if (!base.getPushInfoBuilder().InvalidAPN)
            {
                string apnJson = base.getPushInfoBuilder().ApnJson;
                Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(apnJson);
                if (string.IsNullOrEmpty((string)dictionary["apns-collapse-id"]))
                {
                    dictionary.Add("apns-collapse-id", notifyid);
                    string apnJson2 = JsonConvert.SerializeObject(dictionary);
                    base.getPushInfoBuilder().SetApnJson(apnJson2);
                }
            }
            this.notifyid = notifyid;
        }

        public override List<ActionChain> getActionChain()
        {
            List<ActionChain> arg_31B_0 = new List<ActionChain>();
            ActionChain item = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.Goto).SetNext(10000).Build();
            ActionChain item2 = (this.style == null) ? ActionChain.CreateBuilder().SetActionId(10000).SetType(ActionChain.Types.Type.mmsinbox2).SetStype("notification").AddField(InnerFiled.CreateBuilder().SetKey("notifyid").SetVal((!this.notifyid.HasValue) ? "" : this.notifyid.ToString()).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("title").SetVal(this.title).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("text").SetVal(this.text).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(this.logo).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo_url").SetVal(this.logoURL).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("notifyStyle").SetVal(this.notifyStyle.ToString()).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noring").SetVal((!this.isRing).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noclear").SetVal((!this.isClearable).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_novibrate").SetVal((!this.isVibrate).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).SetNext(10010).Build() : this.style.getActionChain().ToBuilder().AddField(InnerFiled.CreateBuilder().SetKey("notifyid").SetVal((!this.notifyid.HasValue) ? "" : this.notifyid.ToString()).SetType(InnerFiled.Types.Type.str).Build()).Build();
            ActionChain item3 = ActionChain.CreateBuilder().SetActionId(10010).SetType(ActionChain.Types.Type.Goto).SetNext(10030).Build();
            ActionChain item4 = ActionChain.CreateBuilder().SetActionId(10030).SetType(ActionChain.Types.Type.startweb).SetUrl(this.url).SetNext(100).Build();
            ActionChain item5 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
            arg_31B_0.Add(item);
            arg_31B_0.Add(item2);
            arg_31B_0.Add(item3);
            arg_31B_0.Add(item4);
            arg_31B_0.Add(item5);
            return arg_31B_0;
        }

        public override string getPushType()
        {
            return "NotifyMsg";
        }

        protected override int getTemplateId()
        {
            return 1;
        }
    }
}
