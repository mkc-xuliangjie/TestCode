using BlueCat.Core.Options;
using System.Configuration;

namespace GeTui.Module.Domain
{
    internal static class Keys
    {
        public static readonly string Host = ConfigurationManager.AppSettings["Host"];
        public static readonly string PackageName = ConfigurationManager.AppSettings["PackageName"];
        public static readonly string AppKey = ConfigurationManager.AppSettings["AppKey"];
        public static readonly string AppId = ConfigurationManager.AppSettings["AppId"];
        public static readonly string MasterSecret = ConfigurationManager.AppSettings["MasterSecret"];
        public static readonly string TemplateType = ConfigurationManager.AppSettings["TemplateType"];
        public static readonly string LogPath = ConfigurationManager.AppSettings["LogPath"];
        public static readonly string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        public static readonly string NotificationTemplate = "1";
        public static readonly string TransmissionTemplate = "2";
    }
}