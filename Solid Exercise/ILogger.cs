using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers
{
    public interface ILogger
    {
        void Info(string dateTime, string message);
        void Error(string dateTime, string message);
    }
}
