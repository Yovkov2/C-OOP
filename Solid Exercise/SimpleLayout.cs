using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers
{
    public class SimpleLayout : ILayout
    {
        public string Format(string dateTime, string reportLevel, string message)
        {
            return $"{dateTime} - {reportLevel} - {message}";
        }
    }
}
