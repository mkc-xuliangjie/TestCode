using com.igetui.api.openservice;
using com.igetui.api.openservice.igetui;

namespace GeTui.Module.Domain.PushStrategy
{
    /// <summary>
    ///     对单个用户推送消息
    /// </summary>
    internal class MessageToSinglePush : BasePush
    {
        public MessageToSinglePush(GeTui geTui) : base(geTui)
        {
        }

        public override string Push()
        {
            string pushResult;
            var message = new SingleMessage
            {
                Data = GeTui.ToTemplate(),
                IsOffline = true, // 用户当前不在线时，是否离线存储,可选
                OfflineExpireTime = 1000 * 3600 * 12, // 离线有效时间，单位为毫秒，可选
                PushNetWorkType = 0 //判断是否客户端是否wifi环境下推送，1为在WIFI环境下，0为不限制网络环境。
            };
            var target = new Target
            {
                appId = Keys.AppId,
                clientId = GeTui.ClientId
            };
            try
            {
                pushResult = pushMessageToSingle(message, target);
            }
            catch (RequestException e)
            {
                var requestId = e.RequestId;
                pushResult = pushMessageToSingle(message, target, requestId);//发送失败后的重发
            }

            return pushResult;
        }
    }
}