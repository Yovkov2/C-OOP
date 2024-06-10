using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers
{
    internal class XmlLayout : ILayout
    {
        public string Format(string dateTime, string reportLevel, string message)
        {
            return $"<log>\n\t<date>{dateTime}</date>\n\t<level>{reportLevel}</level>\n\t<message>{message}</message>\n</log>";
        }
    }
}
