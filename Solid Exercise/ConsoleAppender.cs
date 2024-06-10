using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers
{
    public class ConsoleAppender : IAppender
    {
        public ILayout Layout { get; private set; }
        public ReportLevel ReportLevelThreshold { get; set; } = ReportLevel.Info;

        public ConsoleAppender(ILayout layout)
        {
            Layout = layout;
        }

        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= ReportLevelThreshold)
            {
                string formattedMessage = Layout.Format(dateTime, reportLevel.ToString(), message);
                Console.WriteLine(formattedMessage);
            }
        }
    }
}
