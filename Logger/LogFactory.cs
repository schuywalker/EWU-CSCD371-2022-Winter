namespace Logger
{
    // References: CSCD371 Lecture
    public class LogFactory
    {
        //private string name;

        public BaseLogger CreateLogger(string className)
        {   
            boolean configure = ConfigureFileLogger();
            if(configure == false)
            {
                return null;
            }
            return new Logger(className);
        }

        // There is an existing BaseLogger class. It needs an auto property to hold the class name.
        // This property should be set in the LogFactory using an object initializer.
       // new BaseLogger className { get; set; }

        //References for research
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties

        //The LogFactory should be updated with a new method ConfigureFileLogger.
        //This should take in a file path and store it in a private member.
        //It should use this when instantiating a new FileLogger in its CreateLogger method. ❌✔
        public string ConfigureFileLogger() {
        //get {filepath = @"c:\";}
        // filepath = name
        }
    }
}