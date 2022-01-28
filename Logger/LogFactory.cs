using System;
using Logger;

namespace Logger
{
    public class LogFactory   
    {
        private string? Path;

        public bool Configured { get; set; }
        public LogFactory()
        {
            Configured = false;
        }


        public BaseLogger? CreateLogger(string className) //BaseLogger
        {
            if (!Configured)
            {
                return null!;//intending to return null in this case   
            }

            else
            {
                BaseLogger logger = new FileLogger(Path!) //using bang because if condition will execute above if Path is Null
                {
                    ClassName = className,
                };  
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