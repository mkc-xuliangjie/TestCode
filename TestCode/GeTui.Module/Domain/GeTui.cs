﻿using System;
using GeTui.Module.Domain.PushStrategy;

namespace GeTui.Module.Domain
{
    /// <summary>
    ///     消息推送机制
    /// </summary>
    internal class GeTui
    {
        public GeTui()
        {
            DBID = Guid.NewGuid();
            IsPush = false;
            CreateTime = DateTime.Now;
            PushTime = new DateTime(1753, 1, 1, 12, 0, 0);
        }

        public virtual Guid DBID { get; set; }

        /// <summary>
        ///     推送类型
        /// </summary>
        public virtual PushType PushType { get; set; }

        /// <summary>
        ///     推送标题
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        ///     推送内容
        /// </summary>
        public virtual string PushContent { get; set; }

        /// <summary>
        ///  透传内容
        /// </summary>
        public virtual string TransmissionContent { get; set; }

        /// <summary>
        /// 客户端Id
        /// </summary>
        public virtual string ClientId { get; set; }

        /// <summary>
        ///     是否已推送
        /// </summary>
        public virtual bool IsPush { get; set; }

        /// <summary>
        ///     推送生成时间
        /// </summary>
        public virtual DateTime CreateTime { get; set; }

        /// <summary>
        ///     推送发送时间
        /// </summary>
        public virtual DateTime PushTime { get; set; }

        /// <summary>
        /// 手机类型
        /// </summary>
        public virtual PhoneType PhoneType { get; set; }

        /// <summary>
        /// 推送类型 通知：NotificationTemplate，TransmissionTemplate：透传
        /// </summary>
        public virtual TemplateType TemplateType { get; set; }

        public virtual string Push()
        {
            BasePush push;

            switch (PushType)
            {
                case PushType.PushMessageToSingle:
                    push = new MessageToSinglePush(PhoneType, TemplateType, this);
                    break;

                case PushType.SingleBatch:
                    push = new SingleBatchPush(PhoneType, TemplateType, this);
                    break;

                default:
                    push = new MessageToListPush(PhoneType, TemplateType, this);
                    break;
            }

            return push.Push();
        }
    }
}