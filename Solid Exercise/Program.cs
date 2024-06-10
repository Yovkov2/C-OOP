namespace Loggers
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            ILayout simpleLayout = new SimpleLayout();

            
            IAppender consoleAppender = new ConsoleAppender(simpleLayout)
            {
                ReportLevelThreshold = ReportLevel.Warning
            };

            
            IAppender fileAppender = new FileAppender(simpleLayout, "log.txt")
            {
                ReportLevelThreshold = ReportLevel.Error
            };

            ILogger logger = new Logger(consoleAppender, fileAppender);

            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON."); 
            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered."); 
        }
    }
    public enum ReportLevel
    {
        Info,
        Warning,
        Error,
        Critical,
        Fatal
    }
}