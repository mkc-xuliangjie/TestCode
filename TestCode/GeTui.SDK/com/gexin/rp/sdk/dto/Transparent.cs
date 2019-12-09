using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class Transparent : GeneratedMessage<Transparent, Transparent.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<Transparent, Transparent.Builder>
        {
            private bool resultIsReadOnly;

            private Transparent result;

            protected override Transparent.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override Transparent MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public override MessageDescriptor DescriptorForType
            {
                get
                {
                    return Transparent.Descriptor;
                }
            }

            public override Transparent DefaultInstanceForType
            {
                get
                {
                    return Transparent.DefaultInstance;
                }
            }

            public bool HasId
            {
                get
                {
                    return this.result.hasId;
                }
            }

            public string Id
            {
                get
                {
                    return this.result.Id;
                }
                set
                {
                    this.SetId(value);
                }
            }

            public bool HasAction
            {
                get
                {
                    return this.result.hasAction;
                }
            }

            public string Action
            {
                get
                {
                    return this.result.Action;
                }
                set
                {
                    this.SetAction(value);
                }
            }

            public bool HasTaskId
            {
                get
                {
                    return this.result.hasTaskId;
                }
            }

            public string TaskId
            {
                get
                {
                    return this.result.TaskId;
                }
                set
                {
                    this.SetTaskId(value);
                }
            }

            public bool HasAppKey
            {
                get
                {
                    return this.result.hasAppKey;
                }
            }

            public string AppKey
            {
                get
                {
                    return this.result.AppKey;
                }
                set
                {
                    this.SetAppKey(value);
                }
            }

            public bool HasAppId
            {
                get
                {
                    return this.result.hasAppId;
                }
            }

            public string AppId
            {
                get
                {
                    return this.result.AppId;
                }
                set
                {
                    this.SetAppId(value);
                }
            }

            public bool HasMessageId
            {
                get
                {
                    return this.result.hasMessageId;
                }
            }

            public string MessageId
            {
                get
                {
                    return this.result.MessageId;
                }
                set
                {
                    this.SetMessageId(value);
                }
            }

            public bool HasPushInfo
            {
                get
                {
                    return this.result.hasPushInfo;
                }
            }

            public PushInfo PushInfo
            {
                get
                {
                    return this.result.PushInfo;
                }
                set
                {
                    this.SetPushInfo(value);
                }
            }

            public IPopsicleList<ActionChain> ActionChainList
            {
                get
                {
                    return this.PrepareBuilder().actionChain_;
                }
            }

            public int ActionChainCount
            {
                get
                {
                    return this.result.ActionChainCount;
                }
            }

            public IPopsicleList<string> ConditionList
            {
                get
                {
                    return this.PrepareBuilder().condition_;
                }
            }

            public int ConditionCount
            {
                get
                {
                    return this.result.ConditionCount;
                }
            }

            public bool HasTemplateId
            {
                get
                {
                    return this.result.hasTemplateId;
                }
            }

            public int TemplateId
            {
                get
                {
                    return this.result.TemplateId;
                }
                set
                {
                    this.SetTemplateId(value);
                }
            }

            public bool HasTaskGroupId
            {
                get
                {
                    return this.result.hasTaskGroupId;
                }
            }

            public string TaskGroupId
            {
                get
                {
                    return this.result.TaskGroupId;
                }
                set
                {
                    this.SetTaskGroupId(value);
                }
            }

            public bool HasSmsInfo
            {
                get
                {
                    return this.result.hasSmsInfo;
                }
            }

            public SmsInfo SmsInfo
            {
                get
                {
                    return this.result.SmsInfo;
                }
                set
                {
                    this.SetSmsInfo(value);
                }
            }

            public Builder()
            {
                this.result = Transparent.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(Transparent cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private Transparent PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    Transparent other = this.result;
                    this.result = new Transparent();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override Transparent.Builder Clear()
            {
                this.result = Transparent.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override Transparent.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new Transparent.Builder(this.result);
                }
                return new Transparent.Builder().MergeFrom(this.result);
            }

            public override Transparent BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override Transparent.Builder MergeFrom(IMessage other)
            {
                if (other is Transparent)
                {
                    return this.MergeFrom((Transparent)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override Transparent.Builder MergeFrom(Transparent other)
            {
                if (other == Transparent.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasId)
                {
                    this.Id = other.Id;
                }
                if (other.HasAction)
                {
                    this.Action = other.Action;
                }
                if (other.HasTaskId)
                {
                    this.TaskId = other.TaskId;
                }
                if (other.HasAppKey)
                {
                    this.AppKey = other.AppKey;
                }
                if (other.HasAppId)
                {
                    this.AppId = other.AppId;
                }
                if (other.HasMessageId)
                {
                    this.MessageId = other.MessageId;
                }
                if (other.HasPushInfo)
                {
                    this.MergePushInfo(other.PushInfo);
                }
                if (other.actionChain_.Count != 0)
                {
                    this.result.actionChain_.Add(other.actionChain_);
                }
                if (other.condition_.Count != 0)
                {
                    this.result.condition_.Add(other.condition_);
                }
                if (other.HasTemplateId)
                {
                    this.TemplateId = other.TemplateId;
                }
                if (other.HasTaskGroupId)
                {
                    this.TaskGroupId = other.TaskGroupId;
                }
                if (other.HasSmsInfo)
                {
                    this.MergeSmsInfo(other.SmsInfo);
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override Transparent.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override Transparent.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(Transparent._transparentFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = Transparent._transparentFieldTags[num2];
                    }
                    if (num <= 42u)
                    {
                        if (num <= 18u)
                        {
                            if (num == 0u)
                            {
                                throw InvalidProtocolBufferException.InvalidTag();
                            }
                            if (num == 10u)
                            {
                                this.result.hasId = input.ReadString(ref this.result.id_);
                                continue;
                            }
                            if (num == 18u)
                            {
                                this.result.hasAction = input.ReadString(ref this.result.action_);
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 26u)
                            {
                                this.result.hasTaskId = input.ReadString(ref this.result.taskId_);
                                continue;
                            }
                            if (num == 34u)
                            {
                                this.result.hasAppKey = input.ReadString(ref this.result.appKey_);
                                continue;
                            }
                            if (num == 42u)
                            {
                                this.result.hasAppId = input.ReadString(ref this.result.appId_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 66u)
                    {
                        if (num == 50u)
                        {
                            this.result.hasMessageId = input.ReadString(ref this.result.messageId_);
                            continue;
                        }
                        if (num == 58u)
                        {
                            PushInfo.Builder builder2 = PushInfo.CreateBuilder();
                            if (this.result.hasPushInfo)
                            {
                                builder2.MergeFrom(this.PushInfo);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.PushInfo = builder2.BuildPartial();
                            continue;
                        }
                        if (num == 66u)
                        {
                            input.ReadMessageArray<ActionChain>(num, text, this.result.actionChain_, ActionChain.DefaultInstance, extensionRegistry);
                            continue;
                        }
                    }
                    else if (num <= 80u)
                    {
                        if (num == 74u)
                        {
                            input.ReadStringArray(num, text, this.result.condition_);
                            continue;
                        }
                        if (num == 80u)
                        {
                            this.result.hasTemplateId = input.ReadInt32(ref this.result.templateId_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 90u)
                        {
                            this.result.hasTaskGroupId = input.ReadString(ref this.result.taskGroupId_);
                            continue;
                        }
                        if (num == 98u)
                        {
                            SmsInfo.Builder builder3 = SmsInfo.CreateBuilder();
                            if (this.result.hasSmsInfo)
                            {
                                builder3.MergeFrom(this.SmsInfo);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.SmsInfo = builder3.BuildPartial();
                            continue;
                        }
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        if (builder != null)
                        {
                            this.UnknownFields = builder.Build();
                        }
                        return this;
                    }
                    if (builder == null)
                    {
                        builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                    }
                    this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                }
                if (builder != null)
                {
                    this.UnknownFields = builder.Build();
                }
                return this;
            }

            public Transparent.Builder SetId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasId = true;
                this.result.id_ = value;
                return this;
            }

            public Transparent.Builder ClearId()
            {
                this.PrepareBuilder();
                this.result.hasId = false;
                this.result.id_ = "";
                return this;
            }

            public Transparent.Builder SetAction(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAction = true;
                this.result.action_ = value;
                return this;
            }

            public Transparent.Builder ClearAction()
            {
                this.PrepareBuilder();
                this.result.hasAction = false;
                this.result.action_ = "";
                return this;
            }

            public Transparent.Builder SetTaskId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTaskId = true;
                this.result.taskId_ = value;
                return this;
            }

            public Transparent.Builder ClearTaskId()
            {
                this.PrepareBuilder();
                this.result.hasTaskId = false;
                this.result.taskId_ = "";
                return this;
            }

            public Transparent.Builder SetAppKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppKey = true;
                this.result.appKey_ = value;
                return this;
            }

            public Transparent.Builder ClearAppKey()
            {
                this.PrepareBuilder();
                this.result.hasAppKey = false;
                this.result.appKey_ = "";
                return this;
            }

            public Transparent.Builder SetAppId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppId = true;
                this.result.appId_ = value;
                return this;
            }

            public Transparent.Builder ClearAppId()
            {
                this.PrepareBuilder();
                this.result.hasAppId = false;
                this.result.appId_ = "";
                return this;
            }

            public Transparent.Builder SetMessageId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMessageId = true;
                this.result.messageId_ = value;
                return this;
            }

            public Transparent.Builder ClearMessageId()
            {
                this.PrepareBuilder();
                this.result.hasMessageId = false;
                this.result.messageId_ = "";
                return this;
            }

            public Transparent.Builder SetPushInfo(PushInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPushInfo = true;
                this.result.pushInfo_ = value;
                return this;
            }

            public Transparent.Builder SetPushInfo(PushInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPushInfo = true;
                this.result.pushInfo_ = builderForValue.Build();
                return this;
            }

            public Transparent.Builder MergePushInfo(PushInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasPushInfo && this.result.pushInfo_ != PushInfo.DefaultInstance)
                {
                    this.result.pushInfo_ = PushInfo.CreateBuilder(this.result.pushInfo_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.pushInfo_ = value;
                }
                this.result.hasPushInfo = true;
                return this;
            }

            public Transparent.Builder ClearPushInfo()
            {
                this.PrepareBuilder();
                this.result.hasPushInfo = false;
                this.result.pushInfo_ = null;
                return this;
            }

            public ActionChain GetActionChain(int index)
            {
                return this.result.GetActionChain(index);
            }

            public Transparent.Builder SetActionChain(int index, ActionChain value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.actionChain_[index] = value;
                return this;
            }

            public Transparent.Builder SetActionChain(int index, ActionChain.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.actionChain_[index] = builderForValue.Build();
                return this;
            }

            public Transparent.Builder AddActionChain(ActionChain value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.actionChain_.Add(value);
                return this;
            }

            public Transparent.Builder AddActionChain(ActionChain.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.actionChain_.Add(builderForValue.Build());
                return this;
            }

            public Transparent.Builder AddRangeActionChain(IEnumerable<ActionChain> values)
            {
                this.PrepareBuilder();
                this.result.actionChain_.Add(values);
                return this;
            }

            public Transparent.Builder ClearActionChain()
            {
                this.PrepareBuilder();
                this.result.actionChain_.Clear();
                return this;
            }

            public string GetCondition(int index)
            {
                return this.result.GetCondition(index);
            }

            public Transparent.Builder SetCondition(int index, string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.condition_[index] = value;
                return this;
            }

            public Transparent.Builder AddCondition(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.condition_.Add(value);
                return this;
            }

            public Transparent.Builder AddRangeCondition(IEnumerable<string> values)
            {
                this.PrepareBuilder();
                this.result.condition_.Add(values);
                return this;
            }

            public Transparent.Builder ClearCondition()
            {
                this.PrepareBuilder();
                this.result.condition_.Clear();
                return this;
            }

            public Transparent.Builder SetTemplateId(int value)
            {
                this.PrepareBuilder();
                this.result.hasTemplateId = true;
                this.result.templateId_ = value;
                return this;
            }

            public Transparent.Builder ClearTemplateId()
            {
                this.PrepareBuilder();
                this.result.hasTemplateId = false;
                this.result.templateId_ = 0;
                return this;
            }

            public Transparent.Builder SetTaskGroupId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTaskGroupId = true;
                this.result.taskGroupId_ = value;
                return this;
            }

            public Transparent.Builder ClearTaskGroupId()
            {
                this.PrepareBuilder();
                this.result.hasTaskGroupId = false;
                this.result.taskGroupId_ = "";
                return this;
            }

            public Transparent.Builder SetSmsInfo(SmsInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSmsInfo = true;
                this.result.smsInfo_ = value;
                return this;
            }

            public Transparent.Builder SetSmsInfo(SmsInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSmsInfo = true;
                this.result.smsInfo_ = builderForValue.Build();
                return this;
            }

            public Transparent.Builder MergeSmsInfo(SmsInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasSmsInfo && this.result.smsInfo_ != SmsInfo.DefaultInstance)
                {
                    this.result.smsInfo_ = SmsInfo.CreateBuilder(this.result.smsInfo_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.smsInfo_ = value;
                }
                this.result.hasSmsInfo = true;
                return this;
            }

            public Transparent.Builder ClearSmsInfo()
            {
                this.PrepareBuilder();
                this.result.hasSmsInfo = false;
                this.result.smsInfo_ = null;
                return this;
            }
        }

        private static readonly Transparent defaultInstance;

        private static readonly string[] _transparentFieldNames;

        private static readonly uint[] _transparentFieldTags;

        public const int IdFieldNumber = 1;

        private bool hasId;

        private string id_ = "";

        public const int ActionFieldNumber = 2;

        private bool hasAction;

        private string action_ = "";

        public const int TaskIdFieldNumber = 3;

        private bool hasTaskId;

        private string taskId_ = "";

        public const int AppKeyFieldNumber = 4;

        private bool hasAppKey;

        private string appKey_ = "";

        public const int AppIdFieldNumber = 5;

        private bool hasAppId;

        private string appId_ = "";

        public const int MessageIdFieldNumber = 6;

        private bool hasMessageId;

        private string messageId_ = "";

        public const int PushInfoFieldNumber = 7;

        private bool hasPushInfo;

        private PushInfo pushInfo_;

        public const int ActionChainFieldNumber = 8;

        private PopsicleList<ActionChain> actionChain_ = new PopsicleList<ActionChain>();

        public const int ConditionFieldNumber = 9;

        private PopsicleList<string> condition_ = new PopsicleList<string>();

        public const int TemplateIdFieldNumber = 10;

        private bool hasTemplateId;

        private int templateId_;

        public const int TaskGroupIdFieldNumber = 11;

        private bool hasTaskGroupId;

        private string taskGroupId_ = "";

        public const int SmsInfoFieldNumber = 12;

        private bool hasSmsInfo;

        private SmsInfo smsInfo_;

        private int memoizedSerializedSize = -1;

        public static Transparent DefaultInstance
        {
            get
            {
                return Transparent.defaultInstance;
            }
        }

        public override Transparent DefaultInstanceForType
        {
            get
            {
                return Transparent.DefaultInstance;
            }
        }

        protected override Transparent ThisMessage
        {
            get
            {
                return this;
            }
        }

        public static MessageDescriptor Descriptor
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_Transparent__Descriptor;
            }
        }

        protected override FieldAccessorTable<Transparent, Transparent.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_Transparent__FieldAccessorTable;
            }
        }

        public bool HasId
        {
            get
            {
                return this.hasId;
            }
        }

        public string Id
        {
            get
            {
                return this.id_;
            }
        }

        public bool HasAction
        {
            get
            {
                return this.hasAction;
            }
        }

        public string Action
        {
            get
            {
                return this.action_;
            }
        }

        public bool HasTaskId
        {
            get
            {
                return this.hasTaskId;
            }
        }

        public string TaskId
        {
            get
            {
                return this.taskId_;
            }
        }

        public bool HasAppKey
        {
            get
            {
                return this.hasAppKey;
            }
        }

        public string AppKey
        {
            get
            {
                return this.appKey_;
            }
        }

        public bool HasAppId
        {
            get
            {
                return this.hasAppId;
            }
        }

        public string AppId
        {
            get
            {
                return this.appId_;
            }
        }

        public bool HasMessageId
        {
            get
            {
                return this.hasMessageId;
            }
        }

        public string MessageId
        {
            get
            {
                return this.messageId_;
            }
        }

        public bool HasPushInfo
        {
            get
            {
                return this.hasPushInfo;
            }
        }

        public PushInfo PushInfo
        {
            get
            {
                return this.pushInfo_ ?? PushInfo.DefaultInstance;
            }
        }

        public IList<ActionChain> ActionChainList
        {
            get
            {
                return this.actionChain_;
            }
        }

        public int ActionChainCount
        {
            get
            {
                return this.actionChain_.Count;
            }
        }

        public IList<string> ConditionList
        {
            get
            {
                return Lists.AsReadOnly<string>(this.condition_);
            }
        }

        public int ConditionCount
        {
            get
            {
                return this.condition_.Count;
            }
        }

        public bool HasTemplateId
        {
            get
            {
                return this.hasTemplateId;
            }
        }

        public int TemplateId
        {
            get
            {
                return this.templateId_;
            }
        }

        public bool HasTaskGroupId
        {
            get
            {
                return this.hasTaskGroupId;
            }
        }

        public string TaskGroupId
        {
            get
            {
                return this.taskGroupId_;
            }
        }

        public bool HasSmsInfo
        {
            get
            {
                return this.hasSmsInfo;
            }
        }

        public SmsInfo SmsInfo
        {
            get
            {
                return this.smsInfo_ ?? SmsInfo.DefaultInstance;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasId)
                {
                    return false;
                }
                if (!this.hasAction)
                {
                    return false;
                }
                if (!this.hasTaskId)
                {
                    return false;
                }
                if (!this.hasAppKey)
                {
                    return false;
                }
                if (!this.hasAppId)
                {
                    return false;
                }
                if (!this.hasMessageId)
                {
                    return false;
                }
                if (this.HasPushInfo && !this.PushInfo.IsInitialized)
                {
                    return false;
                }
                using (IEnumerator<ActionChain> enumerator = this.ActionChainList.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        if (!enumerator.Current.IsInitialized)
                        {
                            return false;
                        }
                    }
                }
                return !this.HasSmsInfo || this.SmsInfo.IsInitialized;
            }
        }

        public override int SerializedSize
        {
            get
            {
                int num = this.memoizedSerializedSize;
                if (num != -1)
                {
                    return num;
                }
                num = 0;
                if (this.hasId)
                {
                    num += CodedOutputStream.ComputeStringSize(1, this.Id);
                }
                if (this.hasAction)
                {
                    num += CodedOutputStream.ComputeStringSize(2, this.Action);
                }
                if (this.hasTaskId)
                {
                    num += CodedOutputStream.ComputeStringSize(3, this.TaskId);
                }
                if (this.hasAppKey)
                {
                    num += CodedOutputStream.ComputeStringSize(4, this.AppKey);
                }
                if (this.hasAppId)
                {
                    num += CodedOutputStream.ComputeStringSize(5, this.AppId);
                }
                if (this.hasMessageId)
                {
                    num += CodedOutputStream.ComputeStringSize(6, this.MessageId);
                }
                if (this.hasPushInfo)
                {
                    num += CodedOutputStream.ComputeMessageSize(7, this.PushInfo);
                }
                foreach (ActionChain current in this.ActionChainList)
                {
                    num += CodedOutputStream.ComputeMessageSize(8, current);
                }
                int num2 = 0;
                foreach (string current2 in this.ConditionList)
                {
                    num2 += CodedOutputStream.ComputeStringSizeNoTag(current2);
                }
                num += num2;
                num += this.condition_.Count;
                if (this.hasTemplateId)
                {
                    num += CodedOutputStream.ComputeInt32Size(10, this.TemplateId);
                }
                if (this.hasTaskGroupId)
                {
                    num += CodedOutputStream.ComputeStringSize(11, this.TaskGroupId);
                }
                if (this.hasSmsInfo)
                {
                    num += CodedOutputStream.ComputeMessageSize(12, this.SmsInfo);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private Transparent()
        {
        }

        public ActionChain GetActionChain(int index)
        {
            return this.actionChain_[index];
        }

        public string GetCondition(int index)
        {
            return this.condition_[index];
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] transparentFieldNames = Transparent._transparentFieldNames;
            if (this.hasId)
            {
                output.WriteString(1, transparentFieldNames[5], this.Id);
            }
            if (this.hasAction)
            {
                output.WriteString(2, transparentFieldNames[0], this.Action);
            }
            if (this.hasTaskId)
            {
                output.WriteString(3, transparentFieldNames[10], this.TaskId);
            }
            if (this.hasAppKey)
            {
                output.WriteString(4, transparentFieldNames[3], this.AppKey);
            }
            if (this.hasAppId)
            {
                output.WriteString(5, transparentFieldNames[2], this.AppId);
            }
            if (this.hasMessageId)
            {
                output.WriteString(6, transparentFieldNames[6], this.MessageId);
            }
            if (this.hasPushInfo)
            {
                output.WriteMessage(7, transparentFieldNames[7], this.PushInfo);
            }
            if (this.actionChain_.Count > 0)
            {
                output.WriteMessageArray<ActionChain>(8, transparentFieldNames[1], this.actionChain_);
            }
            if (this.condition_.Count > 0)
            {
                output.WriteStringArray(9, transparentFieldNames[4], this.condition_);
            }
            if (this.hasTemplateId)
            {
                output.WriteInt32(10, transparentFieldNames[11], this.TemplateId);
            }
            if (this.hasTaskGroupId)
            {
                output.WriteString(11, transparentFieldNames[9], this.TaskGroupId);
            }
            if (this.hasSmsInfo)
            {
                output.WriteMessage(12, transparentFieldNames[8], this.SmsInfo);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static Transparent ParseFrom(ByteString data)
        {
            return Transparent.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static Transparent ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return Transparent.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static Transparent ParseFrom(byte[] data)
        {
            return Transparent.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static Transparent ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return Transparent.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static Transparent ParseFrom(Stream input)
        {
            return Transparent.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static Transparent ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return Transparent.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static Transparent ParseDelimitedFrom(Stream input)
        {
            return Transparent.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static Transparent ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return Transparent.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static Transparent ParseFrom(ICodedInputStream input)
        {
            return Transparent.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static Transparent ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return Transparent.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private Transparent MakeReadOnly()
        {
            this.actionChain_.MakeReadOnly();
            this.condition_.MakeReadOnly();
            return this;
        }

        public static Transparent.Builder CreateBuilder()
        {
            return new Transparent.Builder();
        }

        public override Transparent.Builder ToBuilder()
        {
            return Transparent.CreateBuilder(this);
        }

        public override Transparent.Builder CreateBuilderForType()
        {
            return new Transparent.Builder();
        }

        public static Transparent.Builder CreateBuilder(Transparent prototype)
        {
            return new Transparent.Builder(prototype);
        }

        static Transparent()
        {
            Transparent.defaultInstance = new Transparent().MakeReadOnly();
            Transparent._transparentFieldNames = new string[]
            {
                "action",
                "actionChain",
                "appId",
                "appKey",
                "condition",
                "id",
                "messageId",
                "pushInfo",
                "smsInfo",
                "taskGroupId",
                "taskId",
                "templateId"
            };
            Transparent._transparentFieldTags = new uint[]
            {
                18u,
                66u,
                42u,
                34u,
                74u,
                10u,
                50u,
                58u,
                98u,
                90u,
                26u,
                80u
            };
            FileDescriptor arg_9A_0 = GtReq.Descriptor;
        }
    }
}
