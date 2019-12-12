using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice;
using com.igetui.api.openservice.igetui.template;
using com.igetui.api.openservice.igetui.template.notify;
using com.igetui.api.openservice.payload;
using GeTui.Module.Domain.Exceptions;
using GeTui.Module.Infrastructure.Extensions;
using System;

namespace GeTui.Module.Domain
{
    internal static class Template
    {
        public static AbstractTemplate ToTemplate(this GeTui geTui, PhoneType phoneType, TemplateType templateType)
        {
            switch (templateType)
            {
                case TemplateType.NotificationTemplate:
                    return geTui.ToNotificationTemplate(phoneType);

                case TemplateType.TransmissionTemplate:
                    return geTui.ToTransmissionTemplate(phoneType);

                default:
                    throw new TemplateTypeException();
            }
        }

        private static NotificationTemplate ToNotificationTemplate(this GeTui geTui, PhoneType phoneType)
        {
            var title = geTui.Title;
            var text = string.IsNullOrEmpty(geTui.PushContent) ? ConfigSettings.DefaultPushContent : geTui.PushContent;

            var template = new NotificationTemplate
            {
                AppId = ConfigSettings.AppId,
                AppKey = ConfigSettings.AppKey,
                Title = title, //通知标题
                Text = text, //通知内容
                Logo = "", //通知的图标名称，包含后缀名（需要在客户端开发时嵌入）
                LogoURL = "", //通知图标URL地址
                IsRing = true, //接收到消息是否响铃:true响铃,false不响铃。默认响铃。
                IsVibrate = true, //接收到消息是否震动:true震动,false不震动。默认振动。
                IsClearable = false, //接收到消息是否可清除:true可清除, false不可清除。默认可清除。
                TransmissionType = 1, //收到消息是否立即启动应用： 1为立即启动，2则广播等待客户端自启动
                TransmissionContent = geTui.TransmissionContent //透传内容
            };

            if (phoneType == PhoneType.ANDROID)
            {
                string begin = DateTime.Now.AddMinutes(-1).ToString("yyyy-MM-dd HH:mm:ss");

                string end = DateTime.Now.AddMinutes(2).ToString("yyyy-MM-dd HH:mm:ss");

                template.setDuration(begin, end);
            }

            return template;
        }

        private static TransmissionTemplate ToTransmissionTemplate(this GeTui geTui, PhoneType phoneType)
        {
            #region  ----官网代码

            var title = geTui.Title;
            var text = string.IsNullOrEmpty(geTui.PushContent) ? ConfigSettings.DefaultPushContent : geTui.PushContent;

            var template = new TransmissionTemplate
            {
                AppId = ConfigSettings.AppId,
                AppKey = ConfigSettings.AppKey,
                TransmissionType = 1, //应用启动类型，1：强制应用启动  2：等待应用启动
                TransmissionContent = geTui.TransmissionContent //透传内容
            };


            //TransmissionContentModel transmissionContentModel = new TransmissionContentModel()
            //{
            //    tilte = geTui.Title,
            //    content = geTui.PushContent,
            //    payload = geTui.TransmissionContent
            //};

            // template.TransmissionContent = JsonExtensions.ToJson(transmissionContentModel);

            //设置三方通知
            var notify = new Notify
            {
                Title = title, //通知标题
                Content = text, //通知内容
                Type = NotifyInfo.Types.Type._payload,
                Intent = geTui.GetIntent()
            };

            template.set3rdNotifyInfo(notify);

            //iOS简单推送
            //APNPayload apnpayload = new APNPayload();
            //SimpleAlertMsg alertMsg = new SimpleAlertMsg("alertMsg");
            //apnpayload.AlertMsg = alertMsg;
            //apnpayload.Badge = 11;
            //apnpayload.ContentAvailable = 1;
            //apnpayload.Category = "";
            //apnpayload.Sound = "";
            //apnpayload.addCustomMsg("", "");
            //template.setAPNInfo(apnpayload);

            //APN高级推送
            APNPayload apnpayload = new APNPayload();
            apnpayload.Sound = "com.gexin.ios.silence";
            apnpayload.addCustomMsg("payload", geTui.PushContent);
            apnpayload.ContentAvailable = 1;
            apnpayload.Category = "ACTIONABLE";
            DictionaryAlertMsg alertMsg = new DictionaryAlertMsg();
            alertMsg.Body = text;
            //alertMsg.ActionLocKey = "ActionLocKey";
            //alertMsg.LocKey = "LocKey";
            //alertMsg.addLocArg("LocArg");
            //alertMsg.LaunchImage = "LaunchImage";
            //iOS8.2支持字段
            alertMsg.Title = title;
            //alertMsg.TitleLocKey = "TitleLocKey";
            //alertMsg.addTitleLocArg("TitleLocArg");

            apnpayload.AlertMsg = alertMsg;
            apnpayload.Badge = 1;
            apnpayload.ContentAvailable = 1;
            //apnpayload.Category = "";
            //apnpayload.Sound = "test1.wav";
            //apnpayload.addCustomMsg("payload", "payload");
            //多媒体
            //MultiMedia multiMedia = new MultiMedia();
            //multiMedia.rid = "xxx-1";
            //multiMedia.url = "";
            //multiMedia.setIsOnlyWifi(false);
            //multiMedia.type = MultiMedia.MediaType.pic;

            //List<MultiMedia> list = new List<MultiMedia>();
            //list.Add(multiMedia);
            //apnpayload.MultiMedias = list;
            apnpayload.AlertMsg = alertMsg;

            template.setAPNInfo(apnpayload as Payload);


            return template;


            #endregion

            #region  OldCode

            //TransmissionTemplate template = new TransmissionTemplate();
            //template.AppId = ConfigSettings.AppId;
            //template.AppKey = ConfigSettings.AppKey;
            //template.TransmissionType = 2;

            //TransmissionContentModel transmissionContentModel = new TransmissionContentModel()
            //{
            //    tilte = geTui.Title,
            //    content = geTui.PushContent,
            //    payload = geTui.TransmissionContent
            //};

            //template.TransmissionContent = JsonExtensions.ToJson(transmissionContentModel);


            //var apnpayload = new APNPayload();
            //apnpayload.ContentAvailable = 1;

            //apnpayload.addCustomMsg("data", geTui.TransmissionContent);

            //apnpayload.addCustomMsg("title", geTui.Title);

            //apnpayload.addCustomMsg("content", geTui.PushContent);

            //DictionaryAlertMsg alertMsg = new DictionaryAlertMsg();

            //alertMsg.Body = geTui.PushContent;
            //alertMsg.ActionLocKey = "";
            //alertMsg.LocKey = geTui.PushContent;

            //alertMsg.Title = geTui.Title;

            //alertMsg.addLocArg("");
            //apnpayload.AlertMsg = alertMsg;

            //template.setAPNInfo(apnpayload as Payload);

            return template;

            #endregion
        }
    }
}