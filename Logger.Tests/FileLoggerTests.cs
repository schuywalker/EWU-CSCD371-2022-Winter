using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestMethod]
        public void Log_FileExists()
        {
            _ = LogFactory.CreateLogger("Error");

        }

        /* [TestMethod]
         public void ConfigureFileLogger_NotConfigured_ReturnsNull()
         {
             Assert.IsNull(LogFactory.ConfigureFileLogger(() => FileLogger(null)));
             /*if (LogFactory.configured == false)
             {
                 Assert.IsNull(LogFactory());
             }
         }*/


    }
}
