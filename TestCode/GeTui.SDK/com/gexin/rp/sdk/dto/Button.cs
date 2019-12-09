using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class Button : GeneratedMessage<Button, Button.Builder>
    {
        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<Button, Button.Builder>
        {
            private bool resultIsReadOnly;

            private Button result;

            protected override Button.Builder ThisBuilder
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

            protected override Button MessageBeingBuilt
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
                    return Button.Descriptor;
                }
            }

            public override Button DefaultInstanceForType
            {
                get
                {
                    return Button.DefaultInstance;
                }
            }

            public bool HasText
            {
                get
                {
                    return this.result.hasText;
                }
            }

            public string Text
            {
                get
                {
                    return this.result.Text;
                }
                set
                {
                    this.SetText(value);
                }
            }

            public bool HasNext
            {
                get
                {
                    return this.result.hasNext;
                }
            }

            public int Next
            {
                get
                {
                    return this.result.Next;
                }
                set
                {
                    this.SetNext(value);
                }
            }

            public Builder()
            {
                this.result = Button.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(Button cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private Button PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    Button other = this.result;
                    this.result = new Button();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override Button.Builder Clear()
            {
                this.result = Button.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override Button.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new Button.Builder(this.result);
                }
                return new Button.Builder().MergeFrom(this.result);
            }

            public override Button BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override Button.Builder MergeFrom(IMessage other)
            {
                if (other is Button)
                {
                    return this.MergeFrom((Button)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override Button.Builder MergeFrom(Button other)
            {
                if (other == Button.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasText)
                {
                    this.Text = other.Text;
                }
                if (other.HasNext)
                {
                    this.Next = other.Next;
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override Button.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override Button.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(Button._buttonFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = Button._buttonFieldTags[num2];
                    }
                    if (num == 0u)
                    {
                        throw InvalidProtocolBufferException.InvalidTag();
                    }
                    if (num != 10u)
                    {
                        if (num != 16u)
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
                            this.result.hasNext = input.ReadInt32(ref this.result.next_);
                        }
                    }
                    else
                    {
                        this.result.hasText = input.ReadString(ref this.result.text_);
                    }
                }
                if (builder != null)
                {
                    this.UnknownFields = builder.Build();
                }
                return this;
            }

            public Button.Builder SetText(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasText = true;
                this.result.text_ = value;
                return this;
            }

            public Button.Builder ClearText()
            {
                this.PrepareBuilder();
                this.result.hasText = false;
                this.result.text_ = "";
                return this;
            }

            public Button.Builder SetNext(int value)
            {
                this.PrepareBuilder();
                this.result.hasNext = true;
                this.result.next_ = value;
                return this;
            }

            public Button.Builder ClearNext()
            {
                this.PrepareBuilder();
                this.result.hasNext = false;
                this.result.next_ = 0;
                return this;
            }
        }

        private static readonly Button defaultInstance;

        private static readonly string[] _buttonFieldNames;

        private static readonly uint[] _buttonFieldTags;

        public const int TextFieldNumber = 1;

        private bool hasText;

        private string text_ = "";

        public const int NextFieldNumber = 2;

        private bool hasNext;

        private int next_;

        private int memoizedSerializedSize = -1;

        public static Button DefaultInstance
        {
            get
            {
                return Button.defaultInstance;
            }
        }

        public override Button DefaultInstanceForType
        {
            get
            {
                return Button.DefaultInstance;
            }
        }

        protected override Button ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_Button__Descriptor;
            }
        }

        protected override FieldAccessorTable<Button, Button.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_Button__FieldAccessorTable;
            }
        }

        public bool HasText
        {
            get
            {
                return this.hasText;
            }
        }

        public string Text
        {
            get
            {
                return this.text_;
            }
        }

        public bool HasNext
        {
            get
            {
                return this.hasNext;
            }
        }

        public int Next
        {
            get
            {
                return this.next_;
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
                if (this.hasText)
                {
                    num += CodedOutputStream.ComputeStringSize(1, this.Text);
                }
                if (this.hasNext)
                {
                    num += CodedOutputStream.ComputeInt32Size(2, this.Next);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private Button()
        {
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] buttonFieldNames = Button._buttonFieldNames;
            if (this.hasText)
            {
                output.WriteString(1, buttonFieldNames[1], this.Text);
            }
            if (this.hasNext)
            {
                output.WriteInt32(2, buttonFieldNames[0], this.Next);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static Button ParseFrom(ByteString data)
        {
            return Button.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static Button ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return Button.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static Button ParseFrom(byte[] data)
        {
            return Button.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static Button ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return Button.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static Button ParseFrom(Stream input)
        {
            return Button.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static Button ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return Button.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static Button ParseDelimitedFrom(Stream input)
        {
            return Button.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static Button ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return Button.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static Button ParseFrom(ICodedInputStream input)
        {
            return Button.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static Button ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return Button.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private Button MakeReadOnly()
        {
            return this;
        }

        public static Button.Builder CreateBuilder()
        {
            return new Button.Builder();
        }

        public override Button.Builder ToBuilder()
        {
            return Button.CreateBuilder(this);
        }

        public override Button.Builder CreateBuilderForType()
        {
            return new Button.Builder();
        }

        public static Button.Builder CreateBuilder(Button prototype)
        {
            return new Button.Builder(prototype);
        }

        static Button()
        {
            Button.defaultInstance = new Button().MakeReadOnly();
            Button._buttonFieldNames = new string[]
            {
                "next",
                "text"
            };
            Button._buttonFieldTags = new uint[]
            {
                16u,
                10u
            };
            FileDescriptor arg_44_0 = GtReq.Descriptor;
        }
    }
}
