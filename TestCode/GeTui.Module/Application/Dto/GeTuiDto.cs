using System;
using System.Linq;
using GeTui.Module.Infrastructure.Extensions;
using GeTui.Module.Infrastructure.Mapper;

namespace GeTui.Module.Application.Dto
{
    public class GeTuiDto
    {
        public GeTuiDto(string title, string pushContent, string jsonContent, params string[] clientIds)
        {
            Title = title;
            PushContent = pushContent;
            JsonContent = jsonContent;
            ClientIds = clientIds.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }

        internal string Title { get; set; }
        internal string PushContent { get; set; }
        internal string JsonContent { get; set; }
        internal string[] ClientIds { get; set; }

        public void CreateGeTui()
        {
            if (!ClientIds.Any()) return;
            var geTui = new GeTuiCommand(new Domain.GeTui())
                .Title(Title)
                .PushContent(PushContent)
                .JsonConetnt(JsonContent)
                .ClientId(ClientIds)
                .Entity;
            LogService.Log(GeTuiMap.Save(geTui, out var isSave));
            if (!isSave) return;
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
            LogService.Log(message);
        }
    }
}