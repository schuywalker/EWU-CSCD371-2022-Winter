using System;
using Logger;

namespace Logger
{
    public class LogFactory   
    {
        private string? Path;
        //nameof(Logger.BaseLogger.ClassName); //Schuyler: changing this in order to set it in a LogFactory constructor, we can go back if we decide we dont need it!
        //private string? ClassName;

        public bool Configured { get; set; }
        public LogFactory()
        {
            Configured = false;
        }


        public BaseLogger CreateLogger(string className) //BaseLogger
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