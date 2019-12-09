using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class StartOSBatchTask : GeneratedMessage<StartOSBatchTask, StartOSBatchTask.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<StartOSBatchTask, StartOSBatchTask.Builder>
        {
            private bool resultIsReadOnly;

            private StartOSBatchTask result;

            protected override StartOSBatchTask.Builder ThisBuilder
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

            protected override StartOSBatchTask MessageBeingBuilt
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
                    return StartOSBatchTask.Descriptor;
                }
            }

            public override StartOSBatchTask DefaultInstanceForType
            {
                get
                {
                    return StartOSBatchTask.DefaultInstance;
                }
            }

            public bool HasMessage
            {
                get
                {
                    return this.result.hasMessage;
                }
            }

            public OSMessage Message
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

            public Builder()
            {
                this.result = StartOSBatchTask.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(StartOSBatchTask cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private StartOSBatchTask PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    StartOSBatchTask other = this.result;
                    this.result = new StartOSBatchTask();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override StartOSBatchTask.Builder Clear()
            {
                this.result = StartOSBatchTask.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override StartOSBatchTask.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new StartOSBatchTask.Builder(this.result);
                }
                return new StartOSBatchTask.Builder().MergeFrom(this.result);
            }

            public override StartOSBatchTask BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override StartOSBatchTask.Builder MergeFrom(IMessage other)
            {
                if (other is StartOSBatchTask)
                {
                    return this.MergeFrom((StartOSBatchTask)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override StartOSBatchTask.Builder MergeFrom(StartOSBatchTask other)
            {
                if (other == StartOSBatchTask.DefaultInstance)
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
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override StartOSBatchTask.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override StartOSBatchTask.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(StartOSBatchTask._startOSBatchTaskFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = StartOSBatchTask._startOSBatchTaskFieldTags[num2];
                    }
                    if (num == 0u)
                    {
                        throw InvalidProtocolBufferException.InvalidTag();
                    }
                    if (num != 10u)
                    {
                        if (num != 16u)
                        {
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
                        else
                        {
                            this.result.hasExpire = input.ReadInt64(ref this.result.expire_);
                        }
                    }
                    else
                    {
                        OSMessage.Builder builder2 = OSMessage.CreateBuilder();
                        if (this.result.hasMessage)
                        {
                            builder2.MergeFrom(this.Message);
                        }
                        input.ReadMessage(builder2, extensionRegistry);
                        this.Message = builder2.BuildPartial();
                    }
                }
                if (builder != null)
                {
                    this.UnknownFields = builder.Build();
                }
                return this;
            }

            public StartOSBatchTask.Builder SetMessage(OSMessage value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMessage = true;
                this.result.message_ = value;
                return this;
            }

            public StartOSBatchTask.Builder SetMessage(OSMessage.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMessage = true;
                this.result.message_ = builderForValue.Build();
                return this;
            }

            public StartOSBatchTask.Builder MergeMessage(OSMessage value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasMessage && this.result.message_ != OSMessage.DefaultInstance)
                {
                    this.result.message_ = OSMessage.CreateBuilder(this.result.message_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.message_ = value;
                }
                this.result.hasMessage = true;
                return this;
            }

            public StartOSBatchTask.Builder ClearMessage()
            {
                this.PrepareBuilder();
                this.result.hasMessage = false;
                this.result.message_ = null;
                return this;
            }

            public StartOSBatchTask.Builder SetExpire(long value)
            {
                this.PrepareBuilder();
                this.result.hasExpire = true;
                this.result.expire_ = value;
                return this;
            }

            public StartOSBatchTask.Builder ClearExpire()
            {
                this.PrepareBuilder();
                this.result.hasExpire = false;
                this.result.expire_ = 72L;
                return this;
            }
        }

        private static readonly StartOSBatchTask defaultInstance;

        private static readonly string[] _startOSBatchTaskFieldNames;

        private static readonly uint[] _startOSBatchTaskFieldTags;

        public const int MessageFieldNumber = 1;

        private bool hasMessage;

        private OSMessage message_;

        public const int ExpireFieldNumber = 2;

        private bool hasExpire;

        private long expire_ = 72L;

        private int memoizedSerializedSize = -1;

        public static StartOSBatchTask DefaultInstance
        {
            get
            {
                return StartOSBatchTask.defaultInstance;
            }
        }

        public override StartOSBatchTask DefaultInstanceForType
        {
            get
            {
                return StartOSBatchTask.DefaultInstance;
            }
        }

        protected override StartOSBatchTask ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_StartOSBatchTask__Descriptor;
            }
        }

        protected override FieldAccessorTable<StartOSBatchTask, StartOSBatchTask.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_StartOSBatchTask__FieldAccessorTable;
            }
        }

        public bool HasMessage
        {
            get
            {
                return this.hasMessage;
            }
        }

        public OSMessage Message
        {
            get
            {
                return this.message_ ?? OSMessage.DefaultInstance;
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
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private StartOSBatchTask()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] startOSBatchTaskFieldNames = StartOSBatchTask._startOSBatchTaskFieldNames;
            if (this.hasMessage)
            {
                output.WriteMessage(1, startOSBatchTaskFieldNames[1], this.Message);
            }
            if (this.hasExpire)
            {
                output.WriteInt64(2, startOSBatchTaskFieldNames[0], this.Expire);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static StartOSBatchTask ParseFrom(ByteString data)
        {
            return StartOSBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static StartOSBatchTask ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return StartOSBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static StartOSBatchTask ParseFrom(byte[] data)
        {
            return StartOSBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static StartOSBatchTask ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return StartOSBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static StartOSBatchTask ParseFrom(Stream input)
        {
            return StartOSBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static StartOSBatchTask ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return StartOSBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static StartOSBatchTask ParseDelimitedFrom(Stream input)
        {
            return StartOSBatchTask.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static StartOSBatchTask ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return StartOSBatchTask.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static StartOSBatchTask ParseFrom(ICodedInputStream input)
        {
            return StartOSBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static StartOSBatchTask ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return StartOSBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private StartOSBatchTask MakeReadOnly()
        {
            return this;
        }

        public static StartOSBatchTask.Builder CreateBuilder()
        {
            return new StartOSBatchTask.Builder();
        }

        public override StartOSBatchTask.Builder ToBuilder()
        {
            return StartOSBatchTask.CreateBuilder(this);
        }

        public override StartOSBatchTask.Builder CreateBuilderForType()
        {
            return new StartOSBatchTask.Builder();
        }

        public static StartOSBatchTask.Builder CreateBuilder(StartOSBatchTask prototype)
        {
            return new StartOSBatchTask.Builder(prototype);
        }

        static StartOSBatchTask()
        {
            StartOSBatchTask.defaultInstance = new StartOSBatchTask().MakeReadOnly();
            StartOSBatchTask._startOSBatchTaskFieldNames = new string[]
            {
                "expire",
                "message"
            };
            StartOSBatchTask._startOSBatchTaskFieldTags = new uint[]
            {
                16u,
                10u
            };
            FileDescriptor arg_44_0 = GtReq.Descriptor;
        }
    }
}
