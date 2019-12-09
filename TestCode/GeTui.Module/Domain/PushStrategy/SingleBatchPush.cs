using System;
using com.igetui.api.openservice;
using com.igetui.api.openservice.igetui;

namespace GeTui.Module.Domain.PushStrategy
{
    internal class SingleBatchPush : BasePush
    {
        public SingleBatchPush(GeTui geTui) : base(geTui)
        {
        }

        public override string Push()
        {
            var message = new SingleMessage
            {
                Data = GeTui.ToTemplate(),
                IsOffline = true, // 用户当前不在线时，是否离线存储,可选
                OfflineExpireTime = 1000 * 3600 * 12, // 离线有效时间，单位为毫秒，可选
                PushNetWorkType = 0 //判断是否客户端是否wifi环境下推送，1为在WIFI环境下，0为不限制网络环境。
            };
            var batch = new BatchImpl(Keys.AppKey, this);
            foreach (var cid in GeTui.ClientId.Split('-'))
            {
                var target = new Target
                {
                    appId = Keys.AppId,
                    clientId = cid
                };
                batch.add(message, target);
            }
            try
            {
                return batch.submit();
            }
            catch (Exception)
            {
                return batch.retry();
            }
        }
    }
}