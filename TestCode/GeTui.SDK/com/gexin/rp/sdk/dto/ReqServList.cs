using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class ReqServList : GeneratedMessage<ReqServList, ReqServList.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<ReqServList, ReqServList.Builder>
        {
            private bool resultIsReadOnly;

            private ReqServList result;

            protected override ReqServList.Builder ThisBuilder
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

            protected override ReqServList MessageBeingBuilt
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
                    return ReqServList.Descriptor;
                }
            }

            public override ReqServList DefaultInstanceForType
            {
                get
                {
                    return ReqServList.DefaultInstance;
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

            public Builder()
            {
                this.result = ReqServList.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ReqServList cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private ReqServList PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ReqServList other = this.result;
                    this.result = new ReqServList();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override ReqServList.Builder Clear()
            {
                this.result = ReqServList.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override ReqServList.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ReqServList.Builder(this.result);
                }
                return new ReqServList.Builder().MergeFrom(this.result);
            }

            public override ReqServList BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ReqServList.Builder MergeFrom(IMessage other)
            {
                if (other is ReqServList)
                {
                    return this.MergeFrom((ReqServList)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ReqServList.Builder MergeFrom(ReqServList other)
            {
                if (other == ReqServList.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasSeqId)
                {
                    this.SeqId = other.SeqId;
                }
                if (other.HasTimestamp)
                {
                    this.Timestamp = other.Timestamp;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override ReqServList.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ReqServList.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(ReqServList._reqServListFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = ReqServList._reqServListFieldTags[num2];
                    }
                    if (num == 0u)
                    {
                        throw InvalidProtocolBufferException.InvalidTag();
                    }
                    if (num != 10u)
                    {
                        if (num != 24u)
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
                            this.result.hasTimestamp = input.ReadInt64(ref this.result.timestamp_);
                        }
                    }
                    else
                    {
                        this.result.hasSeqId = input.ReadString(ref this.result.seqId_);
                    }
                }
                if (builder != null)
                {
                    this.UnknownFields = builder.Build();
                }
                return this;
            }

            public ReqServList.Builder SetSeqId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSeqId = true;
                this.result.seqId_ = value;
                return this;
            }

            public ReqServList.Builder ClearSeqId()
            {
                this.PrepareBuilder();
                this.result.hasSeqId = false;
                this.result.seqId_ = "";
                return this;
            }

            public ReqServList.Builder SetTimestamp(long value)
            {
                this.PrepareBuilder();
                this.result.hasTimestamp = true;
                this.result.timestamp_ = value;
                return this;
            }

            public ReqServList.Builder ClearTimestamp()
            {
                this.PrepareBuilder();
                this.result.hasTimestamp = false;
                this.result.timestamp_ = 0L;
                return this;
            }
        }

        private static readonly ReqServList defaultInstance;

        private static readonly string[] _reqServListFieldNames;

        private static readonly uint[] _reqServListFieldTags;

        public const int SeqIdFieldNumber = 1;

        private bool hasSeqId;

        private string seqId_ = "";

        public const int TimestampFieldNumber = 3;

        private bool hasTimestamp;

        private long timestamp_;

        private int memoizedSerializedSize = -1;

        public static ReqServList DefaultInstance
        {
            get
            {
                return ReqServList.defaultInstance;
            }
        }

        public override ReqServList DefaultInstanceForType
        {
            get
            {
                return ReqServList.DefaultInstance;
            }
        }

        protected override ReqServList ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_ReqServList__Descriptor;
            }
        }

        protected override FieldAccessorTable<ReqServList, ReqServList.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_ReqServList__FieldAccessorTable;
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

        public override bool IsInitialized
        {
            get
            {
                return this.hasTimestamp;
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
                if (this.hasTimestamp)
                {
                    num += CodedOutputStream.ComputeInt64Size(3, this.Timestamp);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private ReqServList()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] reqServListFieldNames = ReqServList._reqServListFieldNames;
            if (this.hasSeqId)
            {
                output.WriteString(1, reqServListFieldNames[0], this.SeqId);
            }
            if (this.hasTimestamp)
            {
                output.WriteInt64(3, reqServListFieldNames[1], this.Timestamp);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static ReqServList ParseFrom(ByteString data)
        {
            return ReqServList.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static ReqServList ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return ReqServList.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static ReqServList ParseFrom(byte[] data)
        {
            return ReqServList.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static ReqServList ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return ReqServList.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static ReqServList ParseFrom(Stream input)
        {
            return ReqServList.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static ReqServList ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return ReqServList.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static ReqServList ParseDelimitedFrom(Stream input)
        {
            return ReqServList.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static ReqServList ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return ReqServList.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static ReqServList ParseFrom(ICodedInputStream input)
        {
            return ReqServList.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static ReqServList ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return ReqServList.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private ReqServList MakeReadOnly()
        {
            return this;
        }

        public static ReqServList.Builder CreateBuilder()
        {
            return new ReqServList.Builder();
        }

        public override ReqServList.Builder ToBuilder()
        {
            return ReqServList.CreateBuilder(this);
        }

        public override ReqServList.Builder CreateBuilderForType()
        {
            return new ReqServList.Builder();
        }

        public static ReqServList.Builder CreateBuilder(ReqServList prototype)
        {
            return new ReqServList.Builder(prototype);
        }

        static ReqServList()
        {
            ReqServList.defaultInstance = new ReqServList().MakeReadOnly();
            ReqServList._reqServListFieldNames = new string[]
            {
                "seqId",
                "timestamp"
            };
            ReqServList._reqServListFieldTags = new uint[]
            {
                10u,
                24u
            };
            FileDescriptor arg_44_0 = GtReq.Descriptor;
        }
    }
}
