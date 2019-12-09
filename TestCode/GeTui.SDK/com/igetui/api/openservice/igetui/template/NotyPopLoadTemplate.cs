using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.style;
using System;
using System.Collections.Generic;

namespace com.igetui.api.openservice.igetui.template
{
    public class NotyPopLoadTemplate : AbstractTemplate
    {
        private string notyIcon;

        private string logoURL = "";

        private string notyTitle;

        private string notyContent;

        private bool isCleared = true;

        private bool isBelled = true;

        private bool isVibrationed = true;

        private string popTitle;

        private string popContent;

        private string popImage;

        private string popButton1;

        private string popButton2;

        private string loadIcon;

        private string loadTitle;

        private string loadUrl;

        private bool isAutoInstall;

        private bool isActived;

        private string androidMark = "";

        private string symbianMark = "";

        private string iphoneMark = "";

        private int? notifyid;

        private AbstractNotifyStyle style;

        private int notifyStyle;

        public string NotyIcon
        {
            get
            {
                return this.notyIcon;
            }
            set
            {
                this.notyIcon = value;
            }
        }

        public string LogoURL
        {
            get
            {
                return this.logoURL;
            }
            set
            {
                this.logoURL = value;
            }
        }

        public string NotyTitle
        {
            get
            {
                return this.notyTitle;
            }
            set
            {
                this.notyTitle = value;
            }
        }

        public string NotyContent
        {
            get
            {
                return this.notyContent;
            }
            set
            {
                this.notyContent = value;
            }
        }

        public bool IsCleared
        {
            get
            {
                return this.isCleared;
            }
            set
            {
                this.isCleared = value;
            }
        }

        public bool IsBelled
        {
            get
            {
                return this.isBelled;
            }
            set
            {
                this.isBelled = value;
            }
        }

        public bool IsVibrationed
        {
            get
            {
                return this.isVibrationed;
            }
            set
            {
                this.isVibrationed = value;
            }
        }

        public string PopTitle
        {
            get
            {
                return this.popTitle;
            }
            set
            {
                this.popTitle = value;
            }
        }

        public string PopContent
        {
            get
            {
                return this.popContent;
            }
            set
            {
                this.popContent = value;
            }
        }

        public string PopImage
        {
            get
            {
                return this.popImage;
            }
            set
            {
                this.popImage = value;
            }
        }

        public string PopButton1
        {
            get
            {
                return this.popButton1;
            }
            set
            {
                this.popButton1 = value;
            }
        }

        public string PopButton2
        {
            get
            {
                return this.popButton2;
            }
            set
            {
                this.popButton2 = value;
            }
        }

        public string LoadIcon
        {
            get
            {
                return this.loadIcon;
            }
            set
            {
                this.loadIcon = value;
            }
        }

        public string LoadTitle
        {
            get
            {
                return this.loadTitle;
            }
            set
            {
                this.loadTitle = value;
            }
        }

        public string LoadUrl
        {
            get
            {
                return this.loadUrl;
            }
            set
            {
                this.loadUrl = value;
            }
        }

        public bool IsAutoInstall
        {
            get
            {
                return this.isAutoInstall;
            }
            set
            {
                this.isAutoInstall = value;
            }
        }

        public bool IsActived
        {
            get
            {
                return this.isActived;
            }
            set
            {
                this.isActived = value;
            }
        }

        public string AndroidMark
        {
            get
            {
                return this.androidMark;
            }
            set
            {
                this.androidMark = value;
            }
        }

        public string SymbianMark
        {
            get
            {
                return this.symbianMark;
            }
            set
            {
                this.symbianMark = value;
            }
        }

        public string IphoneMark
        {
            get
            {
                return this.iphoneMark;
            }
            set
            {
                this.iphoneMark = value;
            }
        }

        public void setNotifyid(int? notifyid)
        {
            if (notifyid < 0)
            {
                throw new Exception("notifyid need greater than 0");
            }
            this.notifyid = notifyid;
        }

        public override List<ActionChain> getActionChain()
        {
            List<ActionChain> arg_419_0 = new List<ActionChain>();
            ActionChain item = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.Goto).SetNext(10000).Build();
            ActionChain item2 = (this.style == null) ? ActionChain.CreateBuilder().SetActionId(10000).SetType(ActionChain.Types.Type.mmsinbox2).SetStype("notification").AddField(InnerFiled.CreateBuilder().SetKey("notifyid").SetVal((!this.notifyid.HasValue) ? "" : this.notifyid.ToString()).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("title").SetVal(this.notyTitle).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("text").SetVal(this.notyContent).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(this.notyIcon).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo_url").SetVal(this.logoURL).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("notifyStyle").SetVal(string.Concat(this.notifyStyle)).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noring").SetVal((!this.isBelled).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noclear").SetVal((!this.isCleared).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_novibrate").SetVal((!this.isVibrationed).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).SetNext(10010).Build() : this.style.getActionChain().ToBuilder().AddField(InnerFiled.CreateBuilder().SetKey("notifyid").SetVal((!this.notifyid.HasValue) ? "" : this.notifyid.ToString()).SetType(InnerFiled.Types.Type.str).Build()).Build();
            ActionChain item3 = ActionChain.CreateBuilder().SetActionId(10010).SetType(ActionChain.Types.Type.Goto).SetNext(10020).Build();
            Button value = Button.CreateBuilder().SetText(this.popButton1).SetNext(10040).Build();
            Button value2 = Button.CreateBuilder().SetText(this.popButton2).SetNext(100).Build();
            ActionChain item4 = ActionChain.CreateBuilder().SetActionId(10020).SetType(ActionChain.Types.Type.popup).SetTitle(this.popTitle).SetText(this.popContent).SetImg(this.popImage).AddButtons(value).AddButtons(value2).SetNext(6).Build();
            AppStartUp appstartupid = AppStartUp.CreateBuilder().SetAndroid(this.androidMark).SetSymbia(this.symbianMark).SetIos(this.iphoneMark).Build();
            ActionChain item5 = ActionChain.CreateBuilder().SetActionId(10040).SetType(ActionChain.Types.Type.appdownload).SetName(this.loadTitle).SetUrl(this.loadUrl).SetLogo(this.loadIcon).SetLogoURL(this.logoURL).SetAutoInstall(this.isAutoInstall).SetAutostart(this.isActived).SetAppstartupid(appstartupid).SetNext(6).Build();
            ActionChain item6 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
            arg_419_0.Add(item);
            arg_419_0.Add(item2);
            arg_419_0.Add(item3);
            arg_419_0.Add(item4);
            arg_419_0.Add(item5);
            arg_419_0.Add(item6);
            return arg_419_0;
        }

        public override string getPushType()
        {
            return "NotyPopLoadTemplate";
        }

        protected override int getTemplateId()
        {
            return 2;
        }
    }
}
