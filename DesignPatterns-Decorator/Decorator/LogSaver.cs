﻿
namespace DesignPatterns.Structural.Decorator
{
    using System.Threading.Tasks;

    public sealed class LogSaver : ILogSaver
    {
        public Task SaveLogEntry(string Id, string log)
        {
            return Task.FromResult<object>(null);
        }
    }
}
