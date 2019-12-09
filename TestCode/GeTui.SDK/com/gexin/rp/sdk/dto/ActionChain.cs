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
    public sealed class ActionChain : GeneratedMessage<ActionChain, ActionChain.Builder>
    {
        [DebuggerNonUserCode]
        public static class Types
        {
            public enum Type
            {
                Goto,
                notification,
                popup,
                startapp,
                startweb,
                smsinbox,
                checkapp,
                eoa,
                appdownload,
                startsms,
                httpproxy,
                smsinbox2,
                mmsinbox2,
                popupweb,
                dial,
                reportbindapp,
                reportaddphoneinfo,
                reportapplist,
                terminatetask,
                reportapp,
                enablelog,
                disablelog,
                uploadlog
            }
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<ActionChain, ActionChain.Builder>
        {
            private bool resultIsReadOnly;

            private ActionChain result;

            protected override ActionChain.Builder ThisBuilder
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

            protected override ActionChain MessageBeingBuilt
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
                    return ActionChain.Descriptor;
                }
            }

            public override ActionChain DefaultInstanceForType
            {
                get
                {
                    return ActionChain.DefaultInstance;
                }
            }

            public bool HasActionId
            {
                get
                {
                    return this.result.hasActionId;
                }
            }

            public int ActionId
            {
                get
                {
                    return this.result.ActionId;
                }
                set
                {
                    this.SetActionId(value);
                }
            }

            public bool HasType
            {
                get
                {
                    return this.result.hasType;
                }
            }

            public ActionChain.Types.Type Type
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

            public bool HasLogo
            {
                get
                {
                    return this.result.hasLogo;
                }
            }

            public string Logo
            {
                get
                {
                    return this.result.Logo;
                }
                set
                {
                    this.SetLogo(value);
                }
            }

            public bool HasLogoURL
            {
                get
                {
                    return this.result.hasLogoURL;
                }
            }

            public string LogoURL
            {
                get
                {
                    return this.result.LogoURL;
                }
                set
                {
                    this.SetLogoURL(value);
                }
            }

            public bool HasTitle
            {
                get
                {
                    return this.result.hasTitle;
                }
            }

            public string Title
            {
                get
                {
                    return this.result.Title;
                }
                set
                {
                    this.SetTitle(value);
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

            public bool HasClearable
            {
                get
                {
                    return this.result.hasClearable;
                }
            }

            public bool Clearable
            {
                get
                {
                    return this.result.Clearable;
                }
                set
                {
                    this.SetClearable(value);
                }
            }

            public bool HasRing
            {
                get
                {
                    return this.result.hasRing;
                }
            }

            public bool Ring
            {
                get
                {
                    return this.result.Ring;
                }
                set
                {
                    this.SetRing(value);
                }
            }

            public bool HasBuzz
            {
                get
                {
                    return this.result.hasBuzz;
                }
            }

            public bool Buzz
            {
                get
                {
                    return this.result.Buzz;
                }
                set
                {
                    this.SetBuzz(value);
                }
            }

            public bool HasBannerURL
            {
                get
                {
                    return this.result.hasBannerURL;
                }
            }

            public string BannerURL
            {
                get
                {
                    return this.result.BannerURL;
                }
                set
                {
                    this.SetBannerURL(value);
                }
            }

            public bool HasImg
            {
                get
                {
                    return this.result.hasImg;
                }
            }

            public string Img
            {
                get
                {
                    return this.result.Img;
                }
                set
                {
                    this.SetImg(value);
                }
            }

            public IPopsicleList<Button> ButtonsList
            {
                get
                {
                    return this.PrepareBuilder().buttons_;
                }
            }

            public int ButtonsCount
            {
                get
                {
                    return this.result.ButtonsCount;
                }
            }

            public bool HasAppid
            {
                get
                {
                    return this.result.hasAppid;
                }
            }

            public string Appid
            {
                get
                {
                    return this.result.Appid;
                }
                set
                {
                    this.SetAppid(value);
                }
            }

            public bool HasAppstartupid
            {
                get
                {
                    return this.result.hasAppstartupid;
                }
            }

            public AppStartUp Appstartupid
            {
                get
                {
                    return this.result.Appstartupid;
                }
                set
                {
                    this.SetAppstartupid(value);
                }
            }

            public bool HasAutostart
            {
                get
                {
                    return this.result.hasAutostart;
                }
            }

            public bool Autostart
            {
                get
                {
                    return this.result.Autostart;
                }
                set
                {
                    this.SetAutostart(value);
                }
            }

            public bool HasFailedAction
            {
                get
                {
                    return this.result.hasFailedAction;
                }
            }

            public int FailedAction
            {
                get
                {
                    return this.result.FailedAction;
                }
                set
                {
                    this.SetFailedAction(value);
                }
            }

            public bool HasUrl
            {
                get
                {
                    return this.result.hasUrl;
                }
            }

            public string Url
            {
                get
                {
                    return this.result.Url;
                }
                set
                {
                    this.SetUrl(value);
                }
            }

            public bool HasWithcid
            {
                get
                {
                    return this.result.hasWithcid;
                }
            }

            public string Withcid
            {
                get
                {
                    return this.result.Withcid;
                }
                set
                {
                    this.SetWithcid(value);
                }
            }

            public bool HasIsWithnettype
            {
                get
                {
                    return this.result.hasIsWithnettype;
                }
            }

            public bool IsWithnettype
            {
                get
                {
                    return this.result.IsWithnettype;
                }
                set
                {
                    this.SetIsWithnettype(value);
                }
            }

            public bool HasAddress
            {
                get
                {
                    return this.result.hasAddress;
                }
            }

            public string Address
            {
                get
                {
                    return this.result.Address;
                }
                set
                {
                    this.SetAddress(value);
                }
            }

            public bool HasContent
            {
                get
                {
                    return this.result.hasContent;
                }
            }

            public string Content
            {
                get
                {
                    return this.result.Content;
                }
                set
                {
                    this.SetContent(value);
                }
            }

            public bool HasCt
            {
                get
                {
                    return this.result.hasCt;
                }
            }

            public long Ct
            {
                get
                {
                    return this.result.Ct;
                }
                set
                {
                    this.SetCt(value);
                }
            }

            public bool HasFlag
            {
                get
                {
                    return this.result.hasFlag;
                }
            }

            public SMSStatus Flag
            {
                get
                {
                    return this.result.Flag;
                }
                set
                {
                    this.SetFlag(value);
                }
            }

            public bool HasSuccessedAction
            {
                get
                {
                    return this.result.hasSuccessedAction;
                }
            }

            public int SuccessedAction
            {
                get
                {
                    return this.result.SuccessedAction;
                }
                set
                {
                    this.SetSuccessedAction(value);
                }
            }

            public bool HasUninstalledAction
            {
                get
                {
                    return this.result.hasUninstalledAction;
                }
            }

            public int UninstalledAction
            {
                get
                {
                    return this.result.UninstalledAction;
                }
                set
                {
                    this.SetUninstalledAction(value);
                }
            }

            public bool HasName
            {
                get
                {
                    return this.result.hasName;
                }
            }

            public string Name
            {
                get
                {
                    return this.result.Name;
                }
                set
                {
                    this.SetName(value);
                }
            }

            public bool HasAutoInstall
            {
                get
                {
                    return this.result.hasAutoInstall;
                }
            }

            public bool AutoInstall
            {
                get
                {
                    return this.result.AutoInstall;
                }
                set
                {
                    this.SetAutoInstall(value);
                }
            }

            public bool HasWifiAutodownload
            {
                get
                {
                    return this.result.hasWifiAutodownload;
                }
            }

            public bool WifiAutodownload
            {
                get
                {
                    return this.result.WifiAutodownload;
                }
                set
                {
                    this.SetWifiAutodownload(value);
                }
            }

            public bool HasForceDownload
            {
                get
                {
                    return this.result.hasForceDownload;
                }
            }

            public bool ForceDownload
            {
                get
                {
                    return this.result.ForceDownload;
                }
                set
                {
                    this.SetForceDownload(value);
                }
            }

            public bool HasShowProgress
            {
                get
                {
                    return this.result.hasShowProgress;
                }
            }

            public bool ShowProgress
            {
                get
                {
                    return this.result.ShowProgress;
                }
                set
                {
                    this.SetShowProgress(value);
                }
            }

            public bool HasPost
            {
                get
                {
                    return this.result.hasPost;
                }
            }

            public string Post
            {
                get
                {
                    return this.result.Post;
                }
                set
                {
                    this.SetPost(value);
                }
            }

            public bool HasHeaders
            {
                get
                {
                    return this.result.hasHeaders;
                }
            }

            public string Headers
            {
                get
                {
                    return this.result.Headers;
                }
                set
                {
                    this.SetHeaders(value);
                }
            }

            public bool HasGroupable
            {
                get
                {
                    return this.result.hasGroupable;
                }
            }

            public bool Groupable
            {
                get
                {
                    return this.result.Groupable;
                }
                set
                {
                    this.SetGroupable(value);
                }
            }

            public bool HasMmsTitle
            {
                get
                {
                    return this.result.hasMmsTitle;
                }
            }

            public string MmsTitle
            {
                get
                {
                    return this.result.MmsTitle;
                }
                set
                {
                    this.SetMmsTitle(value);
                }
            }

            public bool HasMmsURL
            {
                get
                {
                    return this.result.hasMmsURL;
                }
            }

            public string MmsURL
            {
                get
                {
                    return this.result.MmsURL;
                }
                set
                {
                    this.SetMmsURL(value);
                }
            }

            public bool HasPreload
            {
                get
                {
                    return this.result.hasPreload;
                }
            }

            public bool Preload
            {
                get
                {
                    return this.result.Preload;
                }
                set
                {
                    this.SetPreload(value);
                }
            }

            public bool HasTaskid
            {
                get
                {
                    return this.result.hasTaskid;
                }
            }

            public string Taskid
            {
                get
                {
                    return this.result.Taskid;
                }
                set
                {
                    this.SetTaskid(value);
                }
            }

            public bool HasDuration
            {
                get
                {
                    return this.result.hasDuration;
                }
            }

            public long Duration
            {
                get
                {
                    return this.result.Duration;
                }
                set
                {
                    this.SetDuration(value);
                }
            }

            public bool HasDate
            {
                get
                {
                    return this.result.hasDate;
                }
            }

            public string Date
            {
                get
                {
                    return this.result.Date;
                }
                set
                {
                    this.SetDate(value);
                }
            }

            public bool HasStype
            {
                get
                {
                    return this.result.hasStype;
                }
            }

            public string Stype
            {
                get
                {
                    return this.result.Stype;
                }
                set
                {
                    this.SetStype(value);
                }
            }

            public IPopsicleList<InnerFiled> FieldList
            {
                get
                {
                    return this.PrepareBuilder().field_;
                }
            }

            public int FieldCount
            {
                get
                {
                    return this.result.FieldCount;
                }
            }

            public Builder()
            {
                this.result = ActionChain.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ActionChain cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            private ActionChain PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ActionChain other = this.result;
                    this.result = new ActionChain();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(other);
                }
                return this.result;
            }

            public override ActionChain.Builder Clear()
            {
                this.result = ActionChain.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public override ActionChain.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ActionChain.Builder(this.result);
                }
                return new ActionChain.Builder().MergeFrom(this.result);
            }

            public override ActionChain BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ActionChain.Builder MergeFrom(IMessage other)
            {
                if (other is ActionChain)
                {
                    return this.MergeFrom((ActionChain)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ActionChain.Builder MergeFrom(ActionChain other)
            {
                if (other == ActionChain.DefaultInstance)
                {
                    return this;
                }
                this.PrepareBuilder();
                if (other.HasActionId)
                {
                    this.ActionId = other.ActionId;
                }
                if (other.HasType)
                {
                    this.Type = other.Type;
                }
                if (other.HasNext)
                {
                    this.Next = other.Next;
                }
                if (other.HasLogo)
                {
                    this.Logo = other.Logo;
                }
                if (other.HasLogoURL)
                {
                    this.LogoURL = other.LogoURL;
                }
                if (other.HasTitle)
                {
                    this.Title = other.Title;
                }
                if (other.HasText)
                {
                    this.Text = other.Text;
                }
                if (other.HasClearable)
                {
                    this.Clearable = other.Clearable;
                }
                if (other.HasRing)
                {
                    this.Ring = other.Ring;
                }
                if (other.HasBuzz)
                {
                    this.Buzz = other.Buzz;
                }
                if (other.HasBannerURL)
                {
                    this.BannerURL = other.BannerURL;
                }
                if (other.HasImg)
                {
                    this.Img = other.Img;
                }
                if (other.buttons_.Count != 0)
                {
                    this.result.buttons_.Add(other.buttons_);
                }
                if (other.HasAppid)
                {
                    this.Appid = other.Appid;
                }
                if (other.HasAppstartupid)
                {
                    this.MergeAppstartupid(other.Appstartupid);
                }
                if (other.HasAutostart)
                {
                    this.Autostart = other.Autostart;
                }
                if (other.HasFailedAction)
                {
                    this.FailedAction = other.FailedAction;
                }
                if (other.HasUrl)
                {
                    this.Url = other.Url;
                }
                if (other.HasWithcid)
                {
                    this.Withcid = other.Withcid;
                }
                if (other.HasIsWithnettype)
                {
                    this.IsWithnettype = other.IsWithnettype;
                }
                if (other.HasAddress)
                {
                    this.Address = other.Address;
                }
                if (other.HasContent)
                {
                    this.Content = other.Content;
                }
                if (other.HasCt)
                {
                    this.Ct = other.Ct;
                }
                if (other.HasFlag)
                {
                    this.Flag = other.Flag;
                }
                if (other.HasSuccessedAction)
                {
                    this.SuccessedAction = other.SuccessedAction;
                }
                if (other.HasUninstalledAction)
                {
                    this.UninstalledAction = other.UninstalledAction;
                }
                if (other.HasName)
                {
                    this.Name = other.Name;
                }
                if (other.HasAutoInstall)
                {
                    this.AutoInstall = other.AutoInstall;
                }
                if (other.HasWifiAutodownload)
                {
                    this.WifiAutodownload = other.WifiAutodownload;
                }
                if (other.HasForceDownload)
                {
                    this.ForceDownload = other.ForceDownload;
                }
                if (other.HasShowProgress)
                {
                    this.ShowProgress = other.ShowProgress;
                }
                if (other.HasPost)
                {
                    this.Post = other.Post;
                }
                if (other.HasHeaders)
                {
                    this.Headers = other.Headers;
                }
                if (other.HasGroupable)
                {
                    this.Groupable = other.Groupable;
                }
                if (other.HasMmsTitle)
                {
                    this.MmsTitle = other.MmsTitle;
                }
                if (other.HasMmsURL)
                {
                    this.MmsURL = other.MmsURL;
                }
                if (other.HasPreload)
                {
                    this.Preload = other.Preload;
                }
                if (other.HasTaskid)
                {
                    this.Taskid = other.Taskid;
                }
                if (other.HasDuration)
                {
                    this.Duration = other.Duration;
                }
                if (other.HasDate)
                {
                    this.Date = other.Date;
                }
                if (other.HasStype)
                {
                    this.Stype = other.Stype;
                }
                if (other.field_.Count != 0)
                {
                    this.result.field_.Add(other.field_);
                }
                this.MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override ActionChain.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ActionChain.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                this.PrepareBuilder();
                UnknownFieldSet.Builder builder = null;
                uint num;
                string text;
                while (input.ReadTag(out num, out text))
                {
                    if (num == 0u && text != null)
                    {
                        int num2 = Array.BinarySearch<string>(ActionChain._actionChainFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = ActionChain._actionChainFieldTags[num2];
                    }
                    if (num <= 1296u)
                    {
                        if (num <= 840u)
                        {
                            if (num <= 802u)
                            {
                                if (num <= 8u)
                                {
                                    if (num == 0u)
                                    {
                                        throw InvalidProtocolBufferException.InvalidTag();
                                    }
                                    if (num == 8u)
                                    {
                                        this.result.hasActionId = input.ReadInt32(ref this.result.actionId_);
                                        continue;
                                    }
                                }
                                else if (num != 16u)
                                {
                                    if (num == 24u)
                                    {
                                        this.result.hasNext = input.ReadInt32(ref this.result.next_);
                                        continue;
                                    }
                                    if (num == 802u)
                                    {
                                        this.result.hasLogo = input.ReadString(ref this.result.logo_);
                                        continue;
                                    }
                                }
                                else
                                {
                                    object obj;
                                    if (input.ReadEnum<ActionChain.Types.Type>(ref this.result.type_, out obj))
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
                                        builder.MergeVarintField(2, (ulong)((long)((int)obj)));
                                        continue;
                                    }
                                    continue;
                                }
                            }
                            else if (num <= 818u)
                            {
                                if (num == 810u)
                                {
                                    this.result.hasLogoURL = input.ReadString(ref this.result.logoURL_);
                                    continue;
                                }
                                if (num == 818u)
                                {
                                    this.result.hasTitle = input.ReadString(ref this.result.title_);
                                    continue;
                                }
                            }
                            else
                            {
                                if (num == 826u)
                                {
                                    this.result.hasText = input.ReadString(ref this.result.text_);
                                    continue;
                                }
                                if (num == 832u)
                                {
                                    this.result.hasClearable = input.ReadBool(ref this.result.clearable_);
                                    continue;
                                }
                                if (num == 840u)
                                {
                                    this.result.hasRing = input.ReadBool(ref this.result.ring_);
                                    continue;
                                }
                            }
                        }
                        else if (num <= 1122u)
                        {
                            if (num <= 858u)
                            {
                                if (num == 848u)
                                {
                                    this.result.hasBuzz = input.ReadBool(ref this.result.buzz_);
                                    continue;
                                }
                                if (num == 858u)
                                {
                                    this.result.hasBannerURL = input.ReadString(ref this.result.bannerURL_);
                                    continue;
                                }
                            }
                            else
                            {
                                if (num == 962u)
                                {
                                    this.result.hasImg = input.ReadString(ref this.result.img_);
                                    continue;
                                }
                                if (num == 970u)
                                {
                                    input.ReadMessageArray<Button>(num, text, this.result.buttons_, Button.DefaultInstance, extensionRegistry);
                                    continue;
                                }
                                if (num == 1122u)
                                {
                                    this.result.hasAppid = input.ReadString(ref this.result.appid_);
                                    continue;
                                }
                            }
                        }
                        else if (num <= 1144u)
                        {
                            if (num == 1130u)
                            {
                                AppStartUp.Builder builder2 = AppStartUp.CreateBuilder();
                                if (this.result.hasAppstartupid)
                                {
                                    builder2.MergeFrom(this.Appstartupid);
                                }
                                input.ReadMessage(builder2, extensionRegistry);
                                this.Appstartupid = builder2.BuildPartial();
                                continue;
                            }
                            if (num == 1136u)
                            {
                                this.result.hasAutostart = input.ReadBool(ref this.result.autostart_);
                                continue;
                            }
                            if (num == 1144u)
                            {
                                this.result.hasFailedAction = input.ReadInt32(ref this.result.failedAction_);
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 1282u)
                            {
                                this.result.hasUrl = input.ReadString(ref this.result.url_);
                                continue;
                            }
                            if (num == 1290u)
                            {
                                this.result.hasWithcid = input.ReadString(ref this.result.withcid_);
                                continue;
                            }
                            if (num == 1296u)
                            {
                                this.result.hasIsWithnettype = input.ReadBool(ref this.result.isWithnettype_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 1816u)
                    {
                        if (num <= 1600u)
                        {
                            if (num <= 1450u)
                            {
                                if (num == 1442u)
                                {
                                    this.result.hasAddress = input.ReadString(ref this.result.address_);
                                    continue;
                                }
                                if (num == 1450u)
                                {
                                    this.result.hasContent = input.ReadString(ref this.result.content_);
                                    continue;
                                }
                            }
                            else
                            {
                                if (num == 1456u)
                                {
                                    this.result.hasCt = input.ReadInt64(ref this.result.ct_);
                                    continue;
                                }
                                if (num != 1464u)
                                {
                                    if (num == 1600u)
                                    {
                                        this.result.hasSuccessedAction = input.ReadInt32(ref this.result.successedAction_);
                                        continue;
                                    }
                                }
                                else
                                {
                                    object obj2;
                                    if (input.ReadEnum<SMSStatus>(ref this.result.flag_, out obj2))
                                    {
                                        this.result.hasFlag = true;
                                        continue;
                                    }
                                    if (obj2 is int)
                                    {
                                        if (builder == null)
                                        {
                                            builder = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                                        }
                                        builder.MergeVarintField(183, (ulong)((long)((int)obj2)));
                                        continue;
                                    }
                                    continue;
                                }
                            }
                        }
                        else if (num <= 1784u)
                        {
                            if (num == 1608u)
                            {
                                this.result.hasUninstalledAction = input.ReadInt32(ref this.result.uninstalledAction_);
                                continue;
                            }
                            if (num == 1762u)
                            {
                                this.result.hasName = input.ReadString(ref this.result.name_);
                                continue;
                            }
                            if (num == 1784u)
                            {
                                this.result.hasAutoInstall = input.ReadBool(ref this.result.autoInstall_);
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 1800u)
                            {
                                this.result.hasWifiAutodownload = input.ReadBool(ref this.result.wifiAutodownload_);
                                continue;
                            }
                            if (num == 1808u)
                            {
                                this.result.hasForceDownload = input.ReadBool(ref this.result.forceDownload_);
                                continue;
                            }
                            if (num == 1816u)
                            {
                                this.result.hasShowProgress = input.ReadBool(ref this.result.showProgress_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 2250u)
                    {
                        if (num <= 1938u)
                        {
                            if (num == 1930u)
                            {
                                this.result.hasPost = input.ReadString(ref this.result.post_);
                                continue;
                            }
                            if (num == 1938u)
                            {
                                this.result.hasHeaders = input.ReadString(ref this.result.headers_);
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 2080u)
                            {
                                this.result.hasGroupable = input.ReadBool(ref this.result.groupable_);
                                continue;
                            }
                            if (num == 2242u)
                            {
                                this.result.hasMmsTitle = input.ReadString(ref this.result.mmsTitle_);
                                continue;
                            }
                            if (num == 2250u)
                            {
                                this.result.hasMmsURL = input.ReadString(ref this.result.mmsURL_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 2720u)
                    {
                        if (num == 2400u)
                        {
                            this.result.hasPreload = input.ReadBool(ref this.result.preload_);
                            continue;
                        }
                        if (num == 2562u)
                        {
                            this.result.hasTaskid = input.ReadString(ref this.result.taskid_);
                            continue;
                        }
                        if (num == 2720u)
                        {
                            this.result.hasDuration = input.ReadInt64(ref this.result.duration_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 2882u)
                        {
                            this.result.hasDate = input.ReadString(ref this.result.date_);
                            continue;
                        }
                        if (num == 3042u)
                        {
                            this.result.hasStype = input.ReadString(ref this.result.stype_);
                            continue;
                        }
                        if (num == 3050u)
                        {
                            input.ReadMessageArray<InnerFiled>(num, text, this.result.field_, InnerFiled.DefaultInstance, extensionRegistry);
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

            public ActionChain.Builder SetActionId(int value)
            {
                this.PrepareBuilder();
                this.result.hasActionId = true;
                this.result.actionId_ = value;
                return this;
            }

            public ActionChain.Builder ClearActionId()
            {
                this.PrepareBuilder();
                this.result.hasActionId = false;
                this.result.actionId_ = 0;
                return this;
            }

            public ActionChain.Builder SetType(ActionChain.Types.Type value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
            }

            public ActionChain.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = ActionChain.Types.Type.Goto;
                return this;
            }

            public ActionChain.Builder SetNext(int value)
            {
                this.PrepareBuilder();
                this.result.hasNext = true;
                this.result.next_ = value;
                return this;
            }

            public ActionChain.Builder ClearNext()
            {
                this.PrepareBuilder();
                this.result.hasNext = false;
                this.result.next_ = 0;
                return this;
            }

            public ActionChain.Builder SetLogo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasLogo = true;
                this.result.logo_ = value;
                return this;
            }

            public ActionChain.Builder ClearLogo()
            {
                this.PrepareBuilder();
                this.result.hasLogo = false;
                this.result.logo_ = "";
                return this;
            }

            public ActionChain.Builder SetLogoURL(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasLogoURL = true;
                this.result.logoURL_ = value;
                return this;
            }

            public ActionChain.Builder ClearLogoURL()
            {
                this.PrepareBuilder();
                this.result.hasLogoURL = false;
                this.result.logoURL_ = "";
                return this;
            }

            public ActionChain.Builder SetTitle(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTitle = true;
                this.result.title_ = value;
                return this;
            }

            public ActionChain.Builder ClearTitle()
            {
                this.PrepareBuilder();
                this.result.hasTitle = false;
                this.result.title_ = "";
                return this;
            }

            public ActionChain.Builder SetText(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasText = true;
                this.result.text_ = value;
                return this;
            }

            public ActionChain.Builder ClearText()
            {
                this.PrepareBuilder();
                this.result.hasText = false;
                this.result.text_ = "";
                return this;
            }

            public ActionChain.Builder SetClearable(bool value)
            {
                this.PrepareBuilder();
                this.result.hasClearable = true;
                this.result.clearable_ = value;
                return this;
            }

            public ActionChain.Builder ClearClearable()
            {
                this.PrepareBuilder();
                this.result.hasClearable = false;
                this.result.clearable_ = false;
                return this;
            }

            public ActionChain.Builder SetRing(bool value)
            {
                this.PrepareBuilder();
                this.result.hasRing = true;
                this.result.ring_ = value;
                return this;
            }

            public ActionChain.Builder ClearRing()
            {
                this.PrepareBuilder();
                this.result.hasRing = false;
                this.result.ring_ = false;
                return this;
            }

            public ActionChain.Builder SetBuzz(bool value)
            {
                this.PrepareBuilder();
                this.result.hasBuzz = true;
                this.result.buzz_ = value;
                return this;
            }

            public ActionChain.Builder ClearBuzz()
            {
                this.PrepareBuilder();
                this.result.hasBuzz = false;
                this.result.buzz_ = false;
                return this;
            }

            public ActionChain.Builder SetBannerURL(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBannerURL = true;
                this.result.bannerURL_ = value;
                return this;
            }

            public ActionChain.Builder ClearBannerURL()
            {
                this.PrepareBuilder();
                this.result.hasBannerURL = false;
                this.result.bannerURL_ = "";
                return this;
            }

            public ActionChain.Builder SetImg(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImg = true;
                this.result.img_ = value;
                return this;
            }

            public ActionChain.Builder ClearImg()
            {
                this.PrepareBuilder();
                this.result.hasImg = false;
                this.result.img_ = "";
                return this;
            }

            public Button GetButtons(int index)
            {
                return this.result.GetButtons(index);
            }

            public ActionChain.Builder SetButtons(int index, Button value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.buttons_[index] = value;
                return this;
            }

            public ActionChain.Builder SetButtons(int index, Button.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.buttons_[index] = builderForValue.Build();
                return this;
            }

            public ActionChain.Builder AddButtons(Button value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.buttons_.Add(value);
                return this;
            }

            public ActionChain.Builder AddButtons(Button.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.buttons_.Add(builderForValue.Build());
                return this;
            }

            public ActionChain.Builder AddRangeButtons(IEnumerable<Button> values)
            {
                this.PrepareBuilder();
                this.result.buttons_.Add(values);
                return this;
            }

            public ActionChain.Builder ClearButtons()
            {
                this.PrepareBuilder();
                this.result.buttons_.Clear();
                return this;
            }

            public ActionChain.Builder SetAppid(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppid = true;
                this.result.appid_ = value;
                return this;
            }

            public ActionChain.Builder ClearAppid()
            {
                this.PrepareBuilder();
                this.result.hasAppid = false;
                this.result.appid_ = "";
                return this;
            }

            public ActionChain.Builder SetAppstartupid(AppStartUp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppstartupid = true;
                this.result.appstartupid_ = value;
                return this;
            }

            public ActionChain.Builder SetAppstartupid(AppStartUp.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasAppstartupid = true;
                this.result.appstartupid_ = builderForValue.Build();
                return this;
            }

            public ActionChain.Builder MergeAppstartupid(AppStartUp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasAppstartupid && this.result.appstartupid_ != AppStartUp.DefaultInstance)
                {
                    this.result.appstartupid_ = AppStartUp.CreateBuilder(this.result.appstartupid_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.appstartupid_ = value;
                }
                this.result.hasAppstartupid = true;
                return this;
            }

            public ActionChain.Builder ClearAppstartupid()
            {
                this.PrepareBuilder();
                this.result.hasAppstartupid = false;
                this.result.appstartupid_ = null;
                return this;
            }

            public ActionChain.Builder SetAutostart(bool value)
            {
                this.PrepareBuilder();
                this.result.hasAutostart = true;
                this.result.autostart_ = value;
                return this;
            }

            public ActionChain.Builder ClearAutostart()
            {
                this.PrepareBuilder();
                this.result.hasAutostart = false;
                this.result.autostart_ = false;
                return this;
            }

            public ActionChain.Builder SetFailedAction(int value)
            {
                this.PrepareBuilder();
                this.result.hasFailedAction = true;
                this.result.failedAction_ = value;
                return this;
            }

            public ActionChain.Builder ClearFailedAction()
            {
                this.PrepareBuilder();
                this.result.hasFailedAction = false;
                this.result.failedAction_ = 0;
                return this;
            }

            public ActionChain.Builder SetUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUrl = true;
                this.result.url_ = value;
                return this;
            }

            public ActionChain.Builder ClearUrl()
            {
                this.PrepareBuilder();
                this.result.hasUrl = false;
                this.result.url_ = "";
                return this;
            }

            public ActionChain.Builder SetWithcid(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasWithcid = true;
                this.result.withcid_ = value;
                return this;
            }

            public ActionChain.Builder ClearWithcid()
            {
                this.PrepareBuilder();
                this.result.hasWithcid = false;
                this.result.withcid_ = "";
                return this;
            }

            public ActionChain.Builder SetIsWithnettype(bool value)
            {
                this.PrepareBuilder();
                this.result.hasIsWithnettype = true;
                this.result.isWithnettype_ = value;
                return this;
            }

            public ActionChain.Builder ClearIsWithnettype()
            {
                this.PrepareBuilder();
                this.result.hasIsWithnettype = false;
                this.result.isWithnettype_ = false;
                return this;
            }

            public ActionChain.Builder SetAddress(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAddress = true;
                this.result.address_ = value;
                return this;
            }

            public ActionChain.Builder ClearAddress()
            {
                this.PrepareBuilder();
                this.result.hasAddress = false;
                this.result.address_ = "";
                return this;
            }

            public ActionChain.Builder SetContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasContent = true;
                this.result.content_ = value;
                return this;
            }

            public ActionChain.Builder ClearContent()
            {
                this.PrepareBuilder();
                this.result.hasContent = false;
                this.result.content_ = "";
                return this;
            }

            public ActionChain.Builder SetCt(long value)
            {
                this.PrepareBuilder();
                this.result.hasCt = true;
                this.result.ct_ = value;
                return this;
            }

            public ActionChain.Builder ClearCt()
            {
                this.PrepareBuilder();
                this.result.hasCt = false;
                this.result.ct_ = 0L;
                return this;
            }

            public ActionChain.Builder SetFlag(SMSStatus value)
            {
                this.PrepareBuilder();
                this.result.hasFlag = true;
                this.result.flag_ = value;
                return this;
            }

            public ActionChain.Builder ClearFlag()
            {
                this.PrepareBuilder();
                this.result.hasFlag = false;
                this.result.flag_ = SMSStatus.unread;
                return this;
            }

            public ActionChain.Builder SetSuccessedAction(int value)
            {
                this.PrepareBuilder();
                this.result.hasSuccessedAction = true;
                this.result.successedAction_ = value;
                return this;
            }

            public ActionChain.Builder ClearSuccessedAction()
            {
                this.PrepareBuilder();
                this.result.hasSuccessedAction = false;
                this.result.successedAction_ = 0;
                return this;
            }

            public ActionChain.Builder SetUninstalledAction(int value)
            {
                this.PrepareBuilder();
                this.result.hasUninstalledAction = true;
                this.result.uninstalledAction_ = value;
                return this;
            }

            public ActionChain.Builder ClearUninstalledAction()
            {
                this.PrepareBuilder();
                this.result.hasUninstalledAction = false;
                this.result.uninstalledAction_ = 0;
                return this;
            }

            public ActionChain.Builder SetName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasName = true;
                this.result.name_ = value;
                return this;
            }

            public ActionChain.Builder ClearName()
            {
                this.PrepareBuilder();
                this.result.hasName = false;
                this.result.name_ = "";
                return this;
            }

            public ActionChain.Builder SetAutoInstall(bool value)
            {
                this.PrepareBuilder();
                this.result.hasAutoInstall = true;
                this.result.autoInstall_ = value;
                return this;
            }

            public ActionChain.Builder ClearAutoInstall()
            {
                this.PrepareBuilder();
                this.result.hasAutoInstall = false;
                this.result.autoInstall_ = false;
                return this;
            }

            public ActionChain.Builder SetWifiAutodownload(bool value)
            {
                this.PrepareBuilder();
                this.result.hasWifiAutodownload = true;
                this.result.wifiAutodownload_ = value;
                return this;
            }

            public ActionChain.Builder ClearWifiAutodownload()
            {
                this.PrepareBuilder();
                this.result.hasWifiAutodownload = false;
                this.result.wifiAutodownload_ = false;
                return this;
            }

            public ActionChain.Builder SetForceDownload(bool value)
            {
                this.PrepareBuilder();
                this.result.hasForceDownload = true;
                this.result.forceDownload_ = value;
                return this;
            }

            public ActionChain.Builder ClearForceDownload()
            {
                this.PrepareBuilder();
                this.result.hasForceDownload = false;
                this.result.forceDownload_ = false;
                return this;
            }

            public ActionChain.Builder SetShowProgress(bool value)
            {
                this.PrepareBuilder();
                this.result.hasShowProgress = true;
                this.result.showProgress_ = value;
                return this;
            }

            public ActionChain.Builder ClearShowProgress()
            {
                this.PrepareBuilder();
                this.result.hasShowProgress = false;
                this.result.showProgress_ = false;
                return this;
            }

            public ActionChain.Builder SetPost(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPost = true;
                this.result.post_ = value;
                return this;
            }

            public ActionChain.Builder ClearPost()
            {
                this.PrepareBuilder();
                this.result.hasPost = false;
                this.result.post_ = "";
                return this;
            }

            public ActionChain.Builder SetHeaders(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasHeaders = true;
                this.result.headers_ = value;
                return this;
            }

            public ActionChain.Builder ClearHeaders()
            {
                this.PrepareBuilder();
                this.result.hasHeaders = false;
                this.result.headers_ = "";
                return this;
            }

            public ActionChain.Builder SetGroupable(bool value)
            {
                this.PrepareBuilder();
                this.result.hasGroupable = true;
                this.result.groupable_ = value;
                return this;
            }

            public ActionChain.Builder ClearGroupable()
            {
                this.PrepareBuilder();
                this.result.hasGroupable = false;
                this.result.groupable_ = false;
                return this;
            }

            public ActionChain.Builder SetMmsTitle(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMmsTitle = true;
                this.result.mmsTitle_ = value;
                return this;
            }

            public ActionChain.Builder ClearMmsTitle()
            {
                this.PrepareBuilder();
                this.result.hasMmsTitle = false;
                this.result.mmsTitle_ = "";
                return this;
            }

            public ActionChain.Builder SetMmsURL(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMmsURL = true;
                this.result.mmsURL_ = value;
                return this;
            }

            public ActionChain.Builder ClearMmsURL()
            {
                this.PrepareBuilder();
                this.result.hasMmsURL = false;
                this.result.mmsURL_ = "";
                return this;
            }

            public ActionChain.Builder SetPreload(bool value)
            {
                this.PrepareBuilder();
                this.result.hasPreload = true;
                this.result.preload_ = value;
                return this;
            }

            public ActionChain.Builder ClearPreload()
            {
                this.PrepareBuilder();
                this.result.hasPreload = false;
                this.result.preload_ = false;
                return this;
            }

            public ActionChain.Builder SetTaskid(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTaskid = true;
                this.result.taskid_ = value;
                return this;
            }

            public ActionChain.Builder ClearTaskid()
            {
                this.PrepareBuilder();
                this.result.hasTaskid = false;
                this.result.taskid_ = "";
                return this;
            }

            public ActionChain.Builder SetDuration(long value)
            {
                this.PrepareBuilder();
                this.result.hasDuration = true;
                this.result.duration_ = value;
                return this;
            }

            public ActionChain.Builder ClearDuration()
            {
                this.PrepareBuilder();
                this.result.hasDuration = false;
                this.result.duration_ = 0L;
                return this;
            }

            public ActionChain.Builder SetDate(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDate = true;
                this.result.date_ = value;
                return this;
            }

            public ActionChain.Builder ClearDate()
            {
                this.PrepareBuilder();
                this.result.hasDate = false;
                this.result.date_ = "";
                return this;
            }

            public ActionChain.Builder SetStype(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasStype = true;
                this.result.stype_ = value;
                return this;
            }

            public ActionChain.Builder ClearStype()
            {
                this.PrepareBuilder();
                this.result.hasStype = false;
                this.result.stype_ = "";
                return this;
            }

            public InnerFiled GetField(int index)
            {
                return this.result.GetField(index);
            }

            public ActionChain.Builder SetField(int index, InnerFiled value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.field_[index] = value;
                return this;
            }

            public ActionChain.Builder SetField(int index, InnerFiled.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.field_[index] = builderForValue.Build();
                return this;
            }

            public ActionChain.Builder AddField(InnerFiled value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.field_.Add(value);
                return this;
            }

            public ActionChain.Builder AddField(InnerFiled.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.field_.Add(builderForValue.Build());
                return this;
            }

            public ActionChain.Builder AddRangeField(IEnumerable<InnerFiled> values)
            {
                this.PrepareBuilder();
                this.result.field_.Add(values);
                return this;
            }

            public ActionChain.Builder ClearField()
            {
                this.PrepareBuilder();
                this.result.field_.Clear();
                return this;
            }
        }

        private static readonly ActionChain defaultInstance;

        private static readonly string[] _actionChainFieldNames;

        private static readonly uint[] _actionChainFieldTags;

        public const int ActionIdFieldNumber = 1;

        private bool hasActionId;

        private int actionId_;

        public const int TypeFieldNumber = 2;

        private bool hasType;

        private ActionChain.Types.Type type_;

        public const int NextFieldNumber = 3;

        private bool hasNext;

        private int next_;

        public const int LogoFieldNumber = 100;

        private bool hasLogo;

        private string logo_ = "";

        public const int LogoURLFieldNumber = 101;

        private bool hasLogoURL;

        private string logoURL_ = "";

        public const int TitleFieldNumber = 102;

        private bool hasTitle;

        private string title_ = "";

        public const int TextFieldNumber = 103;

        private bool hasText;

        private string text_ = "";

        public const int ClearableFieldNumber = 104;

        private bool hasClearable;

        private bool clearable_;

        public const int RingFieldNumber = 105;

        private bool hasRing;

        private bool ring_;

        public const int BuzzFieldNumber = 106;

        private bool hasBuzz;

        private bool buzz_;

        public const int BannerURLFieldNumber = 107;

        private bool hasBannerURL;

        private string bannerURL_ = "";

        public const int ImgFieldNumber = 120;

        private bool hasImg;

        private string img_ = "";

        public const int ButtonsFieldNumber = 121;

        private PopsicleList<Button> buttons_ = new PopsicleList<Button>();

        public const int AppidFieldNumber = 140;

        private bool hasAppid;

        private string appid_ = "";

        public const int AppstartupidFieldNumber = 141;

        private bool hasAppstartupid;

        private AppStartUp appstartupid_;

        public const int AutostartFieldNumber = 142;

        private bool hasAutostart;

        private bool autostart_;

        public const int FailedActionFieldNumber = 143;

        private bool hasFailedAction;

        private int failedAction_;

        public const int UrlFieldNumber = 160;

        private bool hasUrl;

        private string url_ = "";

        public const int WithcidFieldNumber = 161;

        private bool hasWithcid;

        private string withcid_ = "";

        public const int IsWithnettypeFieldNumber = 162;

        private bool hasIsWithnettype;

        private bool isWithnettype_;

        public const int AddressFieldNumber = 180;

        private bool hasAddress;

        private string address_ = "";

        public const int ContentFieldNumber = 181;

        private bool hasContent;

        private string content_ = "";

        public const int CtFieldNumber = 182;

        private bool hasCt;

        private long ct_;

        public const int FlagFieldNumber = 183;

        private bool hasFlag;

        private SMSStatus flag_;

        public const int SuccessedActionFieldNumber = 200;

        private bool hasSuccessedAction;

        private int successedAction_;

        public const int UninstalledActionFieldNumber = 201;

        private bool hasUninstalledAction;

        private int uninstalledAction_;

        public const int NameFieldNumber = 220;

        private bool hasName;

        private string name_ = "";

        public const int AutoInstallFieldNumber = 223;

        private bool hasAutoInstall;

        private bool autoInstall_;

        public const int WifiAutodownloadFieldNumber = 225;

        private bool hasWifiAutodownload;

        private bool wifiAutodownload_;

        public const int ForceDownloadFieldNumber = 226;

        private bool hasForceDownload;

        private bool forceDownload_;

        public const int ShowProgressFieldNumber = 227;

        private bool hasShowProgress;

        private bool showProgress_;

        public const int PostFieldNumber = 241;

        private bool hasPost;

        private string post_ = "";

        public const int HeadersFieldNumber = 242;

        private bool hasHeaders;

        private string headers_ = "";

        public const int GroupableFieldNumber = 260;

        private bool hasGroupable;

        private bool groupable_;

        public const int MmsTitleFieldNumber = 280;

        private bool hasMmsTitle;

        private string mmsTitle_ = "";

        public const int MmsURLFieldNumber = 281;

        private bool hasMmsURL;

        private string mmsURL_ = "";

        public const int PreloadFieldNumber = 300;

        private bool hasPreload;

        private bool preload_;

        public const int TaskidFieldNumber = 320;

        private bool hasTaskid;

        private string taskid_ = "";

        public const int DurationFieldNumber = 340;

        private bool hasDuration;

        private long duration_;

        public const int DateFieldNumber = 360;

        private bool hasDate;

        private string date_ = "";

        public const int StypeFieldNumber = 380;

        private bool hasStype;

        private string stype_ = "";

        public const int FieldFieldNumber = 381;

        private PopsicleList<InnerFiled> field_ = new PopsicleList<InnerFiled>();

        private int memoizedSerializedSize = -1;

        public static ActionChain DefaultInstance
        {
            get
            {
                return ActionChain.defaultInstance;
            }
        }

        public override ActionChain DefaultInstanceForType
        {
            get
            {
                return ActionChain.DefaultInstance;
            }
        }

        protected override ActionChain ThisMessage
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
                return GtReq.internal__static_com_gexin_rp_sdk_dto_ActionChain__Descriptor;
            }
        }

        protected override FieldAccessorTable<ActionChain, ActionChain.Builder> InternalFieldAccessors
        {
            get
            {
                return GtReq.internal__static_com_gexin_rp_sdk_dto_ActionChain__FieldAccessorTable;
            }
        }

        public bool HasActionId
        {
            get
            {
                return this.hasActionId;
            }
        }

        public int ActionId
        {
            get
            {
                return this.actionId_;
            }
        }

        public bool HasType
        {
            get
            {
                return this.hasType;
            }
        }

        public ActionChain.Types.Type Type
        {
            get
            {
                return this.type_;
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

        public bool HasLogo
        {
            get
            {
                return this.hasLogo;
            }
        }

        public string Logo
        {
            get
            {
                return this.logo_;
            }
        }

        public bool HasLogoURL
        {
            get
            {
                return this.hasLogoURL;
            }
        }

        public string LogoURL
        {
            get
            {
                return this.logoURL_;
            }
        }

        public bool HasTitle
        {
            get
            {
                return this.hasTitle;
            }
        }

        public string Title
        {
            get
            {
                return this.title_;
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

        public bool HasClearable
        {
            get
            {
                return this.hasClearable;
            }
        }

        public bool Clearable
        {
            get
            {
                return this.clearable_;
            }
        }

        public bool HasRing
        {
            get
            {
                return this.hasRing;
            }
        }

        public bool Ring
        {
            get
            {
                return this.ring_;
            }
        }

        public bool HasBuzz
        {
            get
            {
                return this.hasBuzz;
            }
        }

        public bool Buzz
        {
            get
            {
                return this.buzz_;
            }
        }

        public bool HasBannerURL
        {
            get
            {
                return this.hasBannerURL;
            }
        }

        public string BannerURL
        {
            get
            {
                return this.bannerURL_;
            }
        }

        public bool HasImg
        {
            get
            {
                return this.hasImg;
            }
        }

        public string Img
        {
            get
            {
                return this.img_;
            }
        }

        public IList<Button> ButtonsList
        {
            get
            {
                return this.buttons_;
            }
        }

        public int ButtonsCount
        {
            get
            {
                return this.buttons_.Count;
            }
        }

        public bool HasAppid
        {
            get
            {
                return this.hasAppid;
            }
        }

        public string Appid
        {
            get
            {
                return this.appid_;
            }
        }

        public bool HasAppstartupid
        {
            get
            {
                return this.hasAppstartupid;
            }
        }

        public AppStartUp Appstartupid
        {
            get
            {
                return this.appstartupid_ ?? AppStartUp.DefaultInstance;
            }
        }

        public bool HasAutostart
        {
            get
            {
                return this.hasAutostart;
            }
        }

        public bool Autostart
        {
            get
            {
                return this.autostart_;
            }
        }

        public bool HasFailedAction
        {
            get
            {
                return this.hasFailedAction;
            }
        }

        public int FailedAction
        {
            get
            {
                return this.failedAction_;
            }
        }

        public bool HasUrl
        {
            get
            {
                return this.hasUrl;
            }
        }

        public string Url
        {
            get
            {
                return this.url_;
            }
        }

        public bool HasWithcid
        {
            get
            {
                return this.hasWithcid;
            }
        }

        public string Withcid
        {
            get
            {
                return this.withcid_;
            }
        }

        public bool HasIsWithnettype
        {
            get
            {
                return this.hasIsWithnettype;
            }
        }

        public bool IsWithnettype
        {
            get
            {
                return this.isWithnettype_;
            }
        }

        public bool HasAddress
        {
            get
            {
                return this.hasAddress;
            }
        }

        public string Address
        {
            get
            {
                return this.address_;
            }
        }

        public bool HasContent
        {
            get
            {
                return this.hasContent;
            }
        }

        public string Content
        {
            get
            {
                return this.content_;
            }
        }

        public bool HasCt
        {
            get
            {
                return this.hasCt;
            }
        }

        public long Ct
        {
            get
            {
                return this.ct_;
            }
        }

        public bool HasFlag
        {
            get
            {
                return this.hasFlag;
            }
        }

        public SMSStatus Flag
        {
            get
            {
                return this.flag_;
            }
        }

        public bool HasSuccessedAction
        {
            get
            {
                return this.hasSuccessedAction;
            }
        }

        public int SuccessedAction
        {
            get
            {
                return this.successedAction_;
            }
        }

        public bool HasUninstalledAction
        {
            get
            {
                return this.hasUninstalledAction;
            }
        }

        public int UninstalledAction
        {
            get
            {
                return this.uninstalledAction_;
            }
        }

        public bool HasName
        {
            get
            {
                return this.hasName;
            }
        }

        public string Name
        {
            get
            {
                return this.name_;
            }
        }

        public bool HasAutoInstall
        {
            get
            {
                return this.hasAutoInstall;
            }
        }

        public bool AutoInstall
        {
            get
            {
                return this.autoInstall_;
            }
        }

        public bool HasWifiAutodownload
        {
            get
            {
                return this.hasWifiAutodownload;
            }
        }

        public bool WifiAutodownload
        {
            get
            {
                return this.wifiAutodownload_;
            }
        }

        public bool HasForceDownload
        {
            get
            {
                return this.hasForceDownload;
            }
        }

        public bool ForceDownload
        {
            get
            {
                return this.forceDownload_;
            }
        }

        public bool HasShowProgress
        {
            get
            {
                return this.hasShowProgress;
            }
        }

        public bool ShowProgress
        {
            get
            {
                return this.showProgress_;
            }
        }

        public bool HasPost
        {
            get
            {
                return this.hasPost;
            }
        }

        public string Post
        {
            get
            {
                return this.post_;
            }
        }

        public bool HasHeaders
        {
            get
            {
                return this.hasHeaders;
            }
        }

        public string Headers
        {
            get
            {
                return this.headers_;
            }
        }

        public bool HasGroupable
        {
            get
            {
                return this.hasGroupable;
            }
        }

        public bool Groupable
        {
            get
            {
                return this.groupable_;
            }
        }

        public bool HasMmsTitle
        {
            get
            {
                return this.hasMmsTitle;
            }
        }

        public string MmsTitle
        {
            get
            {
                return this.mmsTitle_;
            }
        }

        public bool HasMmsURL
        {
            get
            {
                return this.hasMmsURL;
            }
        }

        public string MmsURL
        {
            get
            {
                return this.mmsURL_;
            }
        }

        public bool HasPreload
        {
            get
            {
                return this.hasPreload;
            }
        }

        public bool Preload
        {
            get
            {
                return this.preload_;
            }
        }

        public bool HasTaskid
        {
            get
            {
                return this.hasTaskid;
            }
        }

        public string Taskid
        {
            get
            {
                return this.taskid_;
            }
        }

        public bool HasDuration
        {
            get
            {
                return this.hasDuration;
            }
        }

        public long Duration
        {
            get
            {
                return this.duration_;
            }
        }

        public bool HasDate
        {
            get
            {
                return this.hasDate;
            }
        }

        public string Date
        {
            get
            {
                return this.date_;
            }
        }

        public bool HasStype
        {
            get
            {
                return this.hasStype;
            }
        }

        public string Stype
        {
            get
            {
                return this.stype_;
            }
        }

        public IList<InnerFiled> FieldList
        {
            get
            {
                return this.field_;
            }
        }

        public int FieldCount
        {
            get
            {
                return this.field_.Count;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasActionId)
                {
                    return false;
                }
                if (!this.hasType)
                {
                    return false;
                }
                using (IEnumerator<InnerFiled> enumerator = this.FieldList.GetEnumerator())
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
                if (this.hasActionId)
                {
                    num += CodedOutputStream.ComputeInt32Size(1, this.ActionId);
                }
                if (this.hasType)
                {
                    num += CodedOutputStream.ComputeEnumSize(2, (int)this.Type);
                }
                if (this.hasNext)
                {
                    num += CodedOutputStream.ComputeInt32Size(3, this.Next);
                }
                if (this.hasLogo)
                {
                    num += CodedOutputStream.ComputeStringSize(100, this.Logo);
                }
                if (this.hasLogoURL)
                {
                    num += CodedOutputStream.ComputeStringSize(101, this.LogoURL);
                }
                if (this.hasTitle)
                {
                    num += CodedOutputStream.ComputeStringSize(102, this.Title);
                }
                if (this.hasText)
                {
                    num += CodedOutputStream.ComputeStringSize(103, this.Text);
                }
                if (this.hasClearable)
                {
                    num += CodedOutputStream.ComputeBoolSize(104, this.Clearable);
                }
                if (this.hasRing)
                {
                    num += CodedOutputStream.ComputeBoolSize(105, this.Ring);
                }
                if (this.hasBuzz)
                {
                    num += CodedOutputStream.ComputeBoolSize(106, this.Buzz);
                }
                if (this.hasBannerURL)
                {
                    num += CodedOutputStream.ComputeStringSize(107, this.BannerURL);
                }
                if (this.hasImg)
                {
                    num += CodedOutputStream.ComputeStringSize(120, this.Img);
                }
                foreach (Button current in this.ButtonsList)
                {
                    num += CodedOutputStream.ComputeMessageSize(121, current);
                }
                if (this.hasAppid)
                {
                    num += CodedOutputStream.ComputeStringSize(140, this.Appid);
                }
                if (this.hasAppstartupid)
                {
                    num += CodedOutputStream.ComputeMessageSize(141, this.Appstartupid);
                }
                if (this.hasAutostart)
                {
                    num += CodedOutputStream.ComputeBoolSize(142, this.Autostart);
                }
                if (this.hasFailedAction)
                {
                    num += CodedOutputStream.ComputeInt32Size(143, this.FailedAction);
                }
                if (this.hasUrl)
                {
                    num += CodedOutputStream.ComputeStringSize(160, this.Url);
                }
                if (this.hasWithcid)
                {
                    num += CodedOutputStream.ComputeStringSize(161, this.Withcid);
                }
                if (this.hasIsWithnettype)
                {
                    num += CodedOutputStream.ComputeBoolSize(162, this.IsWithnettype);
                }
                if (this.hasAddress)
                {
                    num += CodedOutputStream.ComputeStringSize(180, this.Address);
                }
                if (this.hasContent)
                {
                    num += CodedOutputStream.ComputeStringSize(181, this.Content);
                }
                if (this.hasCt)
                {
                    num += CodedOutputStream.ComputeInt64Size(182, this.Ct);
                }
                if (this.hasFlag)
                {
                    num += CodedOutputStream.ComputeEnumSize(183, (int)this.Flag);
                }
                if (this.hasSuccessedAction)
                {
                    num += CodedOutputStream.ComputeInt32Size(200, this.SuccessedAction);
                }
                if (this.hasUninstalledAction)
                {
                    num += CodedOutputStream.ComputeInt32Size(201, this.UninstalledAction);
                }
                if (this.hasName)
                {
                    num += CodedOutputStream.ComputeStringSize(220, this.Name);
                }
                if (this.hasAutoInstall)
                {
                    num += CodedOutputStream.ComputeBoolSize(223, this.AutoInstall);
                }
                if (this.hasWifiAutodownload)
                {
                    num += CodedOutputStream.ComputeBoolSize(225, this.WifiAutodownload);
                }
                if (this.hasForceDownload)
                {
                    num += CodedOutputStream.ComputeBoolSize(226, this.ForceDownload);
                }
                if (this.hasShowProgress)
                {
                    num += CodedOutputStream.ComputeBoolSize(227, this.ShowProgress);
                }
                if (this.hasPost)
                {
                    num += CodedOutputStream.ComputeStringSize(241, this.Post);
                }
                if (this.hasHeaders)
                {
                    num += CodedOutputStream.ComputeStringSize(242, this.Headers);
                }
                if (this.hasGroupable)
                {
                    num += CodedOutputStream.ComputeBoolSize(260, this.Groupable);
                }
                if (this.hasMmsTitle)
                {
                    num += CodedOutputStream.ComputeStringSize(280, this.MmsTitle);
                }
                if (this.hasMmsURL)
                {
                    num += CodedOutputStream.ComputeStringSize(281, this.MmsURL);
                }
                if (this.hasPreload)
                {
                    num += CodedOutputStream.ComputeBoolSize(300, this.Preload);
                }
                if (this.hasTaskid)
                {
                    num += CodedOutputStream.ComputeStringSize(320, this.Taskid);
                }
                if (this.hasDuration)
                {
                    num += CodedOutputStream.ComputeInt64Size(340, this.Duration);
                }
                if (this.hasDate)
                {
                    num += CodedOutputStream.ComputeStringSize(360, this.Date);
                }
                if (this.hasStype)
                {
                    num += CodedOutputStream.ComputeStringSize(380, this.Stype);
                }
                foreach (InnerFiled current2 in this.FieldList)
                {
                    num += CodedOutputStream.ComputeMessageSize(381, current2);
                }
                num += this.UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num;
                return num;
            }
        }

        private ActionChain()
        {
        }

        public Button GetButtons(int index)
        {
            return this.buttons_[index];
        }

        public InnerFiled GetField(int index)
        {
            return this.field_[index];
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int arg_06_0 = this.SerializedSize;
            string[] actionChainFieldNames = ActionChain._actionChainFieldNames;
            if (this.hasActionId)
            {
                output.WriteInt32(1, actionChainFieldNames[0], this.ActionId);
            }
            if (this.hasType)
            {
                output.WriteEnum(2, actionChainFieldNames[37], (int)this.Type, this.Type);
            }
            if (this.hasNext)
            {
                output.WriteInt32(3, actionChainFieldNames[27], this.Next);
            }
            if (this.hasLogo)
            {
                output.WriteString(100, actionChainFieldNames[22], this.Logo);
            }
            if (this.hasLogoURL)
            {
                output.WriteString(101, actionChainFieldNames[23], this.LogoURL);
            }
            if (this.hasTitle)
            {
                output.WriteString(102, actionChainFieldNames[36], this.Title);
            }
            if (this.hasText)
            {
                output.WriteString(103, actionChainFieldNames[35], this.Text);
            }
            if (this.hasClearable)
            {
                output.WriteBool(104, actionChainFieldNames[9], this.Clearable);
            }
            if (this.hasRing)
            {
                output.WriteBool(105, actionChainFieldNames[30], this.Ring);
            }
            if (this.hasBuzz)
            {
                output.WriteBool(106, actionChainFieldNames[8], this.Buzz);
            }
            if (this.hasBannerURL)
            {
                output.WriteString(107, actionChainFieldNames[6], this.BannerURL);
            }
            if (this.hasImg)
            {
                output.WriteString(120, actionChainFieldNames[20], this.Img);
            }
            if (this.buttons_.Count > 0)
            {
                output.WriteMessageArray<Button>(121, actionChainFieldNames[7], this.buttons_);
            }
            if (this.hasAppid)
            {
                output.WriteString(140, actionChainFieldNames[2], this.Appid);
            }
            if (this.hasAppstartupid)
            {
                output.WriteMessage(141, actionChainFieldNames[3], this.Appstartupid);
            }
            if (this.hasAutostart)
            {
                output.WriteBool(142, actionChainFieldNames[5], this.Autostart);
            }
            if (this.hasFailedAction)
            {
                output.WriteInt32(143, actionChainFieldNames[14], this.FailedAction);
            }
            if (this.hasUrl)
            {
                output.WriteString(160, actionChainFieldNames[39], this.Url);
            }
            if (this.hasWithcid)
            {
                output.WriteString(161, actionChainFieldNames[41], this.Withcid);
            }
            if (this.hasIsWithnettype)
            {
                output.WriteBool(162, actionChainFieldNames[21], this.IsWithnettype);
            }
            if (this.hasAddress)
            {
                output.WriteString(180, actionChainFieldNames[1], this.Address);
            }
            if (this.hasContent)
            {
                output.WriteString(181, actionChainFieldNames[10], this.Content);
            }
            if (this.hasCt)
            {
                output.WriteInt64(182, actionChainFieldNames[11], this.Ct);
            }
            if (this.hasFlag)
            {
                output.WriteEnum(183, actionChainFieldNames[16], (int)this.Flag, this.Flag);
            }
            if (this.hasSuccessedAction)
            {
                output.WriteInt32(200, actionChainFieldNames[33], this.SuccessedAction);
            }
            if (this.hasUninstalledAction)
            {
                output.WriteInt32(201, actionChainFieldNames[38], this.UninstalledAction);
            }
            if (this.hasName)
            {
                output.WriteString(220, actionChainFieldNames[26], this.Name);
            }
            if (this.hasAutoInstall)
            {
                output.WriteBool(223, actionChainFieldNames[4], this.AutoInstall);
            }
            if (this.hasWifiAutodownload)
            {
                output.WriteBool(225, actionChainFieldNames[40], this.WifiAutodownload);
            }
            if (this.hasForceDownload)
            {
                output.WriteBool(226, actionChainFieldNames[17], this.ForceDownload);
            }
            if (this.hasShowProgress)
            {
                output.WriteBool(227, actionChainFieldNames[31], this.ShowProgress);
            }
            if (this.hasPost)
            {
                output.WriteString(241, actionChainFieldNames[28], this.Post);
            }
            if (this.hasHeaders)
            {
                output.WriteString(242, actionChainFieldNames[19], this.Headers);
            }
            if (this.hasGroupable)
            {
                output.WriteBool(260, actionChainFieldNames[18], this.Groupable);
            }
            if (this.hasMmsTitle)
            {
                output.WriteString(280, actionChainFieldNames[24], this.MmsTitle);
            }
            if (this.hasMmsURL)
            {
                output.WriteString(281, actionChainFieldNames[25], this.MmsURL);
            }
            if (this.hasPreload)
            {
                output.WriteBool(300, actionChainFieldNames[29], this.Preload);
            }
            if (this.hasTaskid)
            {
                output.WriteString(320, actionChainFieldNames[34], this.Taskid);
            }
            if (this.hasDuration)
            {
                output.WriteInt64(340, actionChainFieldNames[13], this.Duration);
            }
            if (this.hasDate)
            {
                output.WriteString(360, actionChainFieldNames[12], this.Date);
            }
            if (this.hasStype)
            {
                output.WriteString(380, actionChainFieldNames[32], this.Stype);
            }
            if (this.field_.Count > 0)
            {
                output.WriteMessageArray<InnerFiled>(381, actionChainFieldNames[15], this.field_);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static ActionChain ParseFrom(ByteString data)
        {
            return ActionChain.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static ActionChain ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return ActionChain.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static ActionChain ParseFrom(byte[] data)
        {
            return ActionChain.CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static ActionChain ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return ActionChain.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static ActionChain ParseFrom(Stream input)
        {
            return ActionChain.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static ActionChain ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return ActionChain.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static ActionChain ParseDelimitedFrom(Stream input)
        {
            return ActionChain.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static ActionChain ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return ActionChain.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static ActionChain ParseFrom(ICodedInputStream input)
        {
            return ActionChain.CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static ActionChain ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return ActionChain.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private ActionChain MakeReadOnly()
        {
            this.buttons_.MakeReadOnly();
            this.field_.MakeReadOnly();
            return this;
        }

        public static ActionChain.Builder CreateBuilder()
        {
            return new ActionChain.Builder();
        }

        public override ActionChain.Builder ToBuilder()
        {
            return ActionChain.CreateBuilder(this);
        }

        public override ActionChain.Builder CreateBuilderForType()
        {
            return new ActionChain.Builder();
        }

        public static ActionChain.Builder CreateBuilder(ActionChain prototype)
        {
            return new ActionChain.Builder(prototype);
        }

        static ActionChain()
        {
            ActionChain.defaultInstance = new ActionChain().MakeReadOnly();
            ActionChain._actionChainFieldNames = new string[]
            {
                "actionId",
                "address",
                "appid",
                "appstartupid",
                "autoInstall",
                "autostart",
                "bannerURL",
                "buttons",
                "buzz",
                "clearable",
                "content",
                "ct",
                "date",
                "duration",
                "failedAction",
                "field",
                "flag",
                "forceDownload",
                "groupable",
                "headers",
                "img",
                "is_withnettype",
                "logo",
                "logoURL",
                "mmsTitle",
                "mmsURL",
                "name",
                "next",
                "post",
                "preload",
                "ring",
                "showProgress",
                "stype",
                "successedAction",
                "taskid",
                "text",
                "title",
                "type",
                "uninstalledAction",
                "url",
                "wifiAutodownload",
                "withcid"
            };
            ActionChain._actionChainFieldTags = new uint[]
            {
                8u,
                1442u,
                1122u,
                1130u,
                1784u,
                1136u,
                858u,
                970u,
                848u,
                832u,
                1450u,
                1456u,
                2882u,
                2720u,
                1144u,
                3050u,
                1464u,
                1808u,
                2080u,
                1938u,
                962u,
                1296u,
                802u,
                810u,
                2242u,
                2250u,
                1762u,
                24u,
                1930u,
                2400u,
                840u,
                1816u,
                3042u,
                1600u,
                2562u,
                826u,
                818u,
                16u,
                1608u,
                1282u,
                1800u,
                1290u
            };
            FileDescriptor arg_1A8_0 = GtReq.Descriptor;
        }
    }
}

