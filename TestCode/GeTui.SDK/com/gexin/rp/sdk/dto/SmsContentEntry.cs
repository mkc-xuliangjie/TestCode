using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class SmsContentEntry : GeneratedMessage<SmsContentEntry, SmsContentEntry.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<SmsContentEntry, SmsContentEntry.Builder>
        {
            private bool resultIsReadOnly;

            private SmsContentEntry result;

            protected override SmsContentEntry.Builder ThisBuilder
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

            protected override SmsContentEntry MessageBeingBuilt
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
                    return SmsContentEntry.Descriptor;
                }
            }

            public override SmsContentEntry DefaultInstanceForType
            {
                get
                {
                    return SmsContentEntry.DefaultInstance;
                }
            }

            public bool HasKey
            {
                get
                {
                    return this.result.hasKey;
                }
            }

            public string Key
            {
                get
                {
                    return this.result.Key;
                }
                set
                {
                    this.SetKey(value);
                }
            }

            public bool HasValue
            {
                get
                {
                    return this.result.hasValue;
                }
            }

            public string Value
            {
                get
                {
                    return this.result.Value;
                }
                set
                {
                    this.SetValue(value);
                }
            }

            public Builder()
            {
                this.result = SmsContentEntry.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SmsContentEntry cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private SmsContentEntry PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SmsContentEntry other = this.result;
                    this.result = new SmsContentEntry();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override SmsContentEntry.Builder Clear()
            {
                this.result = SmsContentEntry.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override SmsContentEntry.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SmsContentEntry.Builder(this.result);
                }
                return new SmsContentEntry.Builder().MergeFrom(this.result);
            }

            public override SmsContentEntry BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SmsContentEntry.Builder MergeFrom(IMessage other)
            {
                if (other is SmsContentEntry)
                {
                    return this.MergeFrom((SmsContentEntry)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SmsContentEntry.Builder MergeFrom(SmsContentEntry other)
            {
                if (other == SmsContentEntry.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasKey)
                {
                    this.Key = other.Key;
                }
                if (other.HasValue)
                {
                    this.Value = other.Value;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override SmsContentEntry.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SmsContentEntry.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(SmsContentEntry._smsContentEntryFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = SmsContentEntry._smsContentEntryFieldTags[num2];
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
                            this.result.hasValue = input.ReadString(ref this.result.value_);
                        }
                    }
                    else
                    {
                        this.result.hasKey = input.ReadString(ref this.result.key_);
                    }
                }
                if (builder != null)
                {
                    this.UnknownFields = builder.Build();
                }
                return this;
            }

            public SmsContentEntry.Builder SetKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasKey = true;
                this.result.key_ = value;
                return this;
            }

            public SmsContentEntry.Builder ClearKey()
            {
                this.PrepareBuilder();
                this.result.hasKey = false;
                this.result.key_ = "";
                return this;
            }

            public SmsContentEntry.Builder SetValue(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasValue = true;
                this.result.value_ = value;
                return this;
            }

            public SmsContentEntry.Builder ClearValue()
            {
                this.PrepareBuilder();
                this.result.hasValue = false;
                this.result.value_ = "";
                return this;
            }
        }

        private static readonly SmsContentEntry defaultInstance;

        private static readonly string[] _smsContentEntryFieldNames;

        private static readonly uint[] _smsContentEntryFieldTags;

        public const int KeyFieldNumber = 1;

        private bool hasKey;

        private string key_ = "";

        public const int ValueFieldNumber = 2;

        private bool hasValue;

        private string value_ = "";

        private int memoizedSerializedSize = -1;

        public static SmsContentEntry DefaultInstance
        {
            get
            {
                return SmsContentEntry.defaultInstance;
            }
        }

        public override SmsContentEntry DefaultInstanceForType
        {
            get
            {
                return SmsContentEntry.DefaultInstance;
            }
        }

        protected override SmsContentEntry ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_SmsContentEntry__Descriptor;
            }
        }

        protected override FieldAccessorTable<SmsContentEntry, SmsContentEntry.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_SmsContentEntry__FieldAccessorTable;
            }
        }

        public bool HasKey
        {
            get
            {
                return this.hasKey;
            }
        }

        public string Key
        {
            get
            {
                return this.key_;
            }
        }

        public bool HasValue
        {
            get
            {
                return this.hasValue;
            }
        }

        public string Value
        {
            get
            {
                return this.value_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                return this.hasKey && this.hasValue;
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
                if (this.hasKey)
                {
                    num += CodedOutputStream.ComputeStringSize(1, this.Key);
                }
                if (this.hasValue)
                {
                    num += CodedOutputStream.ComputeStringSize(2, this.Value);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private SmsContentEntry()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] smsContentEntryFieldNames = SmsContentEntry._smsContentEntryFieldNames;
            if (this.hasKey)
            {
                output.WriteString(1, smsContentEntryFieldNames[0], this.Key);
            }
            if (this.hasValue)
            {
                output.WriteString(2, smsContentEntryFieldNames[1], this.Value);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static SmsContentEntry ParseFrom(ByteString data)
        {
            return SmsContentEntry.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static SmsContentEntry ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return SmsContentEntry.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static SmsContentEntry ParseFrom(byte[] data)
        {
            return SmsContentEntry.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static SmsContentEntry ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return SmsContentEntry.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static SmsContentEntry ParseFrom(Stream input)
        {
            return SmsContentEntry.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static SmsContentEntry ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return SmsContentEntry.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static SmsContentEntry ParseDelimitedFrom(Stream input)
        {
            return SmsContentEntry.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static SmsContentEntry ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return SmsContentEntry.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static SmsContentEntry ParseFrom(ICodedInputStream input)
        {
            return SmsContentEntry.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static SmsContentEntry ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return SmsContentEntry.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private SmsContentEntry MakeReadOnly()
        {
            return this;
        }

        public static SmsContentEntry.Builder CreateBuilder()
        {
            return new SmsContentEntry.Builder();
        }

        public override SmsContentEntry.Builder ToBuilder()
        {
            return SmsContentEntry.CreateBuilder(this);
        }

        public override SmsContentEntry.Builder CreateBuilderForType()
        {
            return new SmsContentEntry.Builder();
        }

        public static SmsContentEntry.Builder CreateBuilder(SmsContentEntry prototype)
        {
            return new SmsContentEntry.Builder(prototype);
        }

        static SmsContentEntry()
        {
            SmsContentEntry.defaultInstance = new SmsContentEntry().MakeReadOnly();
            SmsContentEntry._smsContentEntryFieldNames = new string[]
            {
                "key",
                "value"
            };
            SmsContentEntry._smsContentEntryFieldTags = new uint[]
            {
                10u,
                18u
            };
            FileDescriptor arg_44_0 = GtReq.Descriptor;
        }
    }
}
