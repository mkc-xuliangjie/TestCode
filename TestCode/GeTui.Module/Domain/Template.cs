using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template;
using com.igetui.api.openservice.igetui.template.notify;
using GeTui.Module.Domain.Exceptions;

namespace GeTui.Module.Domain
{
    internal static class Template
    {
        public static AbstractTemplate ToTemplate(this GeTui geTui)
        {
            if (Keys.TemplateType == Keys.NotificationTemplate)
                return geTui.ToNotificationTemplate();
            if (Keys.TemplateType == Keys.TransmissionTemplate)
                return geTui.ToTransmissionTemplate();
            throw new TemplateTypeException();
        }

        private static NotificationTemplate ToNotificationTemplate(this GeTui geTui)
        {
            var title = $"待办事项—{geTui.Title}";
            var text = string.IsNullOrEmpty(geTui.PushContent)
                ? "您有一条待办事项需要处理"
                : geTui.PushContent;
            return new NotificationTemplate
            {
                AppId = Keys.AppId,
                AppKey = Keys.AppKey,
                Title = title, //通知标题
                Text = text, //通知内容
                Logo = "", //通知的图标名称，包含后缀名（需要在客户端开发时嵌入）
                LogoURL = "", //通知图标URL地址
                IsRing = true, //接收到消息是否响铃:true响铃,false不响铃。默认响铃。
                IsVibrate = true, //接收到消息是否震动:true震动,false不震动。默认振动。
                IsClearable = false, //接收到消息是否可清除:true可清除, false不可清除。默认可清除。
                TransmissionType = 1, //收到消息是否立即启动应用： 1为立即启动，2则广播等待客户端自启动
                TransmissionContent = geTui.JsonContent //透传内容
            };
        }

        private static TransmissionTemplate ToTransmissionTemplate(this GeTui geTui)
        {
            var title = $"待办事项—{geTui.Title}";
            var text = string.IsNullOrEmpty(geTui.PushContent)
                ? "您有一条待办事项需要处理"
                : geTui.PushContent;
            var notify = new Notify
            {
                Title = title, //通知标题
                Content = text, //通知内容
                Type = NotifyInfo.Types.Type._intent,
                Intent = geTui.GetIntent()
            };
            var template = new TransmissionTemplate
            {
                AppId = Keys.AppId,
                AppKey = Keys.AppKey,
                TransmissionType = 1, //应用启动类型，1：强制应用启动  2：等待应用启动
                TransmissionContent = geTui.JsonContent //透传内容
            };
            template.set3rdNotifyInfo(notify);
            return template;
        }
    }
}