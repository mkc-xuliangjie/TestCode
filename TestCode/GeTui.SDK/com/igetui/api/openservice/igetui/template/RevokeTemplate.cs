using com.gexin.rp.sdk.dto;
using System;
using System.Collections.Generic;

namespace com.igetui.api.openservice.igetui.template
{
    public class RevokeTemplate : AbstractTemplate
    {
        private bool force;

        private string oldTaskId;

        public string OldTaskId
        {
            get
            {
                return this.oldTaskId;
            }
            set
            {
                this.oldTaskId = value;
            }
        }

        public bool isForce()
        {
            return this.force;
        }

        public void setForce(bool value)
        {
            this.force = value;
        }

        public override List<ActionChain> getActionChain()
        {
            List<ActionChain> arg_A8_0 = new List<ActionChain>();
            ActionChain item = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.mmsinbox2).SetStype("terminatetask").AddField(InnerFiled.CreateBuilder().SetKey("taskid").SetVal(this.oldTaskId).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("force").SetVal(this.force ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).SetNext(100).Build();
            ActionChain item2 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
            arg_A8_0.Add(item);
            arg_A8_0.Add(item2);
            return arg_A8_0;
        }

        public override string getPushType()
        {
            return "Revoke";
        }

        protected override int getTemplateId()
        {
            return 8;
        }
    }
}
