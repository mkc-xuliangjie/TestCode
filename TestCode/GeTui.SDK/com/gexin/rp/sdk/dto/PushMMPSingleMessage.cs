using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class PushMMPSingleMessage : GeneratedMessage<PushMMPSingleMessage, PushMMPSingleMessage.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<PushMMPSingleMessage, PushMMPSingleMessage.Builder>
        {
            private bool resultIsReadOnly;

            private PushMMPSingleMessage result;

            protected override PushMMPSingleMessage.Builder ThisBuilder
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

            protected override PushMMPSingleMessage MessageBeingBuilt
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
                    return PushMMPSingleMessage.Descriptor;
                }
            }

            public override PushMMPSingleMessage DefaultInstanceForType
            {
                get
                {
                    return PushMMPSingleMessage.DefaultInstance;
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

            public bool HasTarget
            {
                get
                {
                    return this.result.hasTarget;
                }
            }

            public Target Target
            {
                get
                {
                    return this.result.Target;
                }
                set
                {
                    this.SetTarget(value);
                }
            }

            public bool HasRequestId
            {
                get
                {
                    return this.result.hasRequestId;
                }
            }

            public string RequestId
            {
                get
                {
                    return this.result.RequestId;
                }
                set
                {
                    this.SetRequestId(value);
                }
            }

            public Builder()
            {
                this.result = PushMMPSingleMessage.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(PushMMPSingleMessage cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private PushMMPSingleMessage PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    PushMMPSingleMessage other = this.result;
                    this.result = new PushMMPSingleMessage();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override PushMMPSingleMessage.Builder Clear()
            {
                this.result = PushMMPSingleMessage.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override PushMMPSingleMessage.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new PushMMPSingleMessage.Builder(this.result);
                }
                return new PushMMPSingleMessage.Builder().MergeFrom(this.result);
            }

            public override PushMMPSingleMessage BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override PushMMPSingleMessage.Builder MergeFrom(IMessage other)
            {
                if (other is PushMMPSingleMessage)
                {
                    return this.MergeFrom((PushMMPSingleMessage)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override PushMMPSingleMessage.Builder MergeFrom(PushMMPSingleMessage other)
            {
                if (other == PushMMPSingleMessage.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasSeqId)
                {
                    this.SeqId = other.SeqId;
                }
                if (other.HasMessage)
                {
                    this.MergeMessage(other.Message);
                }
                if (other.HasTarget)
                {
                    this.MergeTarget(other.Target);
                }
                if (other.HasRequestId)
                {
                    this.RequestId = other.RequestId;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override PushMMPSingleMessage.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override PushMMPSingleMessage.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(PushMMPSingleMessage._pushMMPSingleMessageFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = PushMMPSingleMessage._pushMMPSingleMessageFieldTags[num2];
                    }
                    if (num <= 10u)
                    {
                        if (num == 0u)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10u)
                        {
                            this.result.hasSeqId = input.ReadString(ref this.result.seqId_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18u)
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
                        if (num == 26u)
                        {
                            Target.Builder builder3 = Target.CreateBuilder();
                            if (this.result.hasTarget)
                            {
                                builder3.MergeFrom(this.Target);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.Target = builder3.BuildPartial();
                            continue;
                        }
                        if (num == 34u)
                        {
                            this.result.hasRequestId = input.ReadString(ref this.result.requestId_);
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

            public PushMMPSingleMessage.Builder SetSeqId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSeqId = true;
                this.result.seqId_ = value;
                return this;
            }

            public PushMMPSingleMessage.Builder ClearSeqId()
            {
                this.PrepareBuilder();
                this.result.hasSeqId = false;
                this.result.seqId_ = "";
                return this;
            }

            public PushMMPSingleMessage.Builder SetMessage(MMPMessage value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMessage = true;
                this.result.message_ = value;
                return this;
            }

            public PushMMPSingleMessage.Builder SetMessage(MMPMessage.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMessage = true;
                this.result.message_ = builderForValue.Build();
                return this;
            }

            public PushMMPSingleMessage.Builder MergeMessage(MMPMessage value)
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

            public PushMMPSingleMessage.Builder ClearMessage()
            {
                this.PrepareBuilder();
                this.result.hasMessage = false;
                this.result.message_ = null;
                return this;
            }

            public PushMMPSingleMessage.Builder SetTarget(Target value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTarget = true;
                this.result.target_ = value;
                return this;
            }

            public PushMMPSingleMessage.Builder SetTarget(Target.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasTarget = true;
                this.result.target_ = builderForValue.Build();
                return this;
            }

            public PushMMPSingleMessage.Builder MergeTarget(Target value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasTarget && this.result.target_ != Target.DefaultInstance)
                {
                    this.result.target_ = Target.CreateBuilder(this.result.target_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.target_ = value;
                }
                this.result.hasTarget = true;
                return this;
            }

            public PushMMPSingleMessage.Builder ClearTarget()
            {
                this.PrepareBuilder();
                this.result.hasTarget = false;
                this.result.target_ = null;
                return this;
            }

            public PushMMPSingleMessage.Builder SetRequestId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRequestId = true;
                this.result.requestId_ = value;
                return this;
            }

            public PushMMPSingleMessage.Builder ClearRequestId()
            {
                this.PrepareBuilder();
                this.result.hasRequestId = false;
                this.result.requestId_ = "";
                return this;
            }
        }

        private static readonly PushMMPSingleMessage defaultInstance;

        private static readonly string[] _pushMMPSingleMessageFieldNames;

        private static readonly uint[] _pushMMPSingleMessageFieldTags;

        public const int SeqIdFieldNumber = 1;

        private bool hasSeqId;

        private string seqId_ = "";

        public const int MessageFieldNumber = 2;

        private bool hasMessage;

        private MMPMessage message_;

        public const int TargetFieldNumber = 3;

        private bool hasTarget;

        private Target target_;

        public const int RequestIdFieldNumber = 4;

        private bool hasRequestId;

        private string requestId_ = "";

        private int memoizedSerializedSize = -1;

        public static PushMMPSingleMessage DefaultInstance
        {
            get
            {
                return PushMMPSingleMessage.defaultInstance;
            }
        }

        public override PushMMPSingleMessage DefaultInstanceForType
        {
            get
            {
                return PushMMPSingleMessage.DefaultInstance;
            }
        }

        protected override PushMMPSingleMessage ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPSingleMessage__Descriptor;
            }
        }

        protected override FieldAccessorTable<PushMMPSingleMessage, PushMMPSingleMessage.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPSingleMessage__FieldAccessorTable;
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

        public bool HasTarget
        {
            get
            {
                return this.hasTarget;
            }
        }

        public Target Target
        {
            get
            {
                return this.target_ ?? Target.DefaultInstance;
            }
        }

        public bool HasRequestId
        {
            get
            {
                return this.hasRequestId;
            }
        }

        public string RequestId
        {
            get
            {
                return this.requestId_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                return this.hasSeqId && this.hasMessage && this.hasTarget && this.Message.IsInitialized && this.Target.IsInitialized;
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
                if (this.hasSeqId)
                {
                    num += CodedOutputStream.ComputeStringSize(1, this.SeqId);
                }
                if (this.hasMessage)
                {
                    num += CodedOutputStream.ComputeMessageSize(2, this.Message);
                }
                if (this.hasTarget)
                {
                    num += CodedOutputStream.ComputeMessageSize(3, this.Target);
                }
                if (this.hasRequestId)
                {
                    num += CodedOutputStream.ComputeStringSize(4, this.RequestId);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private PushMMPSingleMessage()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] pushMMPSingleMessageFieldNames = PushMMPSingleMessage._pushMMPSingleMessageFieldNames;
            if (this.hasSeqId)
            {
                output.WriteString(1, pushMMPSingleMessageFieldNames[2], this.SeqId);
            }
            if (this.hasMessage)
            {
                output.WriteMessage(2, pushMMPSingleMessageFieldNames[0], this.Message);
            }
            if (this.hasTarget)
            {
                output.WriteMessage(3, pushMMPSingleMessageFieldNames[3], this.Target);
            }
            if (this.hasRequestId)
            {
                output.WriteString(4, pushMMPSingleMessageFieldNames[1], this.RequestId);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static PushMMPSingleMessage ParseFrom(ByteString data)
        {
            return PushMMPSingleMessage.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushMMPSingleMessage ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return PushMMPSingleMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushMMPSingleMessage ParseFrom(byte[] data)
        {
            return PushMMPSingleMessage.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushMMPSingleMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return PushMMPSingleMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushMMPSingleMessage ParseFrom(Stream input)
        {
            return PushMMPSingleMessage.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushMMPSingleMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushMMPSingleMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushMMPSingleMessage ParseDelimitedFrom(Stream input)
        {
            return PushMMPSingleMessage.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static PushMMPSingleMessage ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushMMPSingleMessage.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushMMPSingleMessage ParseFrom(ICodedInputStream input)
        {
            return PushMMPSingleMessage.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushMMPSingleMessage ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return PushMMPSingleMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private PushMMPSingleMessage MakeReadOnly()
        {
            return this;
        }

        public static PushMMPSingleMessage.Builder CreateBuilder()
        {
            return new PushMMPSingleMessage.Builder();
        }

        public override PushMMPSingleMessage.Builder ToBuilder()
        {
            return PushMMPSingleMessage.CreateBuilder(this);
        }

        public override PushMMPSingleMessage.Builder CreateBuilderForType()
        {
            return new PushMMPSingleMessage.Builder();
        }

        public static PushMMPSingleMessage.Builder CreateBuilder(PushMMPSingleMessage prototype)
        {
            return new PushMMPSingleMessage.Builder(prototype);
        }

        static PushMMPSingleMessage()
        {
            PushMMPSingleMessage.defaultInstance = new PushMMPSingleMessage().MakeReadOnly();
            PushMMPSingleMessage._pushMMPSingleMessageFieldNames = new string[]
            {
                "message",
                "requestId",
                "seqId",
                "target"
            };
            PushMMPSingleMessage._pushMMPSingleMessageFieldTags = new uint[]
            {
                18u,
                34u,
                10u,
                26u
            };
            FileDescriptor arg_55_0 = GtReq.Descriptor;
        }
    }
}
