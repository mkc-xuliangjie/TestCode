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
    public sealed class PushListResult : GeneratedMessage<PushListResult, PushListResult.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<PushListResult, PushListResult.Builder>
        {
            private bool resultIsReadOnly;

            private PushListResult result;

            protected override PushListResult.Builder ThisBuilder
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

            protected override PushListResult MessageBeingBuilt
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
                    return PushListResult.Descriptor;
                }
            }

            public override PushListResult DefaultInstanceForType
            {
                get
                {
                    return PushListResult.DefaultInstance;
                }
            }

            public IPopsicleList<PushResult> ResultsList
            {
                get
                {
                    return this.PrepareBuilder().results_;
                }
            }

            public int ResultsCount
            {
                get
                {
                    return this.result.ResultsCount;
                }
            }

            public Builder()
            {
                this.result = PushListResult.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(PushListResult cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private PushListResult PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    PushListResult other = this.result;
                    this.result = new PushListResult();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override PushListResult.Builder Clear()
            {
                this.result = PushListResult.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override PushListResult.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new PushListResult.Builder(this.result);
                }
                return new PushListResult.Builder().MergeFrom(this.result);
            }

            public override PushListResult BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override PushListResult.Builder MergeFrom(IMessage other)
            {
                if (other is PushListResult)
                {
                    return this.MergeFrom((PushListResult)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override PushListResult.Builder MergeFrom(PushListResult other)
            {
                if (other == PushListResult.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.results_.Count != 0)
                {
                    this.result.results_.Add(other.results_);
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override PushListResult.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override PushListResult.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(PushListResult._pushListResultFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = PushListResult._pushListResultFieldTags[num2];
                    }
                    if (num == 0u)
                    {
                        throw InvalidProtocolBufferException.InvalidTag();
                    }
                    if (num != 10u)
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
                        input.ReadMessageArray<PushResult>(num, text, this.result.results_, PushResult.DefaultInstance, extensionRegistry);
                    }
                }
                if (builder != null)
                {
                    this.UnknownFields = builder.Build();
                }
                return this;
            }

            public PushResult GetResults(int index)
            {
                return this.result.GetResults(index);
            }

            public PushListResult.Builder SetResults(int index, PushResult value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.results_[index] = value;
                return this;
            }

            public PushListResult.Builder SetResults(int index, PushResult.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.results_[index] = builderForValue.Build();
                return this;
            }

            public PushListResult.Builder AddResults(PushResult value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.results_.Add(value);
                return this;
            }

            public PushListResult.Builder AddResults(PushResult.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.results_.Add(builderForValue.Build());
                return this;
            }

            public PushListResult.Builder AddRangeResults(IEnumerable<PushResult> values)
            {
                this.PrepareBuilder();
                this.result.results_.Add(values);
                return this;
            }

            public PushListResult.Builder ClearResults()
            {
                this.PrepareBuilder();
                this.result.results_.Clear();
                return this;
            }
        }

        private static readonly PushListResult defaultInstance;

        private static readonly string[] _pushListResultFieldNames;

        private static readonly uint[] _pushListResultFieldTags;

        public const int ResultsFieldNumber = 1;

        private PopsicleList<PushResult> results_ = new PopsicleList<PushResult>();

        private int memoizedSerializedSize = -1;

        public static PushListResult DefaultInstance
        {
            get
            {
                return PushListResult.defaultInstance;
            }
        }

        public override PushListResult DefaultInstanceForType
        {
            get
            {
                return PushListResult.DefaultInstance;
            }
        }

        protected override PushListResult ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushListResult__Descriptor;
            }
        }

        protected override FieldAccessorTable<PushListResult, PushListResult.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushListResult__FieldAccessorTable;
            }
        }

        public IList<PushResult> ResultsList
        {
            get
            {
                return this.results_;
            }
        }

        public int ResultsCount
        {
            get
            {
                return this.results_.Count;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                using (IEnumerator<PushResult> enumerator = this.ResultsList.GetEnumerator())
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
                foreach (PushResult current in this.ResultsList)
                {
                    num += CodedOutputStream.ComputeMessageSize(1, current);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private PushListResult()
        {
        }

        public PushResult GetResults(int index)
        {
            return this.results_[index];
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] pushListResultFieldNames = PushListResult._pushListResultFieldNames;
            if (this.results_.Count > 0)
            {
                output.WriteMessageArray<PushResult>(1, pushListResultFieldNames[0], this.results_);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static PushListResult ParseFrom(ByteString data)
        {
            return PushListResult.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushListResult ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return PushListResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushListResult ParseFrom(byte[] data)
        {
            return PushListResult.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushListResult ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return PushListResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushListResult ParseFrom(Stream input)
        {
            return PushListResult.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushListResult ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushListResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushListResult ParseDelimitedFrom(Stream input)
        {
            return PushListResult.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static PushListResult ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushListResult.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushListResult ParseFrom(ICodedInputStream input)
        {
            return PushListResult.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushListResult ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return PushListResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private PushListResult MakeReadOnly()
        {
            this.results_.MakeReadOnly();
            return this;
        }

        public static PushListResult.Builder CreateBuilder()
        {
            return new PushListResult.Builder();
        }

        public override PushListResult.Builder ToBuilder()
        {
            return PushListResult.CreateBuilder(this);
        }

        public override PushListResult.Builder CreateBuilderForType()
        {
            return new PushListResult.Builder();
        }

        public static PushListResult.Builder CreateBuilder(PushListResult prototype)
        {
            return new PushListResult.Builder(prototype);
        }

        static PushListResult()
        {
            PushListResult.defaultInstance = new PushListResult().MakeReadOnly();
            PushListResult._pushListResultFieldNames = new string[]
            {
                "results"
            };
            PushListResult._pushListResultFieldTags = new uint[]
            {
                10u
            };
            FileDescriptor arg_37_0 = GtReq.Descriptor;
        }
    }
}
