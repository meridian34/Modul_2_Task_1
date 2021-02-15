using System;
using System.Text;

namespace Modul_2_Task_1.Models
{
    public class Logger
    {
        private StringBuilder _logText;
        private Logger()
        {
            _logText
        }

        public static Logger Instance { get { return Nested.Instance; } }

        private class Nested
        {
            internal static readonly Logger Instance = new Logger();
            static Nested()
            {
            }
        }
    }

    public class Loggger
    {
        readonly Loggger _logger;
        private StringBuilder _log;

        private Loggger()
        {
        }

        //public static Loggger GetLoggger()
        //{
        //    if (_loggger == null)
        //    {
        //        _loggger = new Loggger();
        //        _loggger._log = new StringBuilder();
        //    }

        //    return _loggger;
        //}

        public static Loggger Instance { get; init; }

        internal void AddLog(string message, LogType logType)
        {
            string logMessage = $"{DateTime.UtcNow}: {logType}: {message}";
            Console.WriteLine(logMessage);
            _log.Append($"{logMessage}\n");
        }

        internal string GetLog()
        {
            return _loggger._log.ToString();
        }
    }
}
