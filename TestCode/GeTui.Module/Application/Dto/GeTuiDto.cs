using System;
using System.Linq;
using GeTui.Module.Application;
using GeTui.Module.Domain;
using GeTui.Module.Infrastructure.Extensions;
using GeTui.Module.Infrastructure.Mapper;

namespace GeTui.Module.Application.Dto
{
    public class GeTuiDto
    {
        public GeTuiDto(string title, string pushContent, string transmissionContent, PhoneType phoneType, params string[] clientIds)
        {
            Title = title;
            PushContent = pushContent;
            TransmissionContent = transmissionContent;
            ClientIds = clientIds.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            PhoneType = phoneType;
        }

        /// <summary>
        /// 标题
        /// </summary>
        internal string Title { get; set; }

        /// <summary>
        /// 推送的内容
        /// </summary>
        internal string PushContent { get; set; }

        /// <summary>
        /// 透传内容
        /// </summary>
        internal string TransmissionContent { get; set; }

        /// <summary>
        /// 用户手机对应的ClientIds
        /// </summary>
        internal string[] ClientIds { get; set; }

        /// <summary>
        /// 手机类型
        /// </summary>
        internal PhoneType PhoneType { get; set; }

        public void CreateGeTui()
        {
            if (!ClientIds.Any()) return;
            var geTui = new GeTuiCommand(new Domain.GeTui())
                .Title(Title)
                .PushContent(PushContent)
                .JsonConetnt(TransmissionContent)
                .ClientId(ClientIds)
                .Entity;
            string result, message;
            try
            {
                result = geTui.Push();
            }
            catch (Exception e)
            {
                result = $"【异常个推信息】{e.Message}{e.StackTrace}";
            }

            if (result.Contains("异常个推信息")) //异常情况一般为参数错误，重试也只会再次抛出异常
                message = $"{Title}【推送失败】{GeTuiMap.Update(geTui)}{result}\n";
            else if (string.IsNullOrEmpty(result) || result.ToObject<ResultDto>().result.ToUpper() != "OK")
                message = $"{Title}【推送失败】{result}\n";
            else
                message = $"{Title}【推送成功】{GeTuiMap.Update(geTui)}{result}\n";
        }
    }
}