using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers
{
    public class FileAppender : IAppender
    {
        public ILayout Layout { get; private set; }
        public ReportLevel ReportLevelThreshold { get; set; } = ReportLevel.Info;
        private readonly string filePath;

        public FileAppender(ILayout layout, string filePath)
        {
            Layout = layout;
            this.filePath = filePath;
        }

        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= ReportLevelThreshold)
            {
                string formattedMessage = Layout.Format(dateTime, reportLevel.ToString(), message);
                System.IO.File.AppendAllText(filePath, formattedMessage + Environment.NewLine);
            }
        }
    }
}
