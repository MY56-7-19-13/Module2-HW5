using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Logger
    {
        private FileService _fileService;

        public Logger()
        {
            _fileService = new FileService();
        }

        public void LoggerError(string text)
        {
            LoggerRecord loggerRecord = new LoggerRecord() { Type = LoggerType.Error };
            var logMessage = $"{DateTime.Now}: {loggerRecord.Type}: {text}";
            Console.WriteLine(logMessage);
            _fileService.SerializationSample(logMessage);
        }

        public void LoggerInfo(string text)
        {
            LoggerRecord loggerRecord = new LoggerRecord() { Type = LoggerType.Info };
            var logMessage = $"{DateTime.Now}: {loggerRecord.Type}: {text}";
            Console.WriteLine(logMessage);
            _fileService.SerializationSample(logMessage);
        }

        public void LoggerWarning(string text)
        {
            LoggerRecord loggerRecord = new LoggerRecord() { Type = LoggerType.Warning };
            var logMessage = $"{DateTime.Now}: {loggerRecord.Type}: {text}";
            Console.WriteLine(logMessage);
            _fileService.SerializationSample(logMessage);
        }
    }
}
