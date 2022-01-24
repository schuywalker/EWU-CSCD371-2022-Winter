using System;
using Logger;

namespace Logger
{
    // References: CSCD371 Lecture
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
        

        // There is an existing BaseLogger class. It needs an auto property to hold the class name.
        // This property should be set in the LogFactory using an object initializer.
        


        //References for research
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties

        //The LogFactory should be updated with a new method ConfigureFileLogger.
        //This should take in a file path and store it in a private member.
        //It should use this when instantiating a new FileLogger in its CreateLogger method. ❌✔
    }
}