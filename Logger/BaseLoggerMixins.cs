using System;

namespace Logger
{
    public static class BaseLoggerMixins
    {

        //References for research
        // https://csharp.hotexamples.com/examples/System/Logger/LogError/php-logger-logerror-method-examples.html
        // https://www.code4it.dev/blog/csharp-extension-methods

        //Each of these methods should take in a string for the message,
        //as well as a parameter array of arguments for the message.
        //Each of these extension methods is expected to be a shortcut for calling the BaseLogger.
        //Log method, by automatically supplying the appropriate LogLevel.
        //These methods should throw an exception if the BaseLogger parameter is null.
        //There are a couple example unit tests to get you started.

        // * Code Reference
        // https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger?view=dotnet-plat-ext-3.1#extension-methods
        public static void LogError(string message, params object?[] args)
        {
            if (args == null)
            {
                Console.WriteLine("LogError: args == null");
                throw new ArgumentNullException(nameof(args));
            }

            for (int i = 0; i < args.Length; i++)
            {
                LogError(message, args[i]);
            }

        }

        // * Code Reference 
        //https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.loggerextensions.logwarning?view=dotnet-plat-ext-6.0#microsoft-extensions-logging-loggerextensions-logwarning(microsoft-extensions-logging-ilogger-system-string-system-object())
        public static void LogWarning(string? message, params object?[] args)
            {
            if(args == null)
            {
                Console.WriteLine("LogWarning: args == null");
                throw new ArgumentNullException(nameof(args));
            }

            for (int i = 0; i < args.Length; i++)
            {
                LogWarning(message, args[i]);
            }

        }

        // * Code Reference 
        //https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.loggerextensions.loginformation?view=dotnet-plat-ext-6.0#microsoft-extensions-logging-loggerextensions-loginformation(microsoft-extensions-logging-ilogger-system-string-system-object())
        public static void LogInformation(string? message, params object?[] args)
        {
            if (args == null)
            {
                Console.WriteLine("LogInformation: args == null");
                throw new ArgumentNullException(nameof(args));
            }

            for (int i = 0; i < args.Length; i++)
            {
                LogInformation(message, args[i]);
            }

        }

        // * Code Reference 
        //https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.loggerextensions.logdebug?view=dotnet-plat-ext-6.0#microsoft-extensions-logging-loggerextensions-logdebug(microsoft-extensions-logging-ilogger-system-string-system-object())
        public static void LogDebug(string? message, params object?[] args)
        {
            if (args == null)
            {
                Console.WriteLine("LogDebug: args == null");
                throw new ArgumentNullException(nameof(args));
            }

            for (int i = 0; i < args.Length; i++)
            {
                LogDebug(message, args[i]);
            }
        }

        public class LogMixins : BaseLogger
        {
            public override void Log(LogLevel logLevel, string message)
            {
                BaseLoggerMixins.LogError(message, logLevel);
                BaseLoggerMixins.LogWarning(message, logLevel);
                BaseLoggerMixins.LogInformation(message, logLevel);
                BaseLoggerMixins.LogDebug(message, logLevel);

                throw new System.NotImplementedException();
            }
        }

    }
}
