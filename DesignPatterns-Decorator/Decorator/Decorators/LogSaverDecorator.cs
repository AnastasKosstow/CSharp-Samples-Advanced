﻿
namespace DesignPatterns.Structural.Decorator
{
    using System.Threading.Tasks;

    public abstract class LogSaverDecorator : ILogSaver
    {
        protected readonly ILogSaver _logSaverDecorator;

        public LogSaverDecorator(ILogSaver logSaverDecorato)
            =>
            _logSaverDecorator = logSaverDecorato;


        public abstract Task SaveLogEntry(string Id, string log);
    }
}
