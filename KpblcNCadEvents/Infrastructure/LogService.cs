using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

namespace KpblcNCadEvents.Infrastructure
{
    internal static class LogService
    {
        public static void LogMessage(string DocumentName, [CallerMemberName] string Message = null)
        {
            if (!Directory.Exists(Path.GetDirectoryName(_logFileName)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_logFileName));
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(_logFileName, true))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.fff")
                        + DocumentName == null ? "Без имени документа" :
                        DocumentName
                        + "\t:\t"
                        + Message == null ? "Нет сообщения" : Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static string _logFileName =
            Path.Combine(Environment.GetEnvironmentVariable("appdata"), @"KpblcNCadEvents\KpblcNCadEvents.Log");
    }
}
