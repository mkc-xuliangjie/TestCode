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
    public sealed class GtAuthResult : GeneratedMessage<GtAuthResult, GtAuthResult.Builder>
    {
        [DebuggerNonUserCode]
        public static class Types
        {
            public enum GtAuthResultCode
            {
                successed,
                failed_noSign,
                failed_noAppkey,
                failed_noTimestamp,
                failed_AuthIllegal,
                redirect
            }
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<GtAuthResult, GtAuthResult.Builder>
        {
            private bool resultIsReadOnly;

            private GtAuthResult result;

            protected override GtAuthResult.Builder ThisBuilder
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

            protected override GtAuthResult MessageBeingBuilt
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
                    return GtAuthResult.Descriptor;
                }
            }

            public override GtAuthResult DefaultInstanceForType
            {
                get
                {
                    return GtAuthResult.DefaultInstance;
                }
            }

            public bool HasCode
            {
                get
                {
                    return this.result.hasCode;
                }
            }

            public int Code
            {
                get
                {
                    return this.result.Code;
                }
                set
                {
                    this.SetCode(value);
                }
            }

            public bool HasRedirectAddress
            {
                get
                {
                    return this.result.hasRedirectAddress;
                }
            }

            public string RedirectAddress
            {
                get
                {
                    return this.result.RedirectAddress;
                }
                set
                {
                    this.SetRedirectAddress(value);
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

            public IPopsicleList<string> AppidList
            {
                get
                {
                    return this.PrepareBuilder().appid_;
                }
            }

            public int AppidCount
            {
                get
                {
                    return this.result.AppidCount;
                }
            }

            public Builder()
            {
                this.result = GtAuthResult.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GtAuthResult cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private GtAuthResult PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GtAuthResult other = this.result;
                    this.result = new GtAuthResult();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override GtAuthResult.Builder Clear()
            {
                this.result = GtAuthResult.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override GtAuthResult.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GtAuthResult.Builder(this.result);
                }
                return new GtAuthResult.Builder().MergeFrom(this.result);
            }

            public override GtAuthResult BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GtAuthResult.Builder MergeFrom(IMessage other)
            {
                if (other is GtAuthResult)
                {
                    return this.MergeFrom((GtAuthResult)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GtAuthResult.Builder MergeFrom(GtAuthResult other)
            {
                if (other == GtAuthResult.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasCode)
                {
                    this.Code = other.Code;
                }
                if (other.HasRedirectAddress)
                {
                    this.RedirectAddress = other.RedirectAddress;
                }
                if (other.HasSeqId)
                {
                    this.SeqId = other.SeqId;
                }
                if (other.HasInfo)
                {
                    this.Info = other.Info;
                }
                if (other.appid_.Count != 0)
                {
                    this.result.appid_.Add(other.appid_);
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override GtAuthResult.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GtAuthResult.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(GtAuthResult._gtAuthResultFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = GtAuthResult._gtAuthResultFieldTags[num2];
                    }
                    if (num <= 18u)
                    {
                        if (num == 0u)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 8u)
                        {
                            this.result.hasCode = input.ReadInt32(ref this.result.code_);
                            continue;
                        }
                        if (num == 18u)
                        {
                            this.result.hasRedirectAddress = input.ReadString(ref this.result.redirectAddress_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 26u)
                        {
                            this.result.hasSeqId = input.ReadString(ref this.result.seqId_);
                            continue;
                        }
                        if (num == 34u)
                        {
                            this.result.hasInfo = input.ReadString(ref this.result.info_);
                            continue;
                        }
                        if (num == 42u)
                        {
                            input.ReadStringArray(num, text, this.result.appid_);
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

            public GtAuthResult.Builder SetCode(int value)
            {
                this.PrepareBuilder();
                this.result.hasCode = true;
                this.result.code_ = value;
                return this;
            }

            public GtAuthResult.Builder ClearCode()
            {
                this.PrepareBuilder();
                this.result.hasCode = false;
                this.result.code_ = 0;
                return this;
            }

            public GtAuthResult.Builder SetRedirectAddress(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRedirectAddress = true;
                this.result.redirectAddress_ = value;
                return this;
            }

            public GtAuthResult.Builder ClearRedirectAddress()
            {
                this.PrepareBuilder();
                this.result.hasRedirectAddress = false;
                this.result.redirectAddress_ = "";
                return this;
            }

            public GtAuthResult.Builder SetSeqId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSeqId = true;
                this.result.seqId_ = value;
                return this;
            }

            public GtAuthResult.Builder ClearSeqId()
            {
                this.PrepareBuilder();
                this.result.hasSeqId = false;
                this.result.seqId_ = "";
                return this;
            }

            public GtAuthResult.Builder SetInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasInfo = true;
                this.result.info_ = value;
                return this;
            }

            public GtAuthResult.Builder ClearInfo()
            {
                this.PrepareBuilder();
                this.result.hasInfo = false;
                this.result.info_ = "";
                return this;
            }

            public string GetAppid(int index)
            {
                return this.result.GetAppid(index);
            }

            public GtAuthResult.Builder SetAppid(int index, string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.appid_[index] = value;
                return this;
            }

            public GtAuthResult.Builder AddAppid(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.appid_.Add(value);
                return this;
            }

            public GtAuthResult.Builder AddRangeAppid(IEnumerable<string> values)
            {
                this.PrepareBuilder();
                this.result.appid_.Add(values);
                return this;
            }

            public GtAuthResult.Builder ClearAppid()
            {
                this.PrepareBuilder();
                this.result.appid_.Clear();
                return this;
            }
        }

        private static readonly GtAuthResult defaultInstance;

        private static readonly string[] _gtAuthResultFieldNames;

        private static readonly uint[] _gtAuthResultFieldTags;

        public const int CodeFieldNumber = 1;

        private bool hasCode;

        private int code_;

        public const int RedirectAddressFieldNumber = 2;

        private bool hasRedirectAddress;

        private string redirectAddress_ = "";

        public const int SeqIdFieldNumber = 3;

        private bool hasSeqId;

        private string seqId_ = "";

        public const int InfoFieldNumber = 4;

        private bool hasInfo;

        private string info_ = "";

        public const int AppidFieldNumber = 5;

        private PopsicleList<string> appid_ = new PopsicleList<string>();

        private int memoizedSerializedSize = -1;

        public static GtAuthResult DefaultInstance
        {
            get
            {
                return GtAuthResult.defaultInstance;
            }
        }

        public override GtAuthResult DefaultInstanceForType
        {
            get
            {
                return GtAuthResult.DefaultInstance;
            }
        }

        protected override GtAuthResult ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_GtAuthResult__Descriptor;
            }
        }

        protected override FieldAccessorTable<GtAuthResult, GtAuthResult.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_GtAuthResult__FieldAccessorTable;
            }
        }

        public bool HasCode
        {
            get
            {
                return this.hasCode;
            }
        }

        public int Code
        {
            get
            {
                return this.code_;
            }
        }

        public bool HasRedirectAddress
        {
            get
            {
                return this.hasRedirectAddress;
            }
        }

        public string RedirectAddress
        {
            get
            {
                return this.redirectAddress_;
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

        public IList<string> AppidList
        {
            get
            {
                return Lists.AsReadOnly<string>(this.appid_);
            }
        }

        public int AppidCount
        {
            get
            {
                return this.appid_.Count;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                return this.hasCode;
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
                if (this.hasCode)
                {
                    num += CodedOutputStream.ComputeInt32Size(1, this.Code);
                }
                if (this.hasRedirectAddress)
                {
                    num += CodedOutputStream.ComputeStringSize(2, this.RedirectAddress);
                }
                if (this.hasSeqId)
                {
                    num += CodedOutputStream.ComputeStringSize(3, this.SeqId);
                }
                if (this.hasInfo)
                {
                    num += CodedOutputStream.ComputeStringSize(4, this.Info);
                }
                int num2 = 0;
                foreach (string current in this.AppidList)
                {
                    num2 += CodedOutputStream.ComputeStringSizeNoTag(current);
                }
                num += num2;
                num += this.appid_.Count;
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private GtAuthResult()
        {
        }

        public string GetAppid(int index)
        {
            return this.appid_[index];
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] gtAuthResultFieldNames = GtAuthResult._gtAuthResultFieldNames;
            if (this.hasCode)
            {
                output.WriteInt32(1, gtAuthResultFieldNames[1], this.Code);
            }
            if (this.hasRedirectAddress)
            {
                output.WriteString(2, gtAuthResultFieldNames[3], this.RedirectAddress);
            }
            if (this.hasSeqId)
            {
                output.WriteString(3, gtAuthResultFieldNames[4], this.SeqId);
            }
            if (this.hasInfo)
            {
                output.WriteString(4, gtAuthResultFieldNames[2], this.Info);
            }
            if (this.appid_.Count > 0)
            {
                output.WriteStringArray(5, gtAuthResultFieldNames[0], this.appid_);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static GtAuthResult ParseFrom(ByteString data)
        {
            return GtAuthResult.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static GtAuthResult ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return GtAuthResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static GtAuthResult ParseFrom(byte[] data)
        {
            return GtAuthResult.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static GtAuthResult ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return GtAuthResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static GtAuthResult ParseFrom(Stream input)
        {
            return GtAuthResult.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static GtAuthResult ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return GtAuthResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static GtAuthResult ParseDelimitedFrom(Stream input)
        {
            return GtAuthResult.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static GtAuthResult ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return GtAuthResult.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static GtAuthResult ParseFrom(ICodedInputStream input)
        {
            return GtAuthResult.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static GtAuthResult ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return GtAuthResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private GtAuthResult MakeReadOnly()
        {
            this.appid_.MakeReadOnly();
            return this;
        }

        public static GtAuthResult.Builder CreateBuilder()
        {
            return new GtAuthResult.Builder();
        }

        public override GtAuthResult.Builder ToBuilder()
        {
            return GtAuthResult.CreateBuilder(this);
        }

        public override GtAuthResult.Builder CreateBuilderForType()
        {
            return new GtAuthResult.Builder();
        }

        public static GtAuthResult.Builder CreateBuilder(GtAuthResult prototype)
        {
            return new GtAuthResult.Builder(prototype);
        }

        static GtAuthResult()
        {
            GtAuthResult.defaultInstance = new GtAuthResult().MakeReadOnly();
            GtAuthResult._gtAuthResultFieldNames = new string[]
            {
                "appid",
                "code",
                "info",
                "redirectAddress",
                "seqId"
            };
            GtAuthResult._gtAuthResultFieldTags = new uint[]
            {
                42u,
                8u,
                34u,
                18u,
                26u
            };
            FileDescriptor arg_5D_0 = GtReq.Descriptor;
        }
    }
}
