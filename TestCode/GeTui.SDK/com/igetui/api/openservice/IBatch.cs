using com.igetui.api.openservice.igetui;
using System;

namespace com.igetui.api.openservice
{
    public interface IBatch
    {
        void setApiUrl(string apiUrl);

        string add(SingleMessage message, Target target);

        string submit();

        string retry();
    }
}
