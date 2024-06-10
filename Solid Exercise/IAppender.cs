using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers
{
    public interface IAppender
    {
        ILayout Layout { get; }
        ReportLevel ReportLevelThreshold { get; set; }
        void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}
