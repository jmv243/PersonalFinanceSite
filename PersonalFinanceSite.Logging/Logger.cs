using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.Logger;

namespace PersonalFinanceSite.Logging
{
    public class Logger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine(message);
        }

        public void LogEvent(string message)
        {
            Console.WriteLine(message);
        }

        public void LogSuccess(string message)
        {            
            Console.WriteLine(message);
        }

        private enum LogType
        {
            Success = 0,
            Error = 1,
            GeneralEvent = 2
        }
    }
}
