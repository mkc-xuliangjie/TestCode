using com.igetui.api.openservice;

namespace GeTui.Module.Domain.PushStrategy
{
    internal abstract class BasePush : IGtPush
    {
        protected BasePush(PhoneType phoneType, TemplateType templateType, GeTui geTui) : base(ConfigSettings.Host, ConfigSettings.AppKey, ConfigSettings.MasterSecret)
        {
            GeTui = geTui;
            PhoneType = phoneType;
            TemplateType = templateType;
        }

        public virtual GeTui GeTui { get; }

        public virtual PhoneType PhoneType { get; }

        public virtual TemplateType TemplateType { get; }

        public abstract string Push();
    }
}