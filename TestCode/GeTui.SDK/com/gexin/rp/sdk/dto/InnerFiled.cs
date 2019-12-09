using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class InnerFiled : GeneratedMessage<InnerFiled, InnerFiled.Builder>
    {
        [DebuggerNonUserCode]
        public static class Types
        {
            public enum Type
            {
                str,
                int32,
                int64,
                floa,
                doub,
                boole
            }
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<InnerFiled, InnerFiled.Builder>
        {
            private bool resultIsReadOnly;

            private InnerFiled result;

            protected override InnerFiled.Builder ThisBuilder
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

            protected override InnerFiled MessageBeingBuilt
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
                    return InnerFiled.Descriptor;
                }
            }

            public override InnerFiled DefaultInstanceForType
            {
                get
                {
                    return InnerFiled.DefaultInstance;
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

            public bool HasVal
            {
                get
                {
                    return this.result.hasVal;
                }
            }

            public string Val
            {
                get
                {
                    return this.result.Val;
                }
                set
                {
                    this.SetVal(value);
                }
            }

            public bool HasType
            {
                get
                {
                    return this.result.hasType;
                }
            }

            public InnerFiled.Types.Type Type
            {
                get
                {
                    return this.result.Type;
                }
                set
                {
                    this.SetType(value);
                }
            }

            public Builder()
            {
                this.result = InnerFiled.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(InnerFiled cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private InnerFiled PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    InnerFiled other = this.result;
                    this.result = new InnerFiled();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override InnerFiled.Builder Clear()
            {
                this.result = InnerFiled.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override InnerFiled.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new InnerFiled.Builder(this.result);
                }
                return new InnerFiled.Builder().MergeFrom(this.result);
            }

            public override InnerFiled BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override InnerFiled.Builder MergeFrom(IMessage other)
            {
                if (other is InnerFiled)
                {
                    return this.MergeFrom((InnerFiled)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override InnerFiled.Builder MergeFrom(InnerFiled other)
            {
                if (other == InnerFiled.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasKey)
                {
                    this.Key = other.Key;
                }
                if (other.HasVal)
                {
                    this.Val = other.Val;
                }
                if (other.HasType)
                {
                    this.Type = other.Type;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override InnerFiled.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override InnerFiled.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(InnerFiled._innerFiledFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = InnerFiled._innerFiledFieldTags[num2];
                    }
                    if (num <= 10u)
                    {
                        if (num == 0u)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10u)
                        {
                            this.result.hasKey = input.ReadString(ref this.result.key_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18u)
                        {
                            this.result.hasVal = input.ReadString(ref this.result.val_);
                            continue;
                        }
                        if (num == 24u)
                        {
                            object obj;
                            if (input.ReadEnum<InnerFiled.Types.Type>(ref this.result.type_, out obj))
                            {
                                this.result.hasType = true;
                                continue;
                            }
                            if (obj is int)
                            {
                                if (builder == null)
                                {
                                    builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                                }
                                builder.MergeVarintField(3, (ulong)((long)((int)obj)));
                                continue;
                            }
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

            public InnerFiled.Builder SetKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasKey = true;
                this.result.key_ = value;
                return this;
            }

            public InnerFiled.Builder ClearKey()
            {
                this.PrepareBuilder();
                this.result.hasKey = false;
                this.result.key_ = "";
                return this;
            }

            public InnerFiled.Builder SetVal(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVal = true;
                this.result.val_ = value;
                return this;
            }

            public InnerFiled.Builder ClearVal()
            {
                this.PrepareBuilder();
                this.result.hasVal = false;
                this.result.val_ = "";
                return this;
            }

            public InnerFiled.Builder SetType(InnerFiled.Types.Type value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
            }

            public InnerFiled.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = InnerFiled.Types.Type.str;
                return this;
            }
        }

        private static readonly InnerFiled defaultInstance;

        private static readonly string[] _innerFiledFieldNames;

        private static readonly uint[] _innerFiledFieldTags;

        public const int KeyFieldNumber = 1;

        private bool hasKey;

        private string key_ = "";

        public const int ValFieldNumber = 2;

        private bool hasVal;

        private string val_ = "";

        public const int TypeFieldNumber = 3;

        private bool hasType;

        private InnerFiled.Types.Type type_;

        private int memoizedSerializedSize = -1;

        public static InnerFiled DefaultInstance
        {
            get
            {
                return InnerFiled.defaultInstance;
            }
        }

        public override InnerFiled DefaultInstanceForType
        {
            get
            {
                return InnerFiled.DefaultInstance;
            }
        }

        protected override InnerFiled ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_InnerFiled__Descriptor;
            }
        }

        protected override FieldAccessorTable<InnerFiled, InnerFiled.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_InnerFiled__FieldAccessorTable;
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

        public bool HasVal
        {
            get
            {
                return this.hasVal;
            }
        }

        public string Val
        {
            get
            {
                return this.val_;
            }
        }

        public bool HasType
        {
            get
            {
                return this.hasType;
            }
        }

        public InnerFiled.Types.Type Type
        {
            get
            {
                return this.type_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                return this.hasKey && this.hasVal && this.hasType;
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
                if (this.hasVal)
                {
                    num += CodedOutputStream.ComputeStringSize(2, this.Val);
                }
                if (this.hasType)
                {
                    num += CodedOutputStream.ComputeEnumSize(3, (int)this.Type);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private InnerFiled()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] innerFiledFieldNames = InnerFiled._innerFiledFieldNames;
            if (this.hasKey)
            {
                output.WriteString(1, innerFiledFieldNames[0], this.Key);
            }
            if (this.hasVal)
            {
                output.WriteString(2, innerFiledFieldNames[2], this.Val);
            }
            if (this.hasType)
            {
                output.WriteEnum(3, innerFiledFieldNames[1], (int)this.Type, this.Type);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static InnerFiled ParseFrom(ByteString data)
        {
            return InnerFiled.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static InnerFiled ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return InnerFiled.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static InnerFiled ParseFrom(byte[] data)
        {
            return InnerFiled.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static InnerFiled ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return InnerFiled.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static InnerFiled ParseFrom(Stream input)
        {
            return InnerFiled.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static InnerFiled ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return InnerFiled.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static InnerFiled ParseDelimitedFrom(Stream input)
        {
            return InnerFiled.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static InnerFiled ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return InnerFiled.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static InnerFiled ParseFrom(ICodedInputStream input)
        {
            return InnerFiled.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static InnerFiled ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return InnerFiled.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private InnerFiled MakeReadOnly()
        {
            return this;
        }

        public static InnerFiled.Builder CreateBuilder()
        {
            return new InnerFiled.Builder();
        }

        public override InnerFiled.Builder ToBuilder()
        {
            return InnerFiled.CreateBuilder(this);
        }

        public override InnerFiled.Builder CreateBuilderForType()
        {
            return new InnerFiled.Builder();
        }

        public static InnerFiled.Builder CreateBuilder(InnerFiled prototype)
        {
            return new InnerFiled.Builder(prototype);
        }

        static InnerFiled()
        {
            InnerFiled.defaultInstance = new InnerFiled().MakeReadOnly();
            InnerFiled._innerFiledFieldNames = new string[]
            {
                "key",
                "type",
                "val"
            };
            InnerFiled._innerFiledFieldTags = new uint[]
            {
                10u,
                24u,
                18u
            };
            FileDescriptor arg_4D_0 = GtReq.Descriptor;
        }
    }
}
