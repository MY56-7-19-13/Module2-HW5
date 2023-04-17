using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class BusinessExeption : Exception
    {
        public BusinessExeption(string message)
            : base(message)
        {
        }
    }
}
