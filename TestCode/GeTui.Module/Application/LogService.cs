using System;
using System.IO;
using GeTui.Module.Domain;

namespace GeTui.Module.Application
{
    internal static class LogService
    {
        public static void Log(string content)
        {
            if (string.IsNullOrEmpty(content)) return;
            var fs = new FileStream(Keys.LogPath, FileMode.OpenOrCreate, FileAccess.Write);
            var sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine($"[{DateTime.Now}]\t{content}");

            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}