using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class PushOSSingleMessage : GeneratedMessage<PushOSSingleMessage, PushOSSingleMessage.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<PushOSSingleMessage, PushOSSingleMessage.Builder>
        {
            private bool resultIsReadOnly;

            private PushOSSingleMessage result;

            protected override PushOSSingleMessage.Builder ThisBuilder
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

            protected override PushOSSingleMessage MessageBeingBuilt
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
                    return PushOSSingleMessage.Descriptor;
                }
            }

            public override PushOSSingleMessage DefaultInstanceForType
            {
                get
                {
                    return PushOSSingleMessage.DefaultInstance;
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

            public Builder()
            {
                this.result = PushOSSingleMessage.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(PushOSSingleMessage cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private PushOSSingleMessage PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    PushOSSingleMessage other = this.result;
                    this.result = new PushOSSingleMessage();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override PushOSSingleMessage.Builder Clear()
            {
                this.result = PushOSSingleMessage.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override PushOSSingleMessage.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new PushOSSingleMessage.Builder(this.result);
                }
                return new PushOSSingleMessage.Builder().MergeFrom(this.result);
            }

            public override PushOSSingleMessage BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override PushOSSingleMessage.Builder MergeFrom(IMessage other)
            {
                if (other is PushOSSingleMessage)
                {
                    return this.MergeFrom((PushOSSingleMessage)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override PushOSSingleMessage.Builder MergeFrom(PushOSSingleMessage other)
            {
                if (other == PushOSSingleMessage.DefaultInstance)
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
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override PushOSSingleMessage.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override PushOSSingleMessage.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(PushOSSingleMessage._pushOSSingleMessageFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = PushOSSingleMessage._pushOSSingleMessageFieldTags[num2];
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
                            OSMessage.Builder builder2 = OSMessage.CreateBuilder();
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

            public PushOSSingleMessage.Builder SetSeqId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSeqId = true;
                this.result.seqId_ = value;
                return this;
            }

            public PushOSSingleMessage.Builder ClearSeqId()
            {
                this.PrepareBuilder();
                this.result.hasSeqId = false;
                this.result.seqId_ = "";
                return this;
            }

            public PushOSSingleMessage.Builder SetMessage(OSMessage value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMessage = true;
                this.result.message_ = value;
                return this;
            }

            public PushOSSingleMessage.Builder SetMessage(OSMessage.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMessage = true;
                this.result.message_ = builderForValue.Build();
                return this;
            }

            public PushOSSingleMessage.Builder MergeMessage(OSMessage value)
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

            public PushOSSingleMessage.Builder ClearMessage()
            {
                this.PrepareBuilder();
                this.result.hasMessage = false;
                this.result.message_ = null;
                return this;
            }

            public PushOSSingleMessage.Builder SetTarget(Target value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTarget = true;
                this.result.target_ = value;
                return this;
            }

            public PushOSSingleMessage.Builder SetTarget(Target.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasTarget = true;
                this.result.target_ = builderForValue.Build();
                return this;
            }

            public PushOSSingleMessage.Builder MergeTarget(Target value)
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

            public PushOSSingleMessage.Builder ClearTarget()
            {
                this.PrepareBuilder();
                this.result.hasTarget = false;
                this.result.target_ = null;
                return this;
            }
        }

        private static readonly PushOSSingleMessage defaultInstance;

        private static readonly string[] _pushOSSingleMessageFieldNames;

        private static readonly uint[] _pushOSSingleMessageFieldTags;

        public const int SeqIdFieldNumber = 1;

        private bool hasSeqId;

        private string seqId_ = "";

        public const int MessageFieldNumber = 2;

        private bool hasMessage;

        private OSMessage message_;

        public const int TargetFieldNumber = 3;

        private bool hasTarget;

        private Target target_;

        private int memoizedSerializedSize = -1;

        public static PushOSSingleMessage DefaultInstance
        {
            get
            {
                return PushOSSingleMessage.defaultInstance;
            }
        }

        public override PushOSSingleMessage DefaultInstanceForType
        {
            get
            {
                return PushOSSingleMessage.DefaultInstance;
            }
        }

        protected override PushOSSingleMessage ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushOSSingleMessage__Descriptor;
            }
        }

        protected override FieldAccessorTable<PushOSSingleMessage, PushOSSingleMessage.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushOSSingleMessage__FieldAccessorTable;
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

        public OSMessage Message
        {
            get
            {
                return this.message_ ?? OSMessage.DefaultInstance;
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
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private PushOSSingleMessage()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] pushOSSingleMessageFieldNames = PushOSSingleMessage._pushOSSingleMessageFieldNames;
            if (this.hasSeqId)
            {
                output.WriteString(1, pushOSSingleMessageFieldNames[1], this.SeqId);
            }
            if (this.hasMessage)
            {
                output.WriteMessage(2, pushOSSingleMessageFieldNames[0], this.Message);
            }
            if (this.hasTarget)
            {
                output.WriteMessage(3, pushOSSingleMessageFieldNames[2], this.Target);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static PushOSSingleMessage ParseFrom(ByteString data)
        {
            return PushOSSingleMessage.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushOSSingleMessage ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return PushOSSingleMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushOSSingleMessage ParseFrom(byte[] data)
        {
            return PushOSSingleMessage.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushOSSingleMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return PushOSSingleMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushOSSingleMessage ParseFrom(Stream input)
        {
            return PushOSSingleMessage.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushOSSingleMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushOSSingleMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushOSSingleMessage ParseDelimitedFrom(Stream input)
        {
            return PushOSSingleMessage.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static PushOSSingleMessage ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushOSSingleMessage.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushOSSingleMessage ParseFrom(ICodedInputStream input)
        {
            return PushOSSingleMessage.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushOSSingleMessage ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return PushOSSingleMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private PushOSSingleMessage MakeReadOnly()
        {
            return this;
        }

        public static PushOSSingleMessage.Builder CreateBuilder()
        {
            return new PushOSSingleMessage.Builder();
        }

        public override PushOSSingleMessage.Builder ToBuilder()
        {
            return PushOSSingleMessage.CreateBuilder(this);
        }

        public override PushOSSingleMessage.Builder CreateBuilderForType()
        {
            return new PushOSSingleMessage.Builder();
        }

        public static PushOSSingleMessage.Builder CreateBuilder(PushOSSingleMessage prototype)
        {
            return new PushOSSingleMessage.Builder(prototype);
        }

        static PushOSSingleMessage()
        {
            PushOSSingleMessage.defaultInstance = new PushOSSingleMessage().MakeReadOnly();
            PushOSSingleMessage._pushOSSingleMessageFieldNames = new string[]
            {
                "message",
                "seqId",
                "target"
            };
            PushOSSingleMessage._pushOSSingleMessageFieldTags = new uint[]
            {
                18u,
                10u,
                26u
            };
            FileDescriptor arg_4D_0 = GtReq.Descriptor;
        }
    }
}
