using com.gexin.rp.sdk.dto;
using System;

namespace com.igetui.api.openservice.igetui.template.style
{
    public abstract class AbstractNotifyStyle : INotifyStyle
    {
        protected bool isRing = true;

        protected bool isVibrate = true;

        protected bool isClearable = true;

        protected ActionChain.Builder actionChainBuilder;

        public bool IsRing
        {
            get
            {
                return this.isRing;
            }
            set
            {
                this.isRing = value;
            }
        }

        public bool IsVibrate
        {
            get
            {
                return this.isVibrate;
            }
            set
            {
                this.isVibrate = value;
            }
        }

        public bool IsClearable
        {
            get
            {
                return this.isClearable;
            }
            set
            {
                this.isClearable = value;
            }
        }

        public AbstractNotifyStyle()
        {
            this.actionChainBuilder = ActionChain.CreateBuilder().SetActionId(10000).SetType(ActionChain.Types.Type.mmsinbox2).SetStype("notification").SetNext(10010);
        }

        public abstract ActionChain getActionChain();
    }
}
