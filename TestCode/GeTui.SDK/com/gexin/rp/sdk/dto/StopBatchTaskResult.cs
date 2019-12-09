using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class StopBatchTaskResult : GeneratedMessage<StopBatchTaskResult, StopBatchTaskResult.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<StopBatchTaskResult, StopBatchTaskResult.Builder>
        {
            private bool resultIsReadOnly;

            private StopBatchTaskResult result;

            protected override StopBatchTaskResult.Builder ThisBuilder
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

            protected override StopBatchTaskResult MessageBeingBuilt
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
                    return StopBatchTaskResult.Descriptor;
                }
            }

            public override StopBatchTaskResult DefaultInstanceForType
            {
                get
                {
                    return StopBatchTaskResult.DefaultInstance;
                }
            }

            public bool HasResult
            {
                get
                {
                    return this.result.hasResult;
                }
            }

            public bool Result
            {
                get
                {
                    return this.result.Result;
                }
                set
                {
                    this.SetResult(value);
                }
            }

            public bool HasInfo
            {
                get
                {
                    return this.result.hasInfo;
                }
            }

            public string Info
            {
                get
                {
                    return this.result.Info;
                }
                set
                {
                    this.SetInfo(value);
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
                this.result = StopBatchTaskResult.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(StopBatchTaskResult cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private StopBatchTaskResult PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    StopBatchTaskResult other = this.result;
                    this.result = new StopBatchTaskResult();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override StopBatchTaskResult.Builder Clear()
            {
                this.result = StopBatchTaskResult.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override StopBatchTaskResult.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new StopBatchTaskResult.Builder(this.result);
                }
                return new StopBatchTaskResult.Builder().MergeFrom(this.result);
            }

            public override StopBatchTaskResult BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override StopBatchTaskResult.Builder MergeFrom(IMessage other)
            {
                if (other is StopBatchTaskResult)
                {
                    return this.MergeFrom((StopBatchTaskResult)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override StopBatchTaskResult.Builder MergeFrom(StopBatchTaskResult other)
            {
                if (other == StopBatchTaskResult.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasResult)
                {
                    this.Result = other.Result;
                }
                if (other.HasInfo)
                {
                    this.Info = other.Info;
                }
                if (other.HasSeqId)
                {
                    this.SeqId = other.SeqId;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override StopBatchTaskResult.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override StopBatchTaskResult.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(StopBatchTaskResult._stopBatchTaskResultFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = StopBatchTaskResult._stopBatchTaskResultFieldTags[num2];
                    }
                    if (num <= 8u)
                    {
                        if (num == 0u)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 8u)
                        {
                            this.result.hasResult = input.ReadBool(ref this.result.result_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18u)
                        {
                            this.result.hasInfo = input.ReadString(ref this.result.info_);
                            continue;
                        }
                        if (num == 26u)
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

            public StopBatchTaskResult.Builder SetResult(bool value)
            {
                this.PrepareBuilder();
                this.result.hasResult = true;
                this.result.result_ = value;
                return this;
            }

            public StopBatchTaskResult.Builder ClearResult()
            {
                this.PrepareBuilder();
                this.result.hasResult = false;
                this.result.result_ = false;
                return this;
            }

            public StopBatchTaskResult.Builder SetInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasInfo = true;
                this.result.info_ = value;
                return this;
            }

            public StopBatchTaskResult.Builder ClearInfo()
            {
                this.PrepareBuilder();
                this.result.hasInfo = false;
                this.result.info_ = "";
                return this;
            }

            public StopBatchTaskResult.Builder SetSeqId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSeqId = true;
                this.result.seqId_ = value;
                return this;
            }

            public StopBatchTaskResult.Builder ClearSeqId()
            {
                this.PrepareBuilder();
                this.result.hasSeqId = false;
                this.result.seqId_ = "";
                return this;
            }
        }

        private static readonly StopBatchTaskResult defaultInstance;

        private static readonly string[] _stopBatchTaskResultFieldNames;

        private static readonly uint[] _stopBatchTaskResultFieldTags;

        public const int ResultFieldNumber = 1;

        private bool hasResult;

        private bool result_;

        public const int InfoFieldNumber = 2;

        private bool hasInfo;

        private string info_ = "";

        public const int SeqIdFieldNumber = 3;

        private bool hasSeqId;

        private string seqId_ = "";

        private int memoizedSerializedSize = -1;

        public static StopBatchTaskResult DefaultInstance
        {
            get
            {
                return StopBatchTaskResult.defaultInstance;
            }
        }

        public override StopBatchTaskResult DefaultInstanceForType
        {
            get
            {
                return StopBatchTaskResult.DefaultInstance;
            }
        }

        protected override StopBatchTaskResult ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_StopBatchTaskResult__Descriptor;
            }
        }

        protected override FieldAccessorTable<StopBatchTaskResult, StopBatchTaskResult.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_StopBatchTaskResult__FieldAccessorTable;
            }
        }

        public bool HasResult
        {
            get
            {
                return this.hasResult;
            }
        }

        public bool Result
        {
            get
            {
                return this.result_;
            }
        }

        public bool HasInfo
        {
            get
            {
                return this.hasInfo;
            }
        }

        public string Info
        {
            get
            {
                return this.info_;
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
                return this.hasResult;
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
                if (this.hasResult)
                {
                    num += CodedOutputStream.ComputeBoolSize(1, this.Result);
                }
                if (this.hasInfo)
                {
                    num += CodedOutputStream.ComputeStringSize(2, this.Info);
                }
                if (this.hasSeqId)
                {
                    num += CodedOutputStream.ComputeStringSize(3, this.SeqId);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private StopBatchTaskResult()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] stopBatchTaskResultFieldNames = StopBatchTaskResult._stopBatchTaskResultFieldNames;
            if (this.hasResult)
            {
                output.WriteBool(1, stopBatchTaskResultFieldNames[1], this.Result);
            }
            if (this.hasInfo)
            {
                output.WriteString(2, stopBatchTaskResultFieldNames[0], this.Info);
            }
            if (this.hasSeqId)
            {
                output.WriteString(3, stopBatchTaskResultFieldNames[2], this.SeqId);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static StopBatchTaskResult ParseFrom(ByteString data)
        {
            return StopBatchTaskResult.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static StopBatchTaskResult ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return StopBatchTaskResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static StopBatchTaskResult ParseFrom(byte[] data)
        {
            return StopBatchTaskResult.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static StopBatchTaskResult ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return StopBatchTaskResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static StopBatchTaskResult ParseFrom(Stream input)
        {
            return StopBatchTaskResult.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static StopBatchTaskResult ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return StopBatchTaskResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static StopBatchTaskResult ParseDelimitedFrom(Stream input)
        {
            return StopBatchTaskResult.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static StopBatchTaskResult ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return StopBatchTaskResult.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static StopBatchTaskResult ParseFrom(ICodedInputStream input)
        {
            return StopBatchTaskResult.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static StopBatchTaskResult ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return StopBatchTaskResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private StopBatchTaskResult MakeReadOnly()
        {
            return this;
        }

        public static StopBatchTaskResult.Builder CreateBuilder()
        {
            return new StopBatchTaskResult.Builder();
        }

        public override StopBatchTaskResult.Builder ToBuilder()
        {
            return StopBatchTaskResult.CreateBuilder(this);
        }

        public override StopBatchTaskResult.Builder CreateBuilderForType()
        {
            return new StopBatchTaskResult.Builder();
        }

        public static StopBatchTaskResult.Builder CreateBuilder(StopBatchTaskResult prototype)
        {
            return new StopBatchTaskResult.Builder(prototype);
        }

        static StopBatchTaskResult()
        {
            StopBatchTaskResult.defaultInstance = new StopBatchTaskResult().MakeReadOnly();
            StopBatchTaskResult._stopBatchTaskResultFieldNames = new string[]
            {
                "info",
                "result",
                "seqId"
            };
            StopBatchTaskResult._stopBatchTaskResultFieldTags = new uint[]
            {
                18u,
                8u,
                26u
            };
            FileDescriptor arg_4D_0 = GtReq.Descriptor;
        }
    }
}
