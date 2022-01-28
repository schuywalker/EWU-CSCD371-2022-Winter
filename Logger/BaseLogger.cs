using System.Diagnostics.CodeAnalysis;

namespace Logger { 

    public abstract class BaseLogger
    {
        public abstract void Log(LogLevel? logLevel, string message);

        public string? ClassName { get; set; } = string.Empty;

    }

}






 
