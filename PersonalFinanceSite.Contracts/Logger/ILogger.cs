using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceSite.Contracts.Logger
{
    public interface ILogger
    {
        void LogEvent(string message);
        void LogError(string message);
        void LogSuccess(string message);        
    }
}
