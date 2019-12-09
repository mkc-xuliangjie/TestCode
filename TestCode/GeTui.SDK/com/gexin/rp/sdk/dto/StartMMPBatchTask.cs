using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class StartMMPBatchTask : GeneratedMessage<StartMMPBatchTask, StartMMPBatchTask.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<StartMMPBatchTask, StartMMPBatchTask.Builder>
        {
            private bool resultIsReadOnly;

            private StartMMPBatchTask result;

            protected override StartMMPBatchTask.Builder ThisBuilder
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

            protected override StartMMPBatchTask MessageBeingBuilt
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
                    return StartMMPBatchTask.Descriptor;
                }
            }

            public override StartMMPBatchTask DefaultInstanceForType
            {
                get
                {
                    return StartMMPBatchTask.DefaultInstance;
                }
            }

            public bool HasMessage
            {
                get
                {
                    return this.result.hasMessage;
                }
            }

            public MMPMessage Message
            {
                get
                {
                    return this.result.Message;
                }
                set
                {
                    this.SetMessage(value);
                }
            }

            public bool HasExpire
            {
                get
                {
                    return this.result.hasExpire;
                }
            }

            public long Expire
            {
                get
                {
                    return this.result.Expire;
                }
                set
                {
                    this.SetExpire(value);
                }
            }

            public bool HasSeqId
            {
                get
                {
                    return this.result.hasSeqId;
                }
            }

            public string SeqId
            {
                get
                {
                    return this.result.SeqId;
                }
                set
                {
                    this.SetSeqId(value);
                }
            }

            public bool HasTaskGroupName
            {
                get
                {
                    return this.result.hasTaskGroupName;
                }
            }

            public string TaskGroupName
            {
                get
                {
                    return this.result.TaskGroupName;
                }
                set
                {
                    this.SetTaskGroupName(value);
                }
            }

            public Builder()
            {
                this.result = StartMMPBatchTask.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(StartMMPBatchTask cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private StartMMPBatchTask PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    StartMMPBatchTask other = this.result;
                    this.result = new StartMMPBatchTask();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override StartMMPBatchTask.Builder Clear()
            {
                this.result = StartMMPBatchTask.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override StartMMPBatchTask.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new StartMMPBatchTask.Builder(this.result);
                }
                return new StartMMPBatchTask.Builder().MergeFrom(this.result);
            }

            public override StartMMPBatchTask BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override StartMMPBatchTask.Builder MergeFrom(IMessage other)
            {
                if (other is StartMMPBatchTask)
                {
                    return this.MergeFrom((StartMMPBatchTask)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override StartMMPBatchTask.Builder MergeFrom(StartMMPBatchTask other)
            {
                if (other == StartMMPBatchTask.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasMessage)
                {
                    this.MergeMessage(other.Message);
                }
                if (other.HasExpire)
                {
                    this.Expire = other.Expire;
                }
                if (other.HasSeqId)
                {
                    this.SeqId = other.SeqId;
                }
                if (other.HasTaskGroupName)
                {
                    this.TaskGroupName = other.TaskGroupName;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override StartMMPBatchTask.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override StartMMPBatchTask.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(StartMMPBatchTask._startMMPBatchTaskFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = StartMMPBatchTask._startMMPBatchTaskFieldTags[num2];
                    }
                    if (num <= 10u)
                    {
                        if (num == 0u)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10u)
                        {
                            MMPMessage.Builder builder2 = MMPMessage.CreateBuilder();
                            if (this.result.hasMessage)
                            {
                                builder2.MergeFrom(this.Message);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.Message = builder2.BuildPartial();
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 16u)
                        {
                            this.result.hasExpire = input.ReadInt64(ref this.result.expire_);
                            continue;
                        }
                        if (num == 26u)
                        {
                            this.result.hasSeqId = input.ReadString(ref this.result.seqId_);
                            continue;
                        }
                        if (num == 34u)
                        {
                            this.result.hasTaskGroupName = input.ReadString(ref this.result.taskGroupName_);
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

            public StartMMPBatchTask.Builder SetMessage(MMPMessage value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMessage = true;
                this.result.message_ = value;
                return this;
            }

            public StartMMPBatchTask.Builder SetMessage(MMPMessage.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMessage = true;
                this.result.message_ = builderForValue.Build();
                return this;
            }

            public StartMMPBatchTask.Builder MergeMessage(MMPMessage value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasMessage && this.result.message_ != MMPMessage.DefaultInstance)
                {
                    this.result.message_ = MMPMessage.CreateBuilder(this.result.message_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.message_ = value;
                }
                this.result.hasMessage = true;
                return this;
            }

            public StartMMPBatchTask.Builder ClearMessage()
            {
                this.PrepareBuilder();
                this.result.hasMessage = false;
                this.result.message_ = null;
                return this;
            }

            public StartMMPBatchTask.Builder SetExpire(long value)
            {
                this.PrepareBuilder();
                this.result.hasExpire = true;
                this.result.expire_ = value;
                return this;
            }

            public StartMMPBatchTask.Builder ClearExpire()
            {
                this.PrepareBuilder();
                this.result.hasExpire = false;
                this.result.expire_ = 72L;
                return this;
            }

            public StartMMPBatchTask.Builder SetSeqId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSeqId = true;
                this.result.seqId_ = value;
                return this;
            }

            public StartMMPBatchTask.Builder ClearSeqId()
            {
                this.PrepareBuilder();
                this.result.hasSeqId = false;
                this.result.seqId_ = "";
                return this;
            }

            public StartMMPBatchTask.Builder SetTaskGroupName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTaskGroupName = true;
                this.result.taskGroupName_ = value;
                return this;
            }

            public StartMMPBatchTask.Builder ClearTaskGroupName()
            {
                this.PrepareBuilder();
                this.result.hasTaskGroupName = false;
                this.result.taskGroupName_ = "";
                return this;
            }
        }

        private static readonly StartMMPBatchTask defaultInstance;

        private static readonly string[] _startMMPBatchTaskFieldNames;

        private static readonly uint[] _startMMPBatchTaskFieldTags;

        public const int MessageFieldNumber = 1;

        private bool hasMessage;

        private MMPMessage message_;

        public const int ExpireFieldNumber = 2;

        private bool hasExpire;

        private long expire_ = 72L;

        public const int SeqIdFieldNumber = 3;

        private bool hasSeqId;

        private string seqId_ = "";

        public const int TaskGroupNameFieldNumber = 4;

        private bool hasTaskGroupName;

        private string taskGroupName_ = "";

        private int memoizedSerializedSize = -1;

        public static StartMMPBatchTask DefaultInstance
        {
            get
            {
                return StartMMPBatchTask.defaultInstance;
            }
        }

        public override StartMMPBatchTask DefaultInstanceForType
        {
            get
            {
                return StartMMPBatchTask.DefaultInstance;
            }
        }

        protected override StartMMPBatchTask ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_StartMMPBatchTask__Descriptor;
            }
        }

        protected override FieldAccessorTable<StartMMPBatchTask, StartMMPBatchTask.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_StartMMPBatchTask__FieldAccessorTable;
            }
        }

        public bool HasMessage
        {
            get
            {
                return this.hasMessage;
            }
        }

        public MMPMessage Message
        {
            get
            {
                return this.message_ ?? MMPMessage.DefaultInstance;
            }
        }

        public bool HasExpire
        {
            get
            {
                return this.hasExpire;
            }
        }

        public long Expire
        {
            get
            {
                return this.expire_;
            }
        }

        public bool HasSeqId
        {
            get
            {
                return this.hasSeqId;
            }
        }

        public string SeqId
        {
            get
            {
                return this.seqId_;
            }
        }

        public bool HasTaskGroupName
        {
            get
            {
                return this.hasTaskGroupName;
            }
        }

        public string TaskGroupName
        {
            get
            {
                return this.taskGroupName_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                return this.hasMessage && this.hasExpire && this.Message.IsInitialized;
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
                if (this.hasMessage)
                {
                    num += CodedOutputStream.ComputeMessageSize(1, this.Message);
                }
                if (this.hasExpire)
                {
                    num += CodedOutputStream.ComputeInt64Size(2, this.Expire);
                }
                if (this.hasSeqId)
                {
                    num += CodedOutputStream.ComputeStringSize(3, this.SeqId);
                }
                if (this.hasTaskGroupName)
                {
                    num += CodedOutputStream.ComputeStringSize(4, this.TaskGroupName);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private StartMMPBatchTask()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] startMMPBatchTaskFieldNames = StartMMPBatchTask._startMMPBatchTaskFieldNames;
            if (this.hasMessage)
            {
                output.WriteMessage(1, startMMPBatchTaskFieldNames[1], this.Message);
            }
            if (this.hasExpire)
            {
                output.WriteInt64(2, startMMPBatchTaskFieldNames[0], this.Expire);
            }
            if (this.hasSeqId)
            {
                output.WriteString(3, startMMPBatchTaskFieldNames[2], this.SeqId);
            }
            if (this.hasTaskGroupName)
            {
                output.WriteString(4, startMMPBatchTaskFieldNames[3], this.TaskGroupName);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static StartMMPBatchTask ParseFrom(ByteString data)
        {
            return StartMMPBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static StartMMPBatchTask ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return StartMMPBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static StartMMPBatchTask ParseFrom(byte[] data)
        {
            return StartMMPBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static StartMMPBatchTask ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return StartMMPBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static StartMMPBatchTask ParseFrom(Stream input)
        {
            return StartMMPBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static StartMMPBatchTask ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return StartMMPBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static StartMMPBatchTask ParseDelimitedFrom(Stream input)
        {
            return StartMMPBatchTask.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static StartMMPBatchTask ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return StartMMPBatchTask.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static StartMMPBatchTask ParseFrom(ICodedInputStream input)
        {
            return StartMMPBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static StartMMPBatchTask ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return StartMMPBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private StartMMPBatchTask MakeReadOnly()
        {
            return this;
        }

        public static StartMMPBatchTask.Builder CreateBuilder()
        {
            return new StartMMPBatchTask.Builder();
        }

        public override StartMMPBatchTask.Builder ToBuilder()
        {
            return StartMMPBatchTask.CreateBuilder(this);
        }

        public override StartMMPBatchTask.Builder CreateBuilderForType()
        {
            return new StartMMPBatchTask.Builder();
        }

        public static StartMMPBatchTask.Builder CreateBuilder(StartMMPBatchTask prototype)
        {
            return new StartMMPBatchTask.Builder(prototype);
        }

        static StartMMPBatchTask()
        {
            StartMMPBatchTask.defaultInstance = new StartMMPBatchTask().MakeReadOnly();
            StartMMPBatchTask._startMMPBatchTaskFieldNames = new string[]
            {
                "expire",
                "message",
                "seqId",
                "taskGroupName"
            };
            StartMMPBatchTask._startMMPBatchTaskFieldTags = new uint[]
            {
                16u,
                10u,
                26u,
                34u
            };
            FileDescriptor arg_55_0 = GtReq.Descriptor;
        }
    }
}
