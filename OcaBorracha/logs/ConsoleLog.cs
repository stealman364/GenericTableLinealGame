using OcaBorracha.interfaces;
using System;

namespace OcaBorracha.logs
{
    internal class ConsoleLog : ILogger
    {
        private ConsoleLog consoleLog = null;

        private ConsoleLog()
        {
        }

        public ConsoleLog GetConsoleLog()
        {
            return consoleLog != null ? consoleLog : new ConsoleLog();
        }

        public string FormatLog(string textToFormat)
        {
            return $"{DateTime.Now} => {textToFormat}";
        }

        public void PrintLog(string formatedText)
        {
            Console.WriteLine(FormatLog(formatedText));
        }
    }
}