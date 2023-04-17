using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class LoggerRecord
    {
        public DateTime DateTime
        {
            get { return DateTime.Now; }
        }

        public LoggerType Type { get; set; }
    }
}
