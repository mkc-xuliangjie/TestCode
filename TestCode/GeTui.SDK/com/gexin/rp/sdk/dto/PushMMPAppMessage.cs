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
    public sealed class PushMMPAppMessage : GeneratedMessage<PushMMPAppMessage, PushMMPAppMessage.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<PushMMPAppMessage, PushMMPAppMessage.Builder>
        {
            private bool resultIsReadOnly;

            private PushMMPAppMessage result;

            protected override PushMMPAppMessage.Builder ThisBuilder
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

            protected override PushMMPAppMessage MessageBeingBuilt
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
                    return PushMMPAppMessage.Descriptor;
                }
            }

            public override PushMMPAppMessage DefaultInstanceForType
            {
                get
                {
                    return PushMMPAppMessage.DefaultInstance;
                }
            }

            public bool HasMessage
            {
                get
                {
                    return this.result.hasMessage;
                }
            }

            public MMPMessage Message
            {
                get
                {
                    return this.result.Message;
                }
                set
                {
                    this.SetMessage(value);
                }
            }

            public IPopsicleList<string> AppIdListList
            {
                get
                {
                    return this.PrepareBuilder().appIdList_;
                }
            }

            public int AppIdListCount
            {
                get
                {
                    return this.result.AppIdListCount;
                }
            }

            public IPopsicleList<string> PhoneTypeListList
            {
                get
                {
                    return this.PrepareBuilder().phoneTypeList_;
                }
            }

            public int PhoneTypeListCount
            {
                get
                {
                    return this.result.PhoneTypeListCount;
                }
            }

            public IPopsicleList<string> ProvinceListList
            {
                get
                {
                    return this.PrepareBuilder().provinceList_;
                }
            }

            public int ProvinceListCount
            {
                get
                {
                    return this.result.ProvinceListCount;
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
                this.result = PushMMPAppMessage.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(PushMMPAppMessage cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private PushMMPAppMessage PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    PushMMPAppMessage other = this.result;
                    this.result = new PushMMPAppMessage();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override PushMMPAppMessage.Builder Clear()
            {
                this.result = PushMMPAppMessage.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override PushMMPAppMessage.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new PushMMPAppMessage.Builder(this.result);
                }
                return new PushMMPAppMessage.Builder().MergeFrom(this.result);
            }

            public override PushMMPAppMessage BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override PushMMPAppMessage.Builder MergeFrom(IMessage other)
            {
                if (other is PushMMPAppMessage)
                {
                    return this.MergeFrom((PushMMPAppMessage)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override PushMMPAppMessage.Builder MergeFrom(PushMMPAppMessage other)
            {
                if (other == PushMMPAppMessage.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasMessage)
                {
                    this.MergeMessage(other.Message);
                }
                if (other.appIdList_.Count != 0)
                {
                    this.result.appIdList_.Add(other.appIdList_);
                }
                if (other.phoneTypeList_.Count != 0)
                {
                    this.result.phoneTypeList_.Add(other.phoneTypeList_);
                }
                if (other.provinceList_.Count != 0)
                {
                    this.result.provinceList_.Add(other.provinceList_);
                }
                if (other.HasSeqId)
                {
                    this.SeqId = other.SeqId;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override PushMMPAppMessage.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override PushMMPAppMessage.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(PushMMPAppMessage._pushMMPAppMessageFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = PushMMPAppMessage._pushMMPAppMessageFieldTags[num2];
                    }
                    if (num <= 18u)
                    {
                        if (num == 0u)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10u)
                        {
                            MMPMessage.Builder builder2 = MMPMessage.CreateBuilder();
                            if (this.result.hasMessage)
                            {
                                builder2.MergeFrom(this.Message);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.Message = builder2.BuildPartial();
                            continue;
                        }
                        if (num == 18u)
                        {
                            input.ReadStringArray(num, text, this.result.appIdList_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 26u)
                        {
                            input.ReadStringArray(num, text, this.result.phoneTypeList_);
                            continue;
                        }
                        if (num == 34u)
                        {
                            input.ReadStringArray(num, text, this.result.provinceList_);
                            continue;
                        }
                        if (num == 42u)
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

            public PushMMPAppMessage.Builder SetMessage(MMPMessage value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMessage = true;
                this.result.message_ = value;
                return this;
            }

            public PushMMPAppMessage.Builder SetMessage(MMPMessage.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMessage = true;
                this.result.message_ = builderForValue.Build();
                return this;
            }

            public PushMMPAppMessage.Builder MergeMessage(MMPMessage value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasMessage && this.result.message_ != MMPMessage.DefaultInstance)
                {
                    this.result.message_ = MMPMessage.CreateBuilder(this.result.message_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.message_ = value;
                }
                this.result.hasMessage = true;
                return this;
            }

            public PushMMPAppMessage.Builder ClearMessage()
            {
                this.PrepareBuilder();
                this.result.hasMessage = false;
                this.result.message_ = null;
                return this;
            }

            public string GetAppIdList(int index)
            {
                return this.result.GetAppIdList(index);
            }

            public PushMMPAppMessage.Builder SetAppIdList(int index, string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.appIdList_[index] = value;
                return this;
            }

            public PushMMPAppMessage.Builder AddAppIdList(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.appIdList_.Add(value);
                return this;
            }

            public PushMMPAppMessage.Builder AddRangeAppIdList(IEnumerable<string> values)
            {
                this.PrepareBuilder();
                this.result.appIdList_.Add(values);
                return this;
            }

            public PushMMPAppMessage.Builder ClearAppIdList()
            {
                this.PrepareBuilder();
                this.result.appIdList_.Clear();
                return this;
            }

            public string GetPhoneTypeList(int index)
            {
                return this.result.GetPhoneTypeList(index);
            }

            public PushMMPAppMessage.Builder SetPhoneTypeList(int index, string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.phoneTypeList_[index] = value;
                return this;
            }

            public PushMMPAppMessage.Builder AddPhoneTypeList(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.phoneTypeList_.Add(value);
                return this;
            }

            public PushMMPAppMessage.Builder AddRangePhoneTypeList(IEnumerable<string> values)
            {
                this.PrepareBuilder();
                this.result.phoneTypeList_.Add(values);
                return this;
            }

            public PushMMPAppMessage.Builder ClearPhoneTypeList()
            {
                this.PrepareBuilder();
                this.result.phoneTypeList_.Clear();
                return this;
            }

            public string GetProvinceList(int index)
            {
                return this.result.GetProvinceList(index);
            }

            public PushMMPAppMessage.Builder SetProvinceList(int index, string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.provinceList_[index] = value;
                return this;
            }

            public PushMMPAppMessage.Builder AddProvinceList(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.provinceList_.Add(value);
                return this;
            }

            public PushMMPAppMessage.Builder AddRangeProvinceList(IEnumerable<string> values)
            {
                this.PrepareBuilder();
                this.result.provinceList_.Add(values);
                return this;
            }

            public PushMMPAppMessage.Builder ClearProvinceList()
            {
                this.PrepareBuilder();
                this.result.provinceList_.Clear();
                return this;
            }

            public PushMMPAppMessage.Builder SetSeqId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSeqId = true;
                this.result.seqId_ = value;
                return this;
            }

            public PushMMPAppMessage.Builder ClearSeqId()
            {
                this.PrepareBuilder();
                this.result.hasSeqId = false;
                this.result.seqId_ = "";
                return this;
            }
        }

        private static readonly PushMMPAppMessage defaultInstance;

        private static readonly string[] _pushMMPAppMessageFieldNames;

        private static readonly uint[] _pushMMPAppMessageFieldTags;

        public const int MessageFieldNumber = 1;

        private bool hasMessage;

        private MMPMessage message_;

        public const int AppIdListFieldNumber = 2;

        private PopsicleList<string> appIdList_ = new PopsicleList<string>();

        public const int PhoneTypeListFieldNumber = 3;

        private PopsicleList<string> phoneTypeList_ = new PopsicleList<string>();

        public const int ProvinceListFieldNumber = 4;

        private PopsicleList<string> provinceList_ = new PopsicleList<string>();

        public const int SeqIdFieldNumber = 5;

        private bool hasSeqId;

        private string seqId_ = "";

        private int memoizedSerializedSize = -1;

        public static PushMMPAppMessage DefaultInstance
        {
            get
            {
                return PushMMPAppMessage.defaultInstance;
            }
        }

        public override PushMMPAppMessage DefaultInstanceForType
        {
            get
            {
                return PushMMPAppMessage.DefaultInstance;
            }
        }

        protected override PushMMPAppMessage ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPAppMessage__Descriptor;
            }
        }

        protected override FieldAccessorTable<PushMMPAppMessage, PushMMPAppMessage.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPAppMessage__FieldAccessorTable;
            }
        }

        public bool HasMessage
        {
            get
            {
                return this.hasMessage;
            }
        }

        public MMPMessage Message
        {
            get
            {
                return this.message_ ?? MMPMessage.DefaultInstance;
            }
        }

        public IList<string> AppIdListList
        {
            get
            {
                return Lists.AsReadOnly<string>(this.appIdList_);
            }
        }

        public int AppIdListCount
        {
            get
            {
                return this.appIdList_.Count;
            }
        }

        public IList<string> PhoneTypeListList
        {
            get
            {
                return Lists.AsReadOnly<string>(this.phoneTypeList_);
            }
        }

        public int PhoneTypeListCount
        {
            get
            {
                return this.phoneTypeList_.Count;
            }
        }

        public IList<string> ProvinceListList
        {
            get
            {
                return Lists.AsReadOnly<string>(this.provinceList_);
            }
        }

        public int ProvinceListCount
        {
            get
            {
                return this.provinceList_.Count;
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
                return this.hasMessage && this.Message.IsInitialized;
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
                if (this.hasMessage)
                {
                    num += CodedOutputStream.ComputeMessageSize(1, this.Message);
                }
                int num2 = 0;
                foreach (string current in this.AppIdListList)
                {
                    num2 += CodedOutputStream.ComputeStringSizeNoTag(current);
                }
                num += num2;
                num += this.appIdList_.Count;
                int num3 = 0;
                foreach (string current2 in this.PhoneTypeListList)
                {
                    num3 += CodedOutputStream.ComputeStringSizeNoTag(current2);
                }
                num += num3;
                num += this.phoneTypeList_.Count;
                int num4 = 0;
                foreach (string current3 in this.ProvinceListList)
                {
                    num4 += CodedOutputStream.ComputeStringSizeNoTag(current3);
                }
                num += num4;
                num += this.provinceList_.Count;
                if (this.hasSeqId)
                {
                    num += CodedOutputStream.ComputeStringSize(5, this.SeqId);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private PushMMPAppMessage()
        {
        }

        public string GetAppIdList(int index)
        {
            return this.appIdList_[index];
        }

        public string GetPhoneTypeList(int index)
        {
            return this.phoneTypeList_[index];
        }

        public string GetProvinceList(int index)
        {
            return this.provinceList_[index];
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] pushMMPAppMessageFieldNames = PushMMPAppMessage._pushMMPAppMessageFieldNames;
            if (this.hasMessage)
            {
                output.WriteMessage(1, pushMMPAppMessageFieldNames[1], this.Message);
            }
            if (this.appIdList_.Count > 0)
            {
                output.WriteStringArray(2, pushMMPAppMessageFieldNames[0], this.appIdList_);
            }
            if (this.phoneTypeList_.Count > 0)
            {
                output.WriteStringArray(3, pushMMPAppMessageFieldNames[2], this.phoneTypeList_);
            }
            if (this.provinceList_.Count > 0)
            {
                output.WriteStringArray(4, pushMMPAppMessageFieldNames[3], this.provinceList_);
            }
            if (this.hasSeqId)
            {
                output.WriteString(5, pushMMPAppMessageFieldNames[4], this.SeqId);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static PushMMPAppMessage ParseFrom(ByteString data)
        {
            return PushMMPAppMessage.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushMMPAppMessage ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return PushMMPAppMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushMMPAppMessage ParseFrom(byte[] data)
        {
            return PushMMPAppMessage.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static PushMMPAppMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return PushMMPAppMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static PushMMPAppMessage ParseFrom(Stream input)
        {
            return PushMMPAppMessage.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushMMPAppMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushMMPAppMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushMMPAppMessage ParseDelimitedFrom(Stream input)
        {
            return PushMMPAppMessage.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static PushMMPAppMessage ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return PushMMPAppMessage.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static PushMMPAppMessage ParseFrom(ICodedInputStream input)
        {
            return PushMMPAppMessage.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static PushMMPAppMessage ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return PushMMPAppMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private PushMMPAppMessage MakeReadOnly()
        {
            this.appIdList_.MakeReadOnly();
            this.phoneTypeList_.MakeReadOnly();
            this.provinceList_.MakeReadOnly();
            return this;
        }

        public static PushMMPAppMessage.Builder CreateBuilder()
        {
            return new PushMMPAppMessage.Builder();
        }

        public override PushMMPAppMessage.Builder ToBuilder()
        {
            return PushMMPAppMessage.CreateBuilder(this);
        }

        public override PushMMPAppMessage.Builder CreateBuilderForType()
        {
            return new PushMMPAppMessage.Builder();
        }

        public static PushMMPAppMessage.Builder CreateBuilder(PushMMPAppMessage prototype)
        {
            return new PushMMPAppMessage.Builder(prototype);
        }

        static PushMMPAppMessage()
        {
            PushMMPAppMessage.defaultInstance = new PushMMPAppMessage().MakeReadOnly();
            PushMMPAppMessage._pushMMPAppMessageFieldNames = new string[]
            {
                "appIdList",
                "message",
                "phoneTypeList",
                "provinceList",
                "seqId"
            };
            PushMMPAppMessage._pushMMPAppMessageFieldTags = new uint[]
            {
                18u,
                10u,
                26u,
                34u,
                42u
            };
            FileDescriptor arg_5D_0 = GtReq.Descriptor;
        }
    }
}
