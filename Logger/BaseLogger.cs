using System.Diagnostics.CodeAnalysis;

namespace Logger { 

    public abstract class BaseLogger
    {
        public abstract void Log(LogLevel? logLevel, string message);

        // auto property
        public string? ClassName { get; set; } = string.Empty;
        //public bool Configured { get; set; }

    }

}






 
