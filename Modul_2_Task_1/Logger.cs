using System;
using System.Text;

namespace Modul_2_Task_1
{
    public class Logger
    {
        private StringBuilder _logText;
        private Logger()
        {
            _logText = new StringBuilder();
        }

        public static Logger Instance
        {
            get { return Nested.Instance; }
        }

        public void Log(LogType logType, string message)
        {
            var logMessage = $"{DateTime.UtcNow}: {logType}: {message}";
            Console.WriteLine(logMessage);
            _logText.AppendLine(logMessage);
        }

        public string GetLogs()
        {
            return _logText.ToString();
        }

        private class Nested
        {
            internal static readonly Logger Instance = new Logger();
            static Nested()
            {
            }
        }
    }
}
