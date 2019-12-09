using System;
using System.Collections.Generic;
using System.Text;

namespace GetuiServerApiSDK_Core.utils
{
    public interface ILog
    {
        void info(params object[] values);

        void debug(params object[] values);

        void error(Exception e, params object[] values);

        void slow(params object[] values);
    }
}
