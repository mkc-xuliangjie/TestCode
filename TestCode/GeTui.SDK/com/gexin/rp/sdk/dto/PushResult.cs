using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class PushResult : GeneratedMessage<PushResult, PushResult.Builder>
    {
        [DebuggerNonUserCode]
        public static class Types
        {
            public enum EPushResult
            {
                successed_online,
                successed_offline,
                successed_ignore,
                failed,
                busy,
                success_startBatch,
                success_endBatch,
                successed_async
            }
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<PushResult, PushResult.Builder>
        {
            private bool resultIsReadOnly;

            private PushResult result;

            protected override PushResult.Builder ThisBuilder
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

            protected override PushResult MessageBeingBuilt
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
                    return PushResult.Descriptor;
                }
            }

            public override PushResult DefaultInstanceForType
            {
                get
                {
                    return PushResult.DefaultInstance;
                }
            }

            public bool HasResult
            {
                get
                {
                    return this.result.hasResult;
                }
            }

            public PushResult.Types.EPushResult Result
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

            public bool HasTarget
            {
                get
                {
                    return this.result.hasTarget;
                }
            }

            public string Target
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

            public bool HasTraceId
            {
                get
                {
                    return this.result.hasTraceId;
                }
            }

            public string TraceId
            {
                get
                {
                    return this.result.TraceId;
                }
                set
                {
                    this.SetTraceId(value);
                }
            }

            public bool HasBatchId
            {
                get
                {
                    return this.result.hasBatchId;
                }
            }

            public string BatchId
            {
                get
                {
                    return this.result.BatchId;
                }
                set
                {
                    this.SetBatchId(value);
                }
            }

            public Builder()
            {
                this.result = PushResult.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(PushResult cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private PushResult PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    PushResult other = this.result;
                    this.result = new PushResult();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override PushResult.Builder Clear()
            {
                this.result = PushResult.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override PushResult.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new PushResult.Builder(this.result);
                }
                return new PushResult.Builder().MergeFrom(this.result);
            }

            public override PushResult BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override PushResult.Builder MergeFrom(IMessage other)
            {
                if (other is PushResult)
                {
                    return this.MergeFrom((PushResult)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override PushResult.Builder MergeFrom(PushResult other)
            {
                if (other == PushResult.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasResult)
                {
                    this.Result = other.Result;
                }
                if (other.HasTaskId)
                {
                    this.TaskId = other.TaskId;
                }
                if (other.HasMessageId)
                {
                    this.MessageId = other.MessageId;
                }
                if (other.HasSeqId)
                {
                    this.SeqId = other.SeqId;
                }
                if (other.HasTarget)
                {
                    this.Target = other.Target;
                }
                if (other.HasInfo)
                {
                    this.Info = other.Info;
                }
                if (other.HasTraceId)
                {
                    this.TraceId = other.TraceId;
                }
                if (other.HasBatchId)
                {
                    this.BatchId = other.BatchId;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override PushResult.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override PushResult.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(PushResult._pushResultFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = PushResult._pushResultFieldTags[num2];
                    }
                    if (num <= 26u)
                    {
                        if (num <= 8u)
                        {
                            if (num == 0u)
                            {
                                throw InvalidProtocolBufferException.InvalidTag();
                            }
                            if (num == 8u)
                            {
                                object obj;
                                if (input.ReadEnum<PushResult.Types.EPushResult>(ref this.result.result_, out obj))
                                {
                                    this.result.hasResult = true;
                                    continue;
                                }
                                if (obj is int)
                                {
                                    if (builder == null)
                                    {
                                        builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                                    }
                                    builder.MergeVarintField(1, (ulong)((long)((int)obj)));
                                    continue;
                                }
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 18u)
                            {
                                this.result.hasTaskId = input.ReadString(ref this.result.taskId_);
                                continue;
                            }
                            if (num == 26u)
                            {
                                this.result.hasMessageId = input.ReadString(ref this.result.messageId_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 42u)
                    {
                        if (num == 34u)
                        {
                            this.result.hasSeqId = input.ReadString(ref this.result.seqId_);
                            continue;
                        }
                        if (num == 42u)
                        {
                            this.result.hasTarget = input.ReadString(ref this.result.target_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 50u)
                        {
                            this.result.hasInfo = input.ReadString(ref this.result.info_);
                            continue;
                        }
                        if (num == 58u)
                        {
                            this.result.hasTraceId = input.ReadString(ref this.result.traceId_);
                            continue;
                        }
                        if (num == 66u)
                        {
                            this.result.hasBatchId = input.ReadString(ref this.result.batchId_);
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

            public PushResult.Builder SetResult(PushResult.Types.EPushResult value)
            {
                this.PrepareBuilder();
                this.result.hasResult = true;
                this.result.result_ = value;
                return this;
            }

            public PushResult.Builder ClearResult()
            {
                this.PrepareBuilder();
                this.result.hasResult = false;
                this.result.result_ = PushResult.Types.EPushResult.successed_online;
                return this;
            }

            public PushResult.Builder SetTaskId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTaskId = true;
                this.result.taskId_ = value;
                return this;
            }

            public PushResult.Builder ClearTaskId()
            {
                this.PrepareBuilder();
                this.result.hasTaskId = false;
                this.result.taskId_ = "";
                return this;
            }

            public PushResult.Builder SetMessageId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMessageId = true;
                this.result.messageId_ = value;
                return this;
            }

            public PushResult.Builder ClearMessageId()
            {
                this.PrepareBuilder();
                this.result.hasMessageId = false;
                this.result.messageId_ = "";
                return this;
            }

            public PushResult.Builder SetSeqId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSeqId = true;
                this.result.seqId_ = value;
                return this;
            }

            public PushResult.Builder ClearSeqId()
            {
                this.PrepareBuilder();
                this.result.hasSeqId = false;
                this.result.seqId_ = "";
                return this;
            }

            public PushResult.Builder SetTarget(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTarget = true;
                this.result.target_ = value;
                return this;
            }

            public PushResult.Builder ClearTarget()
            {
                this.PrepareBuilder();
                this.result.hasTarget = false;
                this.result.target_ = "";
                return this;
            }

            public PushResult.Builder SetInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasInfo = true;
                this.result.info_ = value;
                return this;
            }

            public PushResult.Builder ClearInfo()
            {
                this.PrepareBuilder();
                this.result.hasInfo = false;
                this.result.info_ = "";
                return this;
            }

            public PushResult.Builder SetTraceId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTraceId = true;
                this.result.traceId_ = value;
                return this;
            }

            public PushResult.Builder ClearTraceId()
            {
                this.PrepareBuilder();
                this.result.hasTraceId = false;
                this.result.traceId_ = "";
                return this;
            }

            public PushResult.Builder SetBatchId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBatchId = true;
                this.result.batchId_ = value;
                return this;
            }

            public PushResult.Builder ClearBatchId()
            {
                this.PrepareBuilder();
                this.result.hasBatchId = false;
                this.result.batchId_ = "";
                return this;
            }
        }

        private static readonly PushResult defaultInstance;

        private static readonly string[] _pushResultFieldNames;

        private static readonly uint[] _pushResultFieldTags;

        public const int ResultFieldNumber = 1;

        private bool hasResult;

        private PushResult.Types.EPushResult result_;

        public const int TaskIdFieldNumber = 2;

        private bool hasTaskId;

        private string taskId_ = "";

        public const int MessageIdFieldNumber = 3;

        private bool hasMessageId;

        private string messageId_ = "";

        public const int SeqIdFieldNumber = 4;

        private bool hasSeqId;

        private string seqId_ = "";

        public const int TargetFieldNumber = 5;

        private bool hasTarget;

        private string target_ = "";

        public const int InfoFieldNumber = 6;

        private bool hasInfo;

        private string info_ = "";

        public const int TraceIdFieldNumber = 7;

        private bool hasTraceId;

        private string traceId_ = "";

        public const int BatchIdFieldNumber = 8;

        private bool hasBatchId;

        private string batchId_ = "";

        private int memoizedSerializedSize = -1;

        public static PushResult DefaultInstance
        {
            get
            {
                return PushResult.defaultInstance;
            }
        }

        public override PushResult DefaultInstanceForType
        {
            get
            {
                return PushResult.DefaultInstance;
            }
        }

        protected override PushResult ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushResult__Descriptor;
            }
        }

        protected override FieldAccessorTable<PushResult, PushResult.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushResult__FieldAccessorTable;
            }
        }

        public bool HasResult
        {
            get
            {
                return this.hasResult;
            }
        }

        public PushResult.Types.EPushResult Result
        {
            get
            {
                return this.result_;
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

        public bool HasTarget
        {
            get
            {
                return this.hasTarget;
            }
        }

        public string Target
        {
            get
            {
                return this.target_;
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

        public bool HasTraceId
        {
            get
            {
                return this.hasTraceId;
            }
        }

        public string TraceId
        {
            get
            {
                return this.traceId_;
            }
        }

        public bool HasBatchId
        {
            get
            {
                return this.hasBatchId;
            }
        }

        public string BatchId
        {
            get
            {
                return this.batchId_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                return this.hasResult && this.hasTaskId && this.hasMessageId && this.hasSeqId && this.hasTarget;
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
                    num += CodedOutputStream.ComputeEnumSize(1, (int)this.Result);
                }
                if (this.hasTaskId)
                {
                    num += CodedOutputStream.ComputeStringSize(2, this.TaskId);
                }
                if (this.hasMessageId)
                {
                    num += CodedOutputStream.ComputeStringSize(3, this.MessageId);
                }
                if (this.hasSeqId)
                {
                    num += CodedOutputStream.ComputeStringSize(4, this.SeqId);
                }
                if (this.hasTarget)
                {
                    num += CodedOutputStream.ComputeStringSize(5, this.Target);
                }
                if (this.hasInfo)
                {
                    num += CodedOutputStream.ComputeStringSize(6, this.Info);
                }
                if (this.hasTraceId)
                {
                    num += CodedOutputStream.ComputeStringSize(7, this.TraceId);
                }
                if (this.hasBatchId)
                {
                    num += CodedOutputStream.ComputeStringSize(8, this.BatchId);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private PushResult()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] pushResultFieldNames = PushResult._pushResultFieldNames;
            if (this.hasResult)
            {
                output.WriteEnum(1, pushResultFieldNames[3], (int)this.Result, this.Result);
            }
            if (this.hasTaskId)
            {
                output.WriteString(2, pushResultFieldNames[6], this.TaskId);
            }
            if (this.hasMessageId)
            {
                output.WriteString(3, pushResultFieldNames[2], this.MessageId);
            }
            if (this.hasSeqId)
            {
                output.WriteString(4, pushResultFieldNames[4], this.SeqId);
            }
            if (this.hasTarget)
            {
                output.WriteString(5, pushResultFieldNames[5], this.Target);
            }
            if (this.hasInfo)
            {
                output.WriteString(6, pushResultFieldNames[1], this.Info);
            }
            if (this.hasTraceId)
            {
                output.WriteString(7, pushResultFieldNames[7], this.TraceId);
            }
            if (this.hasBatchId)
            {
                output.WriteString(8, pushResultFieldNames[0], this.BatchId);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static PushResult ParseFrom(ByteString data)
        {
            return PushResult.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushResult ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return PushResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushResult ParseFrom(byte[] data)
        {
            return PushResult.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushResult ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return PushResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushResult ParseFrom(Stream input)
        {
            return PushResult.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushResult ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushResult ParseDelimitedFrom(Stream input)
        {
            return PushResult.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static PushResult ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushResult.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushResult ParseFrom(ICodedInputStream input)
        {
            return PushResult.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushResult ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return PushResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private PushResult MakeReadOnly()
        {
            return this;
        }

        public static PushResult.Builder CreateBuilder()
        {
            return new PushResult.Builder();
        }

        public override PushResult.Builder ToBuilder()
        {
            return PushResult.CreateBuilder(this);
        }

        public override PushResult.Builder CreateBuilderForType()
        {
            return new PushResult.Builder();
        }

        public static PushResult.Builder CreateBuilder(PushResult prototype)
        {
            return new PushResult.Builder(prototype);
        }

        static PushResult()
        {
            PushResult.defaultInstance = new PushResult().MakeReadOnly();
            PushResult._pushResultFieldNames = new string[]
            {
                "batchId",
                "info",
                "messageId",
                "result",
                "seqId",
                "target",
                "taskId",
                "traceId"
            };
            PushResult._pushResultFieldTags = new uint[]
            {
                66u,
                50u,
                26u,
                8u,
                34u,
                42u,
                18u,
                58u
            };
            FileDescriptor arg_75_0 = GtReq.Descriptor;
        }
    }
}
