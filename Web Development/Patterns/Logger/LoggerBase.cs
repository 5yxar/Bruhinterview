using System;

namespace Patterns.Logger
{
    public abstract class LoggerBase
    {
        private readonly LoggerBase _loggerBase;
 
        protected LoggerBase(LoggerBase loggerBase)
        {
            _loggerBase = loggerBase;
        }
 
        public virtual void PrintLog(string text)
        {
            _loggerBase.PrintLog(text);
            Console.Write(text);
        }
    }
}