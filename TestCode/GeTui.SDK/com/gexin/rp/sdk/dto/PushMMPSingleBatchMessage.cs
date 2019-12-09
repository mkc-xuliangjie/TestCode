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
    public sealed class PushMMPSingleBatchMessage : GeneratedMessage<PushMMPSingleBatchMessage, PushMMPSingleBatchMessage.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<PushMMPSingleBatchMessage, PushMMPSingleBatchMessage.Builder>
        {
            private bool resultIsReadOnly;

            private PushMMPSingleBatchMessage result;

            protected override PushMMPSingleBatchMessage.Builder ThisBuilder
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

            protected override PushMMPSingleBatchMessage MessageBeingBuilt
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
                    return PushMMPSingleBatchMessage.Descriptor;
                }
            }

            public override PushMMPSingleBatchMessage DefaultInstanceForType
            {
                get
                {
                    return PushMMPSingleBatchMessage.DefaultInstance;
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

            public IPopsicleList<PushMMPSingleMessage> BatchItemList
            {
                get
                {
                    return this.PrepareBuilder().batchItem_;
                }
            }

            public int BatchItemCount
            {
                get
                {
                    return this.result.BatchItemCount;
                }
            }

            public bool HasIsSync
            {
                get
                {
                    return this.result.hasIsSync;
                }
            }

            public bool IsSync
            {
                get
                {
                    return this.result.IsSync;
                }
                set
                {
                    this.SetIsSync(value);
                }
            }

            public Builder()
            {
                this.result = PushMMPSingleBatchMessage.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(PushMMPSingleBatchMessage cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private PushMMPSingleBatchMessage PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    PushMMPSingleBatchMessage other = this.result;
                    this.result = new PushMMPSingleBatchMessage();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override PushMMPSingleBatchMessage.Builder Clear()
            {
                this.result = PushMMPSingleBatchMessage.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override PushMMPSingleBatchMessage.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new PushMMPSingleBatchMessage.Builder(this.result);
                }
                return new PushMMPSingleBatchMessage.Builder().MergeFrom(this.result);
            }

            public override PushMMPSingleBatchMessage BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override PushMMPSingleBatchMessage.Builder MergeFrom(IMessage other)
            {
                if (other is PushMMPSingleBatchMessage)
                {
                    return this.MergeFrom((PushMMPSingleBatchMessage)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override PushMMPSingleBatchMessage.Builder MergeFrom(PushMMPSingleBatchMessage other)
            {
                if (other == PushMMPSingleBatchMessage.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasBatchId)
                {
                    this.BatchId = other.BatchId;
                }
                if (other.batchItem_.Count != 0)
                {
                    this.result.batchItem_.Add(other.batchItem_);
                }
                if (other.HasIsSync)
                {
                    this.IsSync = other.IsSync;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override PushMMPSingleBatchMessage.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override PushMMPSingleBatchMessage.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(PushMMPSingleBatchMessage._pushMMPSingleBatchMessageFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = PushMMPSingleBatchMessage._pushMMPSingleBatchMessageFieldTags[num2];
                    }
                    if (num <= 10u)
                    {
                        if (num == 0u)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10u)
                        {
                            this.result.hasBatchId = input.ReadString(ref this.result.batchId_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18u)
                        {
                            input.ReadMessageArray<PushMMPSingleMessage>(num, text, this.result.batchItem_, PushMMPSingleMessage.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        if (num == 24u)
                        {
                            this.result.hasIsSync = input.ReadBool(ref this.result.isSync_);
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

            public PushMMPSingleBatchMessage.Builder SetBatchId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBatchId = true;
                this.result.batchId_ = value;
                return this;
            }

            public PushMMPSingleBatchMessage.Builder ClearBatchId()
            {
                this.PrepareBuilder();
                this.result.hasBatchId = false;
                this.result.batchId_ = "";
                return this;
            }

            public PushMMPSingleMessage GetBatchItem(int index)
            {
                return this.result.GetBatchItem(index);
            }

            public PushMMPSingleBatchMessage.Builder SetBatchItem(int index, PushMMPSingleMessage value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.batchItem_[index] = value;
                return this;
            }

            public PushMMPSingleBatchMessage.Builder SetBatchItem(int index, PushMMPSingleMessage.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.batchItem_[index] = builderForValue.Build();
                return this;
            }

            public PushMMPSingleBatchMessage.Builder AddBatchItem(PushMMPSingleMessage value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.batchItem_.Add(value);
                return this;
            }

            public PushMMPSingleBatchMessage.Builder AddBatchItem(PushMMPSingleMessage.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.batchItem_.Add(builderForValue.Build());
                return this;
            }

            public PushMMPSingleBatchMessage.Builder AddRangeBatchItem(IEnumerable<PushMMPSingleMessage> values)
            {
                this.PrepareBuilder();
                this.result.batchItem_.Add(values);
                return this;
            }

            public PushMMPSingleBatchMessage.Builder ClearBatchItem()
            {
                this.PrepareBuilder();
                this.result.batchItem_.Clear();
                return this;
            }

            public PushMMPSingleBatchMessage.Builder SetIsSync(bool value)
            {
                this.PrepareBuilder();
                this.result.hasIsSync = true;
                this.result.isSync_ = value;
                return this;
            }

            public PushMMPSingleBatchMessage.Builder ClearIsSync()
            {
                this.PrepareBuilder();
                this.result.hasIsSync = false;
                this.result.isSync_ = true;
                return this;
            }
        }

        private static readonly PushMMPSingleBatchMessage defaultInstance;

        private static readonly string[] _pushMMPSingleBatchMessageFieldNames;

        private static readonly uint[] _pushMMPSingleBatchMessageFieldTags;

        public const int BatchIdFieldNumber = 1;

        private bool hasBatchId;

        private string batchId_ = "";

        public const int BatchItemFieldNumber = 2;

        private PopsicleList<PushMMPSingleMessage> batchItem_ = new PopsicleList<PushMMPSingleMessage>();

        public const int IsSyncFieldNumber = 3;

        private bool hasIsSync;

        private bool isSync_ = true;

        private int memoizedSerializedSize = -1;

        public static PushMMPSingleBatchMessage DefaultInstance
        {
            get
            {
                return PushMMPSingleBatchMessage.defaultInstance;
            }
        }

        public override PushMMPSingleBatchMessage DefaultInstanceForType
        {
            get
            {
                return PushMMPSingleBatchMessage.DefaultInstance;
            }
        }

        protected override PushMMPSingleBatchMessage ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPSingleBatchMessage__Descriptor;
            }
        }

        protected override FieldAccessorTable<PushMMPSingleBatchMessage, PushMMPSingleBatchMessage.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPSingleBatchMessage__FieldAccessorTable;
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

        public IList<PushMMPSingleMessage> BatchItemList
        {
            get
            {
                return this.batchItem_;
            }
        }

        public int BatchItemCount
        {
            get
            {
                return this.batchItem_.Count;
            }
        }

        public bool HasIsSync
        {
            get
            {
                return this.hasIsSync;
            }
        }

        public bool IsSync
        {
            get
            {
                return this.isSync_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasBatchId)
                {
                    return false;
                }
                using (IEnumerator<PushMMPSingleMessage> enumerator = this.BatchItemList.GetEnumerator())
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
                if (this.hasBatchId)
                {
                    num += CodedOutputStream.ComputeStringSize(1, this.BatchId);
                }
                foreach (PushMMPSingleMessage current in this.BatchItemList)
                {
                    num += CodedOutputStream.ComputeMessageSize(2, current);
                }
                if (this.hasIsSync)
                {
                    num += CodedOutputStream.ComputeBoolSize(3, this.IsSync);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private PushMMPSingleBatchMessage()
        {
        }

        public PushMMPSingleMessage GetBatchItem(int index)
        {
            return this.batchItem_[index];
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] pushMMPSingleBatchMessageFieldNames = PushMMPSingleBatchMessage._pushMMPSingleBatchMessageFieldNames;
            if (this.hasBatchId)
            {
                output.WriteString(1, pushMMPSingleBatchMessageFieldNames[0], this.BatchId);
            }
            if (this.batchItem_.Count > 0)
            {
                output.WriteMessageArray<PushMMPSingleMessage>(2, pushMMPSingleBatchMessageFieldNames[1], this.batchItem_);
            }
            if (this.hasIsSync)
            {
                output.WriteBool(3, pushMMPSingleBatchMessageFieldNames[2], this.IsSync);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static PushMMPSingleBatchMessage ParseFrom(ByteString data)
        {
            return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushMMPSingleBatchMessage ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushMMPSingleBatchMessage ParseFrom(byte[] data)
        {
            return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushMMPSingleBatchMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushMMPSingleBatchMessage ParseFrom(Stream input)
        {
            return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushMMPSingleBatchMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushMMPSingleBatchMessage ParseDelimitedFrom(Stream input)
        {
            return PushMMPSingleBatchMessage.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static PushMMPSingleBatchMessage ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushMMPSingleBatchMessage.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushMMPSingleBatchMessage ParseFrom(ICodedInputStream input)
        {
            return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushMMPSingleBatchMessage ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private PushMMPSingleBatchMessage MakeReadOnly()
        {
            this.batchItem_.MakeReadOnly();
            return this;
        }

        public static PushMMPSingleBatchMessage.Builder CreateBuilder()
        {
            return new PushMMPSingleBatchMessage.Builder();
        }

        public override PushMMPSingleBatchMessage.Builder ToBuilder()
        {
            return PushMMPSingleBatchMessage.CreateBuilder(this);
        }

        public override PushMMPSingleBatchMessage.Builder CreateBuilderForType()
        {
            return new PushMMPSingleBatchMessage.Builder();
        }

        public static PushMMPSingleBatchMessage.Builder CreateBuilder(PushMMPSingleBatchMessage prototype)
        {
            return new PushMMPSingleBatchMessage.Builder(prototype);
        }

        static PushMMPSingleBatchMessage()
        {
            PushMMPSingleBatchMessage.defaultInstance = new PushMMPSingleBatchMessage().MakeReadOnly();
            PushMMPSingleBatchMessage._pushMMPSingleBatchMessageFieldNames = new string[]
            {
                "batchId",
                "batchItem",
                "isSync"
            };
            PushMMPSingleBatchMessage._pushMMPSingleBatchMessageFieldTags = new uint[]
            {
                10u,
                18u,
                24u
            };
            FileDescriptor arg_4D_0 = GtReq.Descriptor;
        }
    }
}
