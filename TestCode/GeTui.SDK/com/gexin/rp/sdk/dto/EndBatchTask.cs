using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class EndBatchTask : GeneratedMessage<EndBatchTask, EndBatchTask.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<EndBatchTask, EndBatchTask.Builder>
        {
            private bool resultIsReadOnly;

            private EndBatchTask result;

            protected override EndBatchTask.Builder ThisBuilder
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

            protected override EndBatchTask MessageBeingBuilt
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
                    return EndBatchTask.Descriptor;
                }
            }

            public override EndBatchTask DefaultInstanceForType
            {
                get
                {
                    return EndBatchTask.DefaultInstance;
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
                this.result = EndBatchTask.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(EndBatchTask cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private EndBatchTask PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    EndBatchTask other = this.result;
                    this.result = new EndBatchTask();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override EndBatchTask.Builder Clear()
            {
                this.result = EndBatchTask.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override EndBatchTask.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new EndBatchTask.Builder(this.result);
                }
                return new EndBatchTask.Builder().MergeFrom(this.result);
            }

            public override EndBatchTask BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override EndBatchTask.Builder MergeFrom(IMessage other)
            {
                if (other is EndBatchTask)
                {
                    return this.MergeFrom((EndBatchTask)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override EndBatchTask.Builder MergeFrom(EndBatchTask other)
            {
                if (other == EndBatchTask.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasTaskId)
                {
                    this.TaskId = other.TaskId;
                }
                if (other.HasSeqId)
                {
                    this.SeqId = other.SeqId;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override EndBatchTask.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override EndBatchTask.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(EndBatchTask._endBatchTaskFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = EndBatchTask._endBatchTaskFieldTags[num2];
                    }
                    if (num == 0u)
                    {
                        throw InvalidProtocolBufferException.InvalidTag();
                    }
                    if (num != 10u)
                    {
                        if (num != 18u)
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
                            this.result.hasSeqId = input.ReadString(ref this.result.seqId_);
                        }
                    }
                    else
                    {
                        this.result.hasTaskId = input.ReadString(ref this.result.taskId_);
                    }
                }
                if (builder != null)
                {
                    this.UnknownFields = builder.Build();
                }
                return this;
            }

            public EndBatchTask.Builder SetTaskId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTaskId = true;
                this.result.taskId_ = value;
                return this;
            }

            public EndBatchTask.Builder ClearTaskId()
            {
                this.PrepareBuilder();
                this.result.hasTaskId = false;
                this.result.taskId_ = "";
                return this;
            }

            public EndBatchTask.Builder SetSeqId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSeqId = true;
                this.result.seqId_ = value;
                return this;
            }

            public EndBatchTask.Builder ClearSeqId()
            {
                this.PrepareBuilder();
                this.result.hasSeqId = false;
                this.result.seqId_ = "";
                return this;
            }
        }

        private static readonly EndBatchTask defaultInstance;

        private static readonly string[] _endBatchTaskFieldNames;

        private static readonly uint[] _endBatchTaskFieldTags;

        public const int TaskIdFieldNumber = 1;

        private bool hasTaskId;

        private string taskId_ = "";

        public const int SeqIdFieldNumber = 2;

        private bool hasSeqId;

        private string seqId_ = "";

        private int memoizedSerializedSize = -1;

        public static EndBatchTask DefaultInstance
        {
            get
            {
                return EndBatchTask.defaultInstance;
            }
        }

        public override EndBatchTask DefaultInstanceForType
        {
            get
            {
                return EndBatchTask.DefaultInstance;
            }
        }

        protected override EndBatchTask ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_EndBatchTask__Descriptor;
            }
        }

        protected override FieldAccessorTable<EndBatchTask, EndBatchTask.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_EndBatchTask__FieldAccessorTable;
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
                return this.hasTaskId;
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
                if (this.hasTaskId)
                {
                    num += CodedOutputStream.ComputeStringSize(1, this.TaskId);
                }
                if (this.hasSeqId)
                {
                    num += CodedOutputStream.ComputeStringSize(2, this.SeqId);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private EndBatchTask()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] endBatchTaskFieldNames = EndBatchTask._endBatchTaskFieldNames;
            if (this.hasTaskId)
            {
                output.WriteString(1, endBatchTaskFieldNames[1], this.TaskId);
            }
            if (this.hasSeqId)
            {
                output.WriteString(2, endBatchTaskFieldNames[0], this.SeqId);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static EndBatchTask ParseFrom(ByteString data)
        {
            return EndBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static EndBatchTask ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return EndBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static EndBatchTask ParseFrom(byte[] data)
        {
            return EndBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static EndBatchTask ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return EndBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static EndBatchTask ParseFrom(Stream input)
        {
            return EndBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static EndBatchTask ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return EndBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static EndBatchTask ParseDelimitedFrom(Stream input)
        {
            return EndBatchTask.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static EndBatchTask ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return EndBatchTask.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static EndBatchTask ParseFrom(ICodedInputStream input)
        {
            return EndBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static EndBatchTask ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return EndBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private EndBatchTask MakeReadOnly()
        {
            return this;
        }

        public static EndBatchTask.Builder CreateBuilder()
        {
            return new EndBatchTask.Builder();
        }

        public override EndBatchTask.Builder ToBuilder()
        {
            return EndBatchTask.CreateBuilder(this);
        }

        public override EndBatchTask.Builder CreateBuilderForType()
        {
            return new EndBatchTask.Builder();
        }

        public static EndBatchTask.Builder CreateBuilder(EndBatchTask prototype)
        {
            return new EndBatchTask.Builder(prototype);
        }

        static EndBatchTask()
        {
            EndBatchTask.defaultInstance = new EndBatchTask().MakeReadOnly();
            EndBatchTask._endBatchTaskFieldNames = new string[]
            {
                "seqId",
                "taskId"
            };
            EndBatchTask._endBatchTaskFieldTags = new uint[]
            {
                18u,
                10u
            };
            FileDescriptor arg_44_0 = GtReq.Descriptor;
        }
    }
}
