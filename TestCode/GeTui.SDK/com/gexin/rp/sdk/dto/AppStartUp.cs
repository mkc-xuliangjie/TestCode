using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class AppStartUp : GeneratedMessage<AppStartUp, AppStartUp.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<AppStartUp, AppStartUp.Builder>
        {
            private bool resultIsReadOnly;

            private AppStartUp result;

            protected override AppStartUp.Builder ThisBuilder
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

            protected override AppStartUp MessageBeingBuilt
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
                    return AppStartUp.Descriptor;
                }
            }

            public override AppStartUp DefaultInstanceForType
            {
                get
                {
                    return AppStartUp.DefaultInstance;
                }
            }

            public bool HasAndroid
            {
                get
                {
                    return this.result.hasAndroid;
                }
            }

            public string Android
            {
                get
                {
                    return this.result.Android;
                }
                set
                {
                    this.SetAndroid(value);
                }
            }

            public bool HasSymbia
            {
                get
                {
                    return this.result.hasSymbia;
                }
            }

            public string Symbia
            {
                get
                {
                    return this.result.Symbia;
                }
                set
                {
                    this.SetSymbia(value);
                }
            }

            public bool HasIos
            {
                get
                {
                    return this.result.hasIos;
                }
            }

            public string Ios
            {
                get
                {
                    return this.result.Ios;
                }
                set
                {
                    this.SetIos(value);
                }
            }

            public Builder()
            {
                this.result = AppStartUp.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(AppStartUp cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private AppStartUp PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    AppStartUp other = this.result;
                    this.result = new AppStartUp();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override AppStartUp.Builder Clear()
            {
                this.result = AppStartUp.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override AppStartUp.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new AppStartUp.Builder(this.result);
                }
                return new AppStartUp.Builder().MergeFrom(this.result);
            }

            public override AppStartUp BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override AppStartUp.Builder MergeFrom(IMessage other)
            {
                if (other is AppStartUp)
                {
                    return this.MergeFrom((AppStartUp)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override AppStartUp.Builder MergeFrom(AppStartUp other)
            {
                if (other == AppStartUp.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasAndroid)
                {
                    this.Android = other.Android;
                }
                if (other.HasSymbia)
                {
                    this.Symbia = other.Symbia;
                }
                if (other.HasIos)
                {
                    this.Ios = other.Ios;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override AppStartUp.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override AppStartUp.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(AppStartUp._appStartUpFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = AppStartUp._appStartUpFieldTags[num2];
                    }
                    if (num <= 10u)
                    {
                        if (num == 0u)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10u)
                        {
                            this.result.hasAndroid = input.ReadString(ref this.result.android_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18u)
                        {
                            this.result.hasSymbia = input.ReadString(ref this.result.symbia_);
                            continue;
                        }
                        if (num == 26u)
                        {
                            this.result.hasIos = input.ReadString(ref this.result.ios_);
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

            public AppStartUp.Builder SetAndroid(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAndroid = true;
                this.result.android_ = value;
                return this;
            }

            public AppStartUp.Builder ClearAndroid()
            {
                this.PrepareBuilder();
                this.result.hasAndroid = false;
                this.result.android_ = "";
                return this;
            }

            public AppStartUp.Builder SetSymbia(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSymbia = true;
                this.result.symbia_ = value;
                return this;
            }

            public AppStartUp.Builder ClearSymbia()
            {
                this.PrepareBuilder();
                this.result.hasSymbia = false;
                this.result.symbia_ = "";
                return this;
            }

            public AppStartUp.Builder SetIos(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasIos = true;
                this.result.ios_ = value;
                return this;
            }

            public AppStartUp.Builder ClearIos()
            {
                this.PrepareBuilder();
                this.result.hasIos = false;
                this.result.ios_ = "";
                return this;
            }
        }

        private static readonly AppStartUp defaultInstance;

        private static readonly string[] _appStartUpFieldNames;

        private static readonly uint[] _appStartUpFieldTags;

        public const int AndroidFieldNumber = 1;

        private bool hasAndroid;

        private string android_ = "";

        public const int SymbiaFieldNumber = 2;

        private bool hasSymbia;

        private string symbia_ = "";

        public const int IosFieldNumber = 3;

        private bool hasIos;

        private string ios_ = "";

        private int memoizedSerializedSize = -1;

        public static AppStartUp DefaultInstance
        {
            get
            {
                return AppStartUp.defaultInstance;
            }
        }

        public override AppStartUp DefaultInstanceForType
        {
            get
            {
                return AppStartUp.DefaultInstance;
            }
        }

        protected override AppStartUp ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_AppStartUp__Descriptor;
            }
        }

        protected override FieldAccessorTable<AppStartUp, AppStartUp.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_AppStartUp__FieldAccessorTable;
            }
        }

        public bool HasAndroid
        {
            get
            {
                return this.hasAndroid;
            }
        }

        public string Android
        {
            get
            {
                return this.android_;
            }
        }

        public bool HasSymbia
        {
            get
            {
                return this.hasSymbia;
            }
        }

        public string Symbia
        {
            get
            {
                return this.symbia_;
            }
        }

        public bool HasIos
        {
            get
            {
                return this.hasIos;
            }
        }

        public string Ios
        {
            get
            {
                return this.ios_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
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
                if (this.hasAndroid)
                {
                    num += CodedOutputStream.ComputeStringSize(1, this.Android);
                }
                if (this.hasSymbia)
                {
                    num += CodedOutputStream.ComputeStringSize(2, this.Symbia);
                }
                if (this.hasIos)
                {
                    num += CodedOutputStream.ComputeStringSize(3, this.Ios);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private AppStartUp()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] appStartUpFieldNames = AppStartUp._appStartUpFieldNames;
            if (this.hasAndroid)
            {
                output.WriteString(1, appStartUpFieldNames[0], this.Android);
            }
            if (this.hasSymbia)
            {
                output.WriteString(2, appStartUpFieldNames[2], this.Symbia);
            }
            if (this.hasIos)
            {
                output.WriteString(3, appStartUpFieldNames[1], this.Ios);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static AppStartUp ParseFrom(ByteString data)
        {
            return AppStartUp.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static AppStartUp ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return AppStartUp.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static AppStartUp ParseFrom(byte[] data)
        {
            return AppStartUp.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static AppStartUp ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return AppStartUp.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static AppStartUp ParseFrom(Stream input)
        {
            return AppStartUp.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static AppStartUp ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return AppStartUp.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static AppStartUp ParseDelimitedFrom(Stream input)
        {
            return AppStartUp.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static AppStartUp ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return AppStartUp.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static AppStartUp ParseFrom(ICodedInputStream input)
        {
            return AppStartUp.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static AppStartUp ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return AppStartUp.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private AppStartUp MakeReadOnly()
        {
            return this;
        }

        public static AppStartUp.Builder CreateBuilder()
        {
            return new AppStartUp.Builder();
        }

        public override AppStartUp.Builder ToBuilder()
        {
            return AppStartUp.CreateBuilder(this);
        }

        public override AppStartUp.Builder CreateBuilderForType()
        {
            return new AppStartUp.Builder();
        }

        public static AppStartUp.Builder CreateBuilder(AppStartUp prototype)
        {
            return new AppStartUp.Builder(prototype);
        }

        static AppStartUp()
        {
            AppStartUp.defaultInstance = new AppStartUp().MakeReadOnly();
            AppStartUp._appStartUpFieldNames = new string[]
            {
                "android",
                "ios",
                "symbia"
            };
            AppStartUp._appStartUpFieldTags = new uint[]
            {
                10u,
                26u,
                18u
            };
            FileDescriptor arg_4D_0 = GtReq.Descriptor;
        }
    }
}
