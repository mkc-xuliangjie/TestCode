namespace GeTui.Module.Domain
{
    internal static class Intent
    {
        private const string str1 = "intent:#Intent;action=android.intent.action.oppopush;launchFlags=0x14000000;component=";
        private const string str2 = "/io.dcloud.PandoraEntry;S.UP-OL-SU=true";
        private const string str3 = ";S.title=";
        private const string str4 = ";S.content=";
        private const string str5 = ";S.payload=";
        private const string str6 = ";end";

        public static string GetIntent(this GeTui geTui)
        {
            return $"{str1}{Keys.PackageName}{str2}{str3}{geTui.Title}{str4}{geTui.PushContent}{str5}{geTui.JsonContent}{str6}";
        }
    }
}