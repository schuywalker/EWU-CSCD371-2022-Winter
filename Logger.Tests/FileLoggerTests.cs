using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        
         /////// test file path
        [TestMethod]
        public void Log_FileExists()
        {
            string fileName = "file.txt";
            File.Delete(fileName); // deletes file if it exists. no exception thrown otherwise

            LogFactory logFactory = new();
            logFactory.ConfigureFileLogger(fileName);
            BaseLogger logger = logFactory.CreateLogger(nameof(FileLogger))!;

            FileLogger FLLogger = (FileLogger)logger;// cast logger from BaseLogger to FilePath
            Assert.AreEqual((FLLogger).FilePath, "file.txt");

        }
        /*
         [TestMethod]
         public void ConfigureFileLogger_NotConfigured_ReturnsNull()
         {
             Assert.IsNull(LogFactory.ConfigureFileLogger(() => FileLogger(null)));
             /*if (LogFactory.configured == false)
             {
                 Assert.IsNull(LogFactory());
             }
         }

        */
    }
}
