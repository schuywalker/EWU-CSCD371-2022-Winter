using System;
using Logger;

namespace Logger
{
    public class LogFactory   
    {
        private string? Path;
        //nameof(Logger.BaseLogger.ClassName); //Schuyler: changing this in order to set it in a LogFactory constructor, we can go back if we decide we dont need it!
        private string? ClassName;

        private bool Configured { get; set; }
        public LogFactory()
        {
            Configured = false;
        }


        public BaseLogger? CreateLogger(string className) //BaseLogger
        {
            if (!Configured)
            {
                return null;
                
            }

            else
            {
                BaseLogger logger = new FileLogger(Path!);//using bang because if condition will execute above if Path is Null
                ConfigureFileLogger(Path!);
                return logger;
            }
               
        }

        public void ConfigureFileLogger(string FilePath)
        {
            Path = FilePath;
            Configured = true;
        }
        
    }
}