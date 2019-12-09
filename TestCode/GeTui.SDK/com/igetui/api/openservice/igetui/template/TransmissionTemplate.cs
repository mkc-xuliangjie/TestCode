using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.notify;
using com.igetui.api.openservice.payload;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.igetui.template
{
    public class TransmissionTemplate : AbstractTemplate
    {
        private string transmissionContent;

        public int TransmissionType
        {
            get;
            set;
        }

        public string TransmissionContent
        {
            get
            {
                return this.transmissionContent;
            }
            set
            {
                this.transmissionContent = value;
            }
        }

        public new void set3rdNotifyInfo(Notify notify)
        {
            if (!base.getPushInfoBuilder().InvalidAPN && notify.getNotifyId().HasValue)
            {
                string apnJson = base.getPushInfoBuilder().ApnJson;
                Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(apnJson);
                if (string.IsNullOrEmpty((string)dictionary["apns-collapse-id"]))
                {
                    dictionary.Add("apns-collapse-id", notify.getNotifyId());
                    string apnJson2 = JsonConvert.SerializeObject(dictionary);
                    base.getPushInfoBuilder().SetApnJson(apnJson2);
                }
            }
            base.set3rdNotifyInfo(notify);
        }

        public new void setAPNInfo(Payload apn)
        {
            if (apn is APNPayload)
            {
                APNPayload aPNPayload = (APNPayload)apn;
                string notifyId = base.getPushInfo().NotifyInfo.NotifyId;
                if (notifyId != null && string.IsNullOrEmpty(aPNPayload.getApnsCollapseId()))
                {
                    aPNPayload.setApnsCollapseId(notifyId);
                }
            }
            base.setAPNInfo(apn);
        }

        public override List<ActionChain> getActionChain()
        {
            List<ActionChain> arg_AE_0 = new List<ActionChain>();
            ActionChain item = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.Goto).SetNext(10030).Build();
            AppStartUp appstartupid = AppStartUp.CreateBuilder().SetAndroid("").SetSymbia("").SetIos("").Build();
            ActionChain item2 = ActionChain.CreateBuilder().SetActionId(10030).SetType(ActionChain.Types.Type.startapp).SetAppid("").SetAutostart(1 == this.TransmissionType).SetAppstartupid(appstartupid).SetFailedAction(100).SetNext(100).Build();
            ActionChain item3 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
            arg_AE_0.Add(item);
            arg_AE_0.Add(item2);
            arg_AE_0.Add(item3);
            return arg_AE_0;
        }

        public override string getTransmissionContent()
        {
            return this.transmissionContent;
        }

        public override string getPushType()
        {
            return "TransmissionMsg";
        }

        protected override int getTemplateId()
        {
            return 4;
        }
    }
}
