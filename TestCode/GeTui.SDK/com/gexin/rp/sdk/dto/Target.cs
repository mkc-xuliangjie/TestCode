using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class Target : GeneratedMessage<Target, Target.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<Target, Target.Builder>
        {
            private bool resultIsReadOnly;

            private Target result;

            protected override Target.Builder ThisBuilder
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

            protected override Target MessageBeingBuilt
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
                    return Target.Descriptor;
                }
            }

            public override Target DefaultInstanceForType
            {
                get
                {
                    return Target.DefaultInstance;
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

            public bool HasClientId
            {
                get
                {
                    return this.result.hasClientId;
                }
            }

            public string ClientId
            {
                get
                {
                    return this.result.ClientId;
                }
                set
                {
                    this.SetClientId(value);
                }
            }

            public bool HasAlias
            {
                get
                {
                    return this.result.hasAlias;
                }
            }

            public string Alias
            {
                get
                {
                    return this.result.Alias;
                }
                set
                {
                    this.SetAlias(value);
                }
            }

            public Builder()
            {
                this.result = Target.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(Target cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private Target PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    Target other = this.result;
                    this.result = new Target();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override Target.Builder Clear()
            {
                this.result = Target.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override Target.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new Target.Builder(this.result);
                }
                return new Target.Builder().MergeFrom(this.result);
            }

            public override Target BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override Target.Builder MergeFrom(IMessage other)
            {
                if (other is Target)
                {
                    return this.MergeFrom((Target)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override Target.Builder MergeFrom(Target other)
            {
                if (other == Target.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasAppId)
                {
                    this.AppId = other.AppId;
                }
                if (other.HasClientId)
                {
                    this.ClientId = other.ClientId;
                }
                if (other.HasAlias)
                {
                    this.Alias = other.Alias;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override Target.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override Target.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(Target._targetFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = Target._targetFieldTags[num2];
                    }
                    if (num <= 10u)
                    {
                        if (num == 0u)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10u)
                        {
                            this.result.hasAppId = input.ReadString(ref this.result.appId_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18u)
                        {
                            this.result.hasClientId = input.ReadString(ref this.result.clientId_);
                            continue;
                        }
                        if (num == 26u)
                        {
                            this.result.hasAlias = input.ReadString(ref this.result.alias_);
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

            public Target.Builder SetAppId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppId = true;
                this.result.appId_ = value;
                return this;
            }

            public Target.Builder ClearAppId()
            {
                this.PrepareBuilder();
                this.result.hasAppId = false;
                this.result.appId_ = "";
                return this;
            }

            public Target.Builder SetClientId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientId = true;
                this.result.clientId_ = value;
                return this;
            }

            public Target.Builder ClearClientId()
            {
                this.PrepareBuilder();
                this.result.hasClientId = false;
                this.result.clientId_ = "";
                return this;
            }

            public Target.Builder SetAlias(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAlias = true;
                this.result.alias_ = value;
                return this;
            }

            public Target.Builder ClearAlias()
            {
                this.PrepareBuilder();
                this.result.hasAlias = false;
                this.result.alias_ = "";
                return this;
            }
        }

        private static readonly Target defaultInstance;

        private static readonly string[] _targetFieldNames;

        private static readonly uint[] _targetFieldTags;

        public const int AppIdFieldNumber = 1;

        private bool hasAppId;

        private string appId_ = "";

        public const int ClientIdFieldNumber = 2;

        private bool hasClientId;

        private string clientId_ = "";

        public const int AliasFieldNumber = 3;

        private bool hasAlias;

        private string alias_ = "";

        private int memoizedSerializedSize = -1;

        public static Target DefaultInstance
        {
            get
            {
                return Target.defaultInstance;
            }
        }

        public override Target DefaultInstanceForType
        {
            get
            {
                return Target.DefaultInstance;
            }
        }

        protected override Target ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_Target__Descriptor;
            }
        }

        protected override FieldAccessorTable<Target, Target.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_Target__FieldAccessorTable;
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

        public bool HasClientId
        {
            get
            {
                return this.hasClientId;
            }
        }

        public string ClientId
        {
            get
            {
                return this.clientId_;
            }
        }

        public bool HasAlias
        {
            get
            {
                return this.hasAlias;
            }
        }

        public string Alias
        {
            get
            {
                return this.alias_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                return this.hasAppId && this.hasClientId;
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
                if (this.hasAppId)
                {
                    num += CodedOutputStream.ComputeStringSize(1, this.AppId);
                }
                if (this.hasClientId)
                {
                    num += CodedOutputStream.ComputeStringSize(2, this.ClientId);
                }
                if (this.hasAlias)
                {
                    num += CodedOutputStream.ComputeStringSize(3, this.Alias);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private Target()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] targetFieldNames = Target._targetFieldNames;
            if (this.hasAppId)
            {
                output.WriteString(1, targetFieldNames[1], this.AppId);
            }
            if (this.hasClientId)
            {
                output.WriteString(2, targetFieldNames[2], this.ClientId);
            }
            if (this.hasAlias)
            {
                output.WriteString(3, targetFieldNames[0], this.Alias);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static Target ParseFrom(ByteString data)
        {
            return Target.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static Target ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return Target.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static Target ParseFrom(byte[] data)
        {
            return Target.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static Target ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return Target.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static Target ParseFrom(Stream input)
        {
            return Target.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static Target ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return Target.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static Target ParseDelimitedFrom(Stream input)
        {
            return Target.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static Target ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return Target.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static Target ParseFrom(ICodedInputStream input)
        {
            return Target.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static Target ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return Target.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private Target MakeReadOnly()
        {
            return this;
        }

        public static Target.Builder CreateBuilder()
        {
            return new Target.Builder();
        }

        public override Target.Builder ToBuilder()
        {
            return Target.CreateBuilder(this);
        }

        public override Target.Builder CreateBuilderForType()
        {
            return new Target.Builder();
        }

        public static Target.Builder CreateBuilder(Target prototype)
        {
            return new Target.Builder(prototype);
        }

        static Target()
        {
            Target.defaultInstance = new Target().MakeReadOnly();
            Target._targetFieldNames = new string[]
            {
                "alias",
                "appId",
                "clientId"
            };
            Target._targetFieldTags = new uint[]
            {
                26u,
                10u,
                18u
            };
            FileDescriptor arg_4D_0 = GtReq.Descriptor;
        }
    }
}
