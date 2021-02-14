using System;
using System.Collections.Generic;
using System.Text;

namespace Modul_2_Task_1.Models
{
    internal class Logger
    {
        private static Logger _logger;
        private StringBuilder _sb;

        private Logger()
        {
        }

        internal static Logger GetLogger()
        {
            if (_logger == null)
            {
                _logger = new Logger();
                _logger._sb = new StringBuilder();
            }

            return _logger;
        }

        internal void AddLog(string message, LogType logType)
        {
            string logMessage = $"{DateTime.UtcNow}: {logType}: {message}";
            Console.WriteLine(logMessage);
            _sb.Append($"{logMessage}\n");
        }

        internal string GetLog()
        {
            return _logger._sb.ToString();
        }
    }
}
