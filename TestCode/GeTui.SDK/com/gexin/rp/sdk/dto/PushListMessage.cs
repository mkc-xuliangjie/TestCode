using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class PushListMessage : GeneratedMessage<PushListMessage, PushListMessage.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<PushListMessage, PushListMessage.Builder>
        {
            private bool resultIsReadOnly;

            private PushListMessage result;

            protected override PushListMessage.Builder ThisBuilder
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

            protected override PushListMessage MessageBeingBuilt
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
                    return PushListMessage.Descriptor;
                }
            }

            public override PushListMessage DefaultInstanceForType
            {
                get
                {
                    return PushListMessage.DefaultInstance;
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

            public IPopsicleList<Target> TargetsList
            {
                get
                {
                    return this.PrepareBuilder().targets_;
                }
            }

            public int TargetsCount
            {
                get
                {
                    return this.result.TargetsCount;
                }
            }

            public Builder()
            {
                this.result = PushListMessage.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(PushListMessage cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private PushListMessage PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    PushListMessage other = this.result;
                    this.result = new PushListMessage();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override PushListMessage.Builder Clear()
            {
                this.result = PushListMessage.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override PushListMessage.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new PushListMessage.Builder(this.result);
                }
                return new PushListMessage.Builder().MergeFrom(this.result);
            }

            public override PushListMessage BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override PushListMessage.Builder MergeFrom(IMessage other)
            {
                if (other is PushListMessage)
                {
                    return this.MergeFrom((PushListMessage)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override PushListMessage.Builder MergeFrom(PushListMessage other)
            {
                if (other == PushListMessage.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasSeqId)
                {
                    this.SeqId = other.SeqId;
                }
                if (other.HasTaskId)
                {
                    this.TaskId = other.TaskId;
                }
                if (other.targets_.Count != 0)
                {
                    this.result.targets_.Add(other.targets_);
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override PushListMessage.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override PushListMessage.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(PushListMessage._pushListMessageFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = PushListMessage._pushListMessageFieldTags[num2];
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
                            this.result.hasTaskId = input.ReadString(ref this.result.taskId_);
                            continue;
                        }
                        if (num == 26u)
                        {
                            input.ReadMessageArray<Target>(num, text, this.result.targets_, Target.DefaultInstance, extensionRegistry);
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

            public PushListMessage.Builder SetSeqId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSeqId = true;
                this.result.seqId_ = value;
                return this;
            }

            public PushListMessage.Builder ClearSeqId()
            {
                this.PrepareBuilder();
                this.result.hasSeqId = false;
                this.result.seqId_ = "";
                return this;
            }

            public PushListMessage.Builder SetTaskId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTaskId = true;
                this.result.taskId_ = value;
                return this;
            }

            public PushListMessage.Builder ClearTaskId()
            {
                this.PrepareBuilder();
                this.result.hasTaskId = false;
                this.result.taskId_ = "";
                return this;
            }

            public Target GetTargets(int index)
            {
                return this.result.GetTargets(index);
            }

            public PushListMessage.Builder SetTargets(int index, Target value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.targets_[index] = value;
                return this;
            }

            public PushListMessage.Builder SetTargets(int index, Target.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.targets_[index] = builderForValue.Build();
                return this;
            }

            public PushListMessage.Builder AddTargets(Target value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.targets_.Add(value);
                return this;
            }

            public PushListMessage.Builder AddTargets(Target.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.targets_.Add(builderForValue.Build());
                return this;
            }

            public PushListMessage.Builder AddRangeTargets(IEnumerable<Target> values)
            {
                this.PrepareBuilder();
                this.result.targets_.Add(values);
                return this;
            }

            public PushListMessage.Builder ClearTargets()
            {
                this.PrepareBuilder();
                this.result.targets_.Clear();
                return this;
            }
        }

        private static readonly PushListMessage defaultInstance;

        private static readonly string[] _pushListMessageFieldNames;

        private static readonly uint[] _pushListMessageFieldTags;

        public const int SeqIdFieldNumber = 1;

        private bool hasSeqId;

        private string seqId_ = "";

        public const int TaskIdFieldNumber = 2;

        private bool hasTaskId;

        private string taskId_ = "";

        public const int TargetsFieldNumber = 3;

        private PopsicleList<Target> targets_ = new PopsicleList<Target>();

        private int memoizedSerializedSize = -1;

        public static PushListMessage DefaultInstance
        {
            get
            {
                return PushListMessage.defaultInstance;
            }
        }

        public override PushListMessage DefaultInstanceForType
        {
            get
            {
                return PushListMessage.DefaultInstance;
            }
        }

        protected override PushListMessage ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushListMessage__Descriptor;
            }
        }

        protected override FieldAccessorTable<PushListMessage, PushListMessage.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushListMessage__FieldAccessorTable;
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

        public IList<Target> TargetsList
        {
            get
            {
                return this.targets_;
            }
        }

        public int TargetsCount
        {
            get
            {
                return this.targets_.Count;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasSeqId)
                {
                    return false;
                }
                if (!this.hasTaskId)
                {
                    return false;
                }
                using (IEnumerator<Target> enumerator = this.TargetsList.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        if (!enumerator.Current.IsInitialized)
                        {
                            return false;
                        }
                    }
                }
                return true;
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
                if (this.hasTaskId)
                {
                    num += CodedOutputStream.ComputeStringSize(2, this.TaskId);
                }
                foreach (Target current in this.TargetsList)
                {
                    num += CodedOutputStream.ComputeMessageSize(3, current);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private PushListMessage()
        {
        }

        public Target GetTargets(int index)
        {
            return this.targets_[index];
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] pushListMessageFieldNames = PushListMessage._pushListMessageFieldNames;
            if (this.hasSeqId)
            {
                output.WriteString(1, pushListMessageFieldNames[0], this.SeqId);
            }
            if (this.hasTaskId)
            {
                output.WriteString(2, pushListMessageFieldNames[2], this.TaskId);
            }
            if (this.targets_.Count > 0)
            {
                output.WriteMessageArray<Target>(3, pushListMessageFieldNames[1], this.targets_);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static PushListMessage ParseFrom(ByteString data)
        {
            return PushListMessage.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushListMessage ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return PushListMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushListMessage ParseFrom(byte[] data)
        {
            return PushListMessage.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushListMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return PushListMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushListMessage ParseFrom(Stream input)
        {
            return PushListMessage.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushListMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushListMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushListMessage ParseDelimitedFrom(Stream input)
        {
            return PushListMessage.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static PushListMessage ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushListMessage.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushListMessage ParseFrom(ICodedInputStream input)
        {
            return PushListMessage.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushListMessage ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return PushListMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private PushListMessage MakeReadOnly()
        {
            this.targets_.MakeReadOnly();
            return this;
        }

        public static PushListMessage.Builder CreateBuilder()
        {
            return new PushListMessage.Builder();
        }

        public override PushListMessage.Builder ToBuilder()
        {
            return PushListMessage.CreateBuilder(this);
        }

        public override PushListMessage.Builder CreateBuilderForType()
        {
            return new PushListMessage.Builder();
        }

        public static PushListMessage.Builder CreateBuilder(PushListMessage prototype)
        {
            return new PushListMessage.Builder(prototype);
        }

        static PushListMessage()
        {
            PushListMessage.defaultInstance = new PushListMessage().MakeReadOnly();
            PushListMessage._pushListMessageFieldNames = new string[]
            {
                "seqId",
                "targets",
                "taskId"
            };
            PushListMessage._pushListMessageFieldTags = new uint[]
            {
                10u,
                26u,
                18u
            };
            FileDescriptor arg_4D_0 = GtReq.Descriptor;
        }
    }
}
