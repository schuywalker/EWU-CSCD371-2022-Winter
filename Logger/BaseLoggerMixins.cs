﻿using System;

namespace Logger
{
    public static class BaseLoggerMixins
    {
        //References for research
        // https://csharp.hotexamples.com/examples/System/Logger/LogError/php-logger-logerror-method-examples.html
        // https://www.code4it.dev/blog/csharp-extension-methods

        // * Code Reference
        // https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger?view=dotnet-plat-ext-3.1#extension-methods
        public static void LogWarning(this BaseLogger? baseLogger, string message, params object[] args)
        {
            if (baseLogger == null)
            {
                Console.WriteLine("LogError: baselogger == null");
                throw new ArgumentNullException(nameof(baseLogger));
            }

            string? debug = String.Format(message, args);

            baseLogger.Log(LogLevel.Debug, debug);

        }

        // * Code Reference 
        //https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.loggerextensions.logwarning?view=dotnet-plat-ext-6.0#microsoft-extensions-logging-loggerextensions-logwarning(microsoft-extensions-logging-ilogger-system-string-system-object())
        public static void LogInformaton(this BaseLogger? baseLogger, string message, params object[] args)
            {
            if(baseLogger == null)
            {
                Console.WriteLine("LogWarning: baselogger == null");
                throw new ArgumentNullException(nameof(baseLogger));
            }

            string? debug = String.Format(message, args);

            baseLogger.Log(LogLevel.Debug, debug);

        }

        // * Code Reference 
        //https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.loggerextensions.loginformation?view=dotnet-plat-ext-6.0#microsoft-extensions-logging-loggerextensions-loginformation(microsoft-extensions-logging-ilogger-system-string-system-object())
        public static void LogInformation(this BaseLogger? baseLogger, string message, params object[] args)
        {
            if (baseLogger == null)
            {
                Console.WriteLine("LogInformation: baselogger == null");
                throw new ArgumentNullException(nameof(baseLogger));
            }

            string? debug = String.Format(message, args);

            baseLogger.Log(LogLevel.Debug, debug);

        }

        // * Code Reference 
        //https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.loggerextensions.logdebug?view=dotnet-plat-ext-6.0#microsoft-extensions-logging-loggerextensions-logdebug(microsoft-extensions-logging-ilogger-system-string-system-object())
        public static void LogDebug(this BaseLogger? baseLogger, string message, params object[] args)
        {
            if (baseLogger == null)
            {
                Console.WriteLine("LogDebug: baselogger == null");
                throw new ArgumentNullException(nameof(baseLogger));
            }

            string ? debug = String.Format(message,args);

            baseLogger.Log(LogLevel.Debug, debug);

        }

 
    }
}
