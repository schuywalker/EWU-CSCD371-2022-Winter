using System.Runtime.CompilerServices;
//using Microsoft.Extensions.Logging;

namespace Logger
{
    public static class BaseLoggerMixins
    {
        // https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger?view=dotnet-plat-ext-3.1#extension-methods
        public static void LogError(string message, params object[] args)
        {

        }

        //https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.loggerextensions.logwarning?view=dotnet-plat-ext-6.0#microsoft-extensions-logging-loggerextensions-logwarning(microsoft-extensions-logging-ilogger-system-string-system-object())
        public static void LogWarning(string? message, params object?[] args)
            {

            }

        //https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.loggerextensions.loginformation?view=dotnet-plat-ext-6.0#microsoft-extensions-logging-loggerextensions-loginformation(microsoft-extensions-logging-ilogger-system-string-system-object())
        public static void LogInformation(string? message, params object?[] args)
        {

        }

        //https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.loggerextensions.logdebug?view=dotnet-plat-ext-6.0#microsoft-extensions-logging-loggerextensions-logdebug(microsoft-extensions-logging-ilogger-system-string-system-object())
        public static void LogDebug(string? message, params object?[] args)
        {

        }

        public class LogMixins : BaseLogger
        {
            public override void Log(LogLevel logLevel, string message)
            {
                BaseLoggerMixins.LogError("Processing request from ", logLevel);
                BaseLoggerMixins.LogWarning("Processing request from ", logLevel);
                BaseLoggerMixins.LogInformation("Processing request from  ", logLevel);
                BaseLoggerMixins.LogDebug("Processing request from ", logLevel);

                    throw new System.NotImplementedException();
            }
        }

 
    }
}
