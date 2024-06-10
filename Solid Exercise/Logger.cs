using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers
{
        public class Logger : ILogger
        {
            private readonly IList<IAppender> appenders;

            public Logger(params IAppender[] appenders)
            {
                this.appenders = new List<IAppender>(appenders);
            }

            public void Info(string dateTime, string message)
            {
                Log(dateTime, ReportLevel.Info, message); 
            }

            public void Error(string dateTime, string message)
            {
                Log(dateTime, ReportLevel.Error, message); 
            }

            private void Log(string dateTime, ReportLevel reportLevel, string message) 
            {
                foreach (var appender in appenders)
                {
                    appender.Append(dateTime, reportLevel, message); 
                }
            }
        }
}
