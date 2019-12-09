using System.Linq;
using com.igetui.api.openservice.igetui;

namespace GeTui.Module.Domain.PushStrategy
{
    /// <summary>
    ///     对指定列表用户推送消息。
    ///     如果仅对单个用户推送务必使用单推接口，否则会严重影响推送性能，如果对少量甚至几个用户推送同样的消息，建议使用单推实现，性能会更高
    /// </summary>
    internal class MessageToListPush : BasePush
    {
        public MessageToListPush(GeTui geTui) : base(geTui)
        {
        }

        public override string Push()
        {
            var message = new ListMessage
            {
                Data = GeTui.ToTemplate(),
                IsOffline = true,// 用户当前不在线时，是否离线存储,可选
                OfflineExpireTime = 1000 * 3600 * 12,// 离线有效时间，单位为毫秒，可选
                PushNetWorkType = 0//判断是否客户端是否wifi环境下推送，1为在WIFI环境下，0为不限制网络环境。
            };
            var targetList = GeTui.ClientId.Split('-')
                .Select(x => new Target
                {
                    appId = Keys.AppId,
                    clientId = x
                }).ToList();
            var contentId = getContentId(message);
            return pushMessageToList(contentId, targetList);
        }
    }
}