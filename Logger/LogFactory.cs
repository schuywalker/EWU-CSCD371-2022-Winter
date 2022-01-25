using System;
using Logger;

namespace Logger
{
    public class LogFactory   
    {
        private static string Path = "x";//we'll need to change this later and use nameOf()

        public static FileLogger? CreateLogger(string className)
        {
            //parse className??
            
            FileLogger logger = new FileLogger(Path);
            logger.ClassName = className;
            ConfigureFileLogger(logger, Path);

            return logger;
/*
            if (true)//needs to be if file logger not configured, but cant access FilePath getter. not sure what to do here..
            {
                return null;
            }
*/
        }

        public static void ConfigureFileLogger(FileLogger logger, string FilePath)
        {
            Path = FilePath;
        }
        
    }
}