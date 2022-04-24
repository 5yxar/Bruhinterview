namespace Patterns.Logger
{
    public class DebugLog : LoggerBase
    {
        public DebugLog(LoggerBase logger= null) : base(logger)
        {
        }

        public override void PrintLog(string text)
        {
            text = "Debug " + text;
            base.PrintLog(text);
        }
    }
}