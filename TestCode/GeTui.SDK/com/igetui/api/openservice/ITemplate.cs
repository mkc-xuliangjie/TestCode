using com.gexin.rp.sdk.dto;
using System;

namespace com.igetui.api.openservice
{
    public interface ITemplate
    {
        Transparent getTransparent();

        string getTransmissionContent();

        string getPushType();

        PushInfo getPushInfo();
    }
}
