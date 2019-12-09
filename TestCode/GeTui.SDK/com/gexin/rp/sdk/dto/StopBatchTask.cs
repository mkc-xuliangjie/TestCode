using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class StopBatchTask : GeneratedMessage<StopBatchTask, StopBatchTask.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<StopBatchTask, StopBatchTask.Builder>
        {
            private bool resultIsReadOnly;

            private StopBatchTask result;

            protected override StopBatchTask.Builder ThisBuilder
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

            protected override StopBatchTask MessageBeingBuilt
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
                    return StopBatchTask.Descriptor;
                }
            }

            public override StopBatchTask DefaultInstanceForType
            {
                get
                {
                    return StopBatchTask.DefaultInstance;
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
                this.result = StopBatchTask.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(StopBatchTask cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private StopBatchTask PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    StopBatchTask other = this.result;
                    this.result = new StopBatchTask();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override StopBatchTask.Builder Clear()
            {
                this.result = StopBatchTask.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override StopBatchTask.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new StopBatchTask.Builder(this.result);
                }
                return new StopBatchTask.Builder().MergeFrom(this.result);
            }

            public override StopBatchTask BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override StopBatchTask.Builder MergeFrom(IMessage other)
            {
                if (other is StopBatchTask)
                {
                    return this.MergeFrom((StopBatchTask)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override StopBatchTask.Builder MergeFrom(StopBatchTask other)
            {
                if (other == StopBatchTask.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasTaskId)
                {
                    this.TaskId = other.TaskId;
                }
                if (other.HasAppkey)
                {
                    this.Appkey = other.Appkey;
                }
                if (other.HasAppId)
                {
                    this.AppId = other.AppId;
                }
                if (other.HasSeqId)
                {
                    this.SeqId = other.SeqId;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override StopBatchTask.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override StopBatchTask.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(StopBatchTask._stopBatchTaskFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = StopBatchTask._stopBatchTaskFieldTags[num2];
                    }
                    if (num <= 10u)
                    {
                        if (num == 0u)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10u)
                        {
                            this.result.hasTaskId = input.ReadString(ref this.result.taskId_);
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
                        if (num == 26u)
                        {
                            this.result.hasAppId = input.ReadString(ref this.result.appId_);
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

            public StopBatchTask.Builder SetTaskId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTaskId = true;
                this.result.taskId_ = value;
                return this;
            }

            public StopBatchTask.Builder ClearTaskId()
            {
                this.PrepareBuilder();
                this.result.hasTaskId = false;
                this.result.taskId_ = "";
                return this;
            }

            public StopBatchTask.Builder SetAppkey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppkey = true;
                this.result.appkey_ = value;
                return this;
            }

            public StopBatchTask.Builder ClearAppkey()
            {
                this.PrepareBuilder();
                this.result.hasAppkey = false;
                this.result.appkey_ = "";
                return this;
            }

            public StopBatchTask.Builder SetAppId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppId = true;
                this.result.appId_ = value;
                return this;
            }

            public StopBatchTask.Builder ClearAppId()
            {
                this.PrepareBuilder();
                this.result.hasAppId = false;
                this.result.appId_ = "";
                return this;
            }

            public StopBatchTask.Builder SetSeqId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSeqId = true;
                this.result.seqId_ = value;
                return this;
            }

            public StopBatchTask.Builder ClearSeqId()
            {
                this.PrepareBuilder();
                this.result.hasSeqId = false;
                this.result.seqId_ = "";
                return this;
            }
        }

        private static readonly StopBatchTask defaultInstance;

        private static readonly string[] _stopBatchTaskFieldNames;

        private static readonly uint[] _stopBatchTaskFieldTags;

        public const int TaskIdFieldNumber = 1;

        private bool hasTaskId;

        private string taskId_ = "";

        public const int AppkeyFieldNumber = 2;

        private bool hasAppkey;

        private string appkey_ = "";

        public const int AppIdFieldNumber = 3;

        private bool hasAppId;

        private string appId_ = "";

        public const int SeqIdFieldNumber = 4;

        private bool hasSeqId;

        private string seqId_ = "";

        private int memoizedSerializedSize = -1;

        public static StopBatchTask DefaultInstance
        {
            get
            {
                return StopBatchTask.defaultInstance;
            }
        }

        public override StopBatchTask DefaultInstanceForType
        {
            get
            {
                return StopBatchTask.DefaultInstance;
            }
        }

        protected override StopBatchTask ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_StopBatchTask__Descriptor;
            }
        }

        protected override FieldAccessorTable<StopBatchTask, StopBatchTask.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_StopBatchTask__FieldAccessorTable;
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
                return this.hasTaskId && this.hasAppkey;
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
                if (this.hasAppkey)
                {
                    num += CodedOutputStream.ComputeStringSize(2, this.Appkey);
                }
                if (this.hasAppId)
                {
                    num += CodedOutputStream.ComputeStringSize(3, this.AppId);
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

        private StopBatchTask()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] stopBatchTaskFieldNames = StopBatchTask._stopBatchTaskFieldNames;
            if (this.hasTaskId)
            {
                output.WriteString(1, stopBatchTaskFieldNames[3], this.TaskId);
            }
            if (this.hasAppkey)
            {
                output.WriteString(2, stopBatchTaskFieldNames[1], this.Appkey);
            }
            if (this.hasAppId)
            {
                output.WriteString(3, stopBatchTaskFieldNames[0], this.AppId);
            }
            if (this.hasSeqId)
            {
                output.WriteString(4, stopBatchTaskFieldNames[2], this.SeqId);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static StopBatchTask ParseFrom(ByteString data)
        {
            return StopBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static StopBatchTask ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return StopBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static StopBatchTask ParseFrom(byte[] data)
        {
            return StopBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static StopBatchTask ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return StopBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static StopBatchTask ParseFrom(Stream input)
        {
            return StopBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static StopBatchTask ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return StopBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static StopBatchTask ParseDelimitedFrom(Stream input)
        {
            return StopBatchTask.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static StopBatchTask ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return StopBatchTask.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static StopBatchTask ParseFrom(ICodedInputStream input)
        {
            return StopBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static StopBatchTask ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return StopBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private StopBatchTask MakeReadOnly()
        {
            return this;
        }

        public static StopBatchTask.Builder CreateBuilder()
        {
            return new StopBatchTask.Builder();
        }

        public override StopBatchTask.Builder ToBuilder()
        {
            return StopBatchTask.CreateBuilder(this);
        }

        public override StopBatchTask.Builder CreateBuilderForType()
        {
            return new StopBatchTask.Builder();
        }

        public static StopBatchTask.Builder CreateBuilder(StopBatchTask prototype)
        {
            return new StopBatchTask.Builder(prototype);
        }

        static StopBatchTask()
        {
            StopBatchTask.defaultInstance = new StopBatchTask().MakeReadOnly();
            StopBatchTask._stopBatchTaskFieldNames = new string[]
            {
                "appId",
                "appkey",
                "seqId",
                "taskId"
            };
            StopBatchTask._stopBatchTaskFieldTags = new uint[]
            {
                26u,
                18u,
                34u,
                10u
            };
            FileDescriptor arg_55_0 = GtReq.Descriptor;
        }
    }
}
