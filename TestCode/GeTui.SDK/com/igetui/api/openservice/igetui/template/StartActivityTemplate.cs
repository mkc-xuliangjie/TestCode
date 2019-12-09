using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.style;
using com.igetui.api.openservice.payload;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.igetui.template
{
    public class StartActivityTemplate : AbstractTemplate
    {
        private string intent;

        private int? notifyid;

        private string pattern = "^(intent:).*(;end)$";

        private AbstractNotifyStyle style;

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

        public new void setAPNInfo(Payload apn)
        {
            if (apn is APNPayload)
            {
                APNPayload aPNPayload = (APNPayload)apn;
                if (this.notifyid.HasValue && string.IsNullOrEmpty(aPNPayload.getApnsCollapseId()))
                {
                    aPNPayload.setApnsCollapseId(this.notifyid.ToString());
                }
            }
            base.setAPNInfo(apn);
        }

        public override string getPushType()
        {
            return "StartActivity";
        }

        public override List<ActionChain> getActionChain()
        {
            List<ActionChain> arg_138_0 = new List<ActionChain>();
            ActionChain item = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.Goto).SetNext(10000).Build();
            ActionChain item2 = this.style.getActionChain().ToBuilder().AddField(InnerFiled.CreateBuilder().SetKey("notifyid").SetVal((!this.notifyid.HasValue) ? "" : string.Concat(this.notifyid)).SetType(InnerFiled.Types.Type.str).Build()).Build();
            ActionChain item3 = ActionChain.CreateBuilder().SetActionId(10010).SetType(ActionChain.Types.Type.Goto).SetNext(11220).Build();
            ActionChain item4 = ActionChain.CreateBuilder().SetActionId(11220).SetType(ActionChain.Types.Type.mmsinbox2).SetStype("startmyactivity").AddField(InnerFiled.CreateBuilder().SetKey("uri").SetVal(this.getIntent()).SetType(InnerFiled.Types.Type.str)).AddField(InnerFiled.CreateBuilder().SetKey("do_failed").SetVal("100").SetType(InnerFiled.Types.Type.str)).SetNext(100).Build();
            ActionChain item5 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
            arg_138_0.Add(item);
            arg_138_0.Add(item2);
            arg_138_0.Add(item3);
            arg_138_0.Add(item4);
            arg_138_0.Add(item5);
            return arg_138_0;
        }

        private string getIntent()
        {
            if (this.intent != null)
            {
                return this.intent;
            }
            return "";
        }

        public void setStyle(AbstractNotifyStyle style)
        {
            this.style = style;
        }

        public bool setIntent(string intent)
        {
            if (intent.Length <= 1000 && Regex.IsMatch(intent, this.pattern))
            {
                this.intent = intent;
                return true;
            }
            return false;
        }

        protected override int getTemplateId()
        {
            return 7;
        }
    }
}
