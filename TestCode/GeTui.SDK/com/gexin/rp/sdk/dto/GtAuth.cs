using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class GtAuth : GeneratedMessage<GtAuth, GtAuth.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<GtAuth, GtAuth.Builder>
        {
            private bool resultIsReadOnly;

            private GtAuth result;

            protected override GtAuth.Builder ThisBuilder
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

            protected override GtAuth MessageBeingBuilt
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
                    return GtAuth.Descriptor;
                }
            }

            public override GtAuth DefaultInstanceForType
            {
                get
                {
                    return GtAuth.DefaultInstance;
                }
            }

            public bool HasSign
            {
                get
                {
                    return this.result.hasSign;
                }
            }

            public string Sign
            {
                get
                {
                    return this.result.Sign;
                }
                set
                {
                    this.SetSign(value);
                }
            }

            public bool HasAppkey
            {
                get
                {
                    return this.result.hasAppkey;
                }
            }

            public string Appkey
            {
                get
                {
                    return this.result.Appkey;
                }
                set
                {
                    this.SetAppkey(value);
                }
            }

            public bool HasTimestamp
            {
                get
                {
                    return this.result.hasTimestamp;
                }
            }

            public long Timestamp
            {
                get
                {
                    return this.result.Timestamp;
                }
                set
                {
                    this.SetTimestamp(value);
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

            public Builder()
            {
                this.result = GtAuth.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GtAuth cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private GtAuth PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GtAuth other = this.result;
                    this.result = new GtAuth();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override GtAuth.Builder Clear()
            {
                this.result = GtAuth.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override GtAuth.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GtAuth.Builder(this.result);
                }
                return new GtAuth.Builder().MergeFrom(this.result);
            }

            public override GtAuth BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GtAuth.Builder MergeFrom(IMessage other)
            {
                if (other is GtAuth)
                {
                    return this.MergeFrom((GtAuth)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GtAuth.Builder MergeFrom(GtAuth other)
            {
                if (other == GtAuth.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasSign)
                {
                    this.Sign = other.Sign;
                }
                if (other.HasAppkey)
                {
                    this.Appkey = other.Appkey;
                }
                if (other.HasTimestamp)
                {
                    this.Timestamp = other.Timestamp;
                }
                if (other.HasSeqId)
                {
                    this.SeqId = other.SeqId;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override GtAuth.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GtAuth.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(GtAuth._gtAuthFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = GtAuth._gtAuthFieldTags[num2];
                    }
                    if (num <= 10u)
                    {
                        if (num == 0u)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10u)
                        {
                            this.result.hasSign = input.ReadString(ref this.result.sign_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18u)
                        {
                            this.result.hasAppkey = input.ReadString(ref this.result.appkey_);
                            continue;
                        }
                        if (num == 24u)
                        {
                            this.result.hasTimestamp = input.ReadInt64(ref this.result.timestamp_);
                            continue;
                        }
                        if (num == 34u)
                        {
                            this.result.hasSeqId = input.ReadString(ref this.result.seqId_);
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

            public GtAuth.Builder SetSign(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSign = true;
                this.result.sign_ = value;
                return this;
            }

            public GtAuth.Builder ClearSign()
            {
                this.PrepareBuilder();
                this.result.hasSign = false;
                this.result.sign_ = "";
                return this;
            }

            public GtAuth.Builder SetAppkey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppkey = true;
                this.result.appkey_ = value;
                return this;
            }

            public GtAuth.Builder ClearAppkey()
            {
                this.PrepareBuilder();
                this.result.hasAppkey = false;
                this.result.appkey_ = "";
                return this;
            }

            public GtAuth.Builder SetTimestamp(long value)
            {
                this.PrepareBuilder();
                this.result.hasTimestamp = true;
                this.result.timestamp_ = value;
                return this;
            }

            public GtAuth.Builder ClearTimestamp()
            {
                this.PrepareBuilder();
                this.result.hasTimestamp = false;
                this.result.timestamp_ = 0L;
                return this;
            }

            public GtAuth.Builder SetSeqId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSeqId = true;
                this.result.seqId_ = value;
                return this;
            }

            public GtAuth.Builder ClearSeqId()
            {
                this.PrepareBuilder();
                this.result.hasSeqId = false;
                this.result.seqId_ = "";
                return this;
            }
        }

        private static readonly GtAuth defaultInstance;

        private static readonly string[] _gtAuthFieldNames;

        private static readonly uint[] _gtAuthFieldTags;

        public const int SignFieldNumber = 1;

        private bool hasSign;

        private string sign_ = "";

        public const int AppkeyFieldNumber = 2;

        private bool hasAppkey;

        private string appkey_ = "";

        public const int TimestampFieldNumber = 3;

        private bool hasTimestamp;

        private long timestamp_;

        public const int SeqIdFieldNumber = 4;

        private bool hasSeqId;

        private string seqId_ = "";

        private int memoizedSerializedSize = -1;

        public static GtAuth DefaultInstance
        {
            get
            {
                return GtAuth.defaultInstance;
            }
        }

        public override GtAuth DefaultInstanceForType
        {
            get
            {
                return GtAuth.DefaultInstance;
            }
        }

        protected override GtAuth ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_GtAuth__Descriptor;
            }
        }

        protected override FieldAccessorTable<GtAuth, GtAuth.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_GtAuth__FieldAccessorTable;
            }
        }

        public bool HasSign
        {
            get
            {
                return this.hasSign;
            }
        }

        public string Sign
        {
            get
            {
                return this.sign_;
            }
        }

        public bool HasAppkey
        {
            get
            {
                return this.hasAppkey;
            }
        }

        public string Appkey
        {
            get
            {
                return this.appkey_;
            }
        }

        public bool HasTimestamp
        {
            get
            {
                return this.hasTimestamp;
            }
        }

        public long Timestamp
        {
            get
            {
                return this.timestamp_;
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

        public override bool IsInitialized
        {
            get
            {
                return this.hasSign && this.hasAppkey && this.hasTimestamp;
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
                if (this.hasSign)
                {
                    num += CodedOutputStream.ComputeStringSize(1, this.Sign);
                }
                if (this.hasAppkey)
                {
                    num += CodedOutputStream.ComputeStringSize(2, this.Appkey);
                }
                if (this.hasTimestamp)
                {
                    num += CodedOutputStream.ComputeInt64Size(3, this.Timestamp);
                }
                if (this.hasSeqId)
                {
                    num += CodedOutputStream.ComputeStringSize(4, this.SeqId);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private GtAuth()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] gtAuthFieldNames = GtAuth._gtAuthFieldNames;
            if (this.hasSign)
            {
                output.WriteString(1, gtAuthFieldNames[2], this.Sign);
            }
            if (this.hasAppkey)
            {
                output.WriteString(2, gtAuthFieldNames[0], this.Appkey);
            }
            if (this.hasTimestamp)
            {
                output.WriteInt64(3, gtAuthFieldNames[3], this.Timestamp);
            }
            if (this.hasSeqId)
            {
                output.WriteString(4, gtAuthFieldNames[1], this.SeqId);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static GtAuth ParseFrom(ByteString data)
        {
            return GtAuth.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static GtAuth ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return GtAuth.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static GtAuth ParseFrom(byte[] data)
        {
            return GtAuth.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static GtAuth ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return GtAuth.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static GtAuth ParseFrom(Stream input)
        {
            return GtAuth.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static GtAuth ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return GtAuth.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static GtAuth ParseDelimitedFrom(Stream input)
        {
            return GtAuth.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static GtAuth ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return GtAuth.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static GtAuth ParseFrom(ICodedInputStream input)
        {
            return GtAuth.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static GtAuth ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return GtAuth.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private GtAuth MakeReadOnly()
        {
            return this;
        }

        public static GtAuth.Builder CreateBuilder()
        {
            return new GtAuth.Builder();
        }

        public override GtAuth.Builder ToBuilder()
        {
            return GtAuth.CreateBuilder(this);
        }

        public override GtAuth.Builder CreateBuilderForType()
        {
            return new GtAuth.Builder();
        }

        public static GtAuth.Builder CreateBuilder(GtAuth prototype)
        {
            return new GtAuth.Builder(prototype);
        }

        static GtAuth()
        {
            GtAuth.defaultInstance = new GtAuth().MakeReadOnly();
            GtAuth._gtAuthFieldNames = new string[]
            {
                "appkey",
                "seqId",
                "sign",
                "timestamp"
            };
            GtAuth._gtAuthFieldTags = new uint[]
            {
                18u,
                34u,
                10u,
                24u
            };
            FileDescriptor arg_55_0 = GtReq.Descriptor;
        }
    }
}
