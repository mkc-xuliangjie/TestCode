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
        public GeTuiDto(string title, string pushContent, string transmissionContent, PhoneType phoneType, TemplateType templateType, params string[] clientIds)
        {
            Title = title ?? string.Empty;
            PushContent = pushContent ?? string.Empty;
            TransmissionContent = transmissionContent ?? string.Empty;
            ClientIds = clientIds == null ? null : clientIds.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            PhoneType = phoneType;
            TemplateType = templateType;
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
        public PhoneType PhoneType { get; set; }

        public TemplateType TemplateType { get; set; }

        public ResultDto CreateGeTui()
        {
            ResultDto resultDto = new ResultDto();

            try
            {
                if (ClientIds == null || !ClientIds.Any()) return ResultDto.CreateFailedResultDto("ClientIds 不能为空.");
                var geTui = new GeTuiCommand(new Domain.GeTui())
                    .Title(Title)
                    .PushContent(PushContent)
                    .TransmissionContent(TransmissionContent)
                    .ClientId(ClientIds)
                    .TemplateType(TemplateType)
                    .PhoneType(PhoneType)
                    .Entity;

                string result = geTui.Push();

                resultDto = result.AsObject<ResultDto>();
            }
            catch (Exception e)
            {
                string desc = $"【异常个推信息】{e.Message}{e.StackTrace}";

                resultDto = ResultDto.CreateFailedResultDto(desc);
            }

            return resultDto;
        }
    }
}