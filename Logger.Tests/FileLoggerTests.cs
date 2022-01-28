using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {

        string fileName = "file.txt";
        string message = "message";
        BaseLogger? logger;

        

        [TestInitialize]
        public void testInit()
        {
            LogFactory logFactory = new();
            logFactory.ConfigureFileLogger(fileName);
            logger = logFactory.CreateLogger(nameof(FileLoggerTests));
        }
        [TestCleanup]
        public void testCleanUp()
        {
            File.Delete(fileName);
        }

        [TestMethod]
        public void Log_FileExists()
        {
            //string fileName = "file.txt";
            //File.Delete(fileName); // deletes file if it exists. no exception thrown otherwise

            
            //logFactory.ConfigureFileLogger(fileName);
            //BaseLogger logger = logFactory.CreateLogger(nameof(FileLogger))!;

            FileLogger FLLogger = (FileLogger)logger!;// cast logger from BaseLogger to FilePath
            Assert.AreEqual((FLLogger).FilePath, "file.txt");

        }
        
    }
}
