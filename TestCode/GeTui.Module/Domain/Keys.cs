using BlueCat.Core.Options;
using System.Configuration;

namespace GeTui.Module.Domain
{
    internal static class ConfigSettings
    {
        public static readonly string Host = ConfigurationManager.AppSettings["Host"];
        public static readonly string AppKey = ConfigurationManager.AppSettings["AppKey"];
        public static readonly string AppId = ConfigurationManager.AppSettings["AppId"];
        public static readonly string MasterSecret = ConfigurationManager.AppSettings["MasterSecret"];
        public static readonly string DefaultPushContent = ConfigurationManager.AppSettings["DefaultPushContent"];
    }
}