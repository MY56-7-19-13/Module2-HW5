using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Actions
    {
        private readonly Logger _logger;

        public Actions(Logger logger)
        {
            _logger = logger;
        }

        public bool StartMethod()
        {
            _logger.LoggerInfo("Start method");
            return true;
        }

        public void SkippedLogicInMethod()
        {
            throw new BusinessExeption("Skipped logic in method");
        }

        public void BrokeMethod()
        {
            throw new Exception("I broke a logic!");
        }
    }
}
