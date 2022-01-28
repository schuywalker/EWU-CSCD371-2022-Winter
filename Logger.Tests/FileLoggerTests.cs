using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;



namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {

        string fileName = "file.txt";
        string message = "test message";
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
        public void Log_FilePathIsAsIntended_Success()
        { 
            FileLogger FLLogger = (FileLogger)logger!;// cast logger from BaseLogger to FilePath
            Assert.AreEqual((FLLogger).FilePath, fileName);

        }
        [TestMethod]
        public void Log_MessageIsCorrect_Success()
        {

            FileLogger FLLogger = (FileLogger)logger!;
            FLLogger.Log(logLevel: LogLevel.Error, message);
            string[] logAppend = File.ReadAllText(fileName).Split("\n");
           
            string expectedMessageLine1 = FLLogger.dateTime.ToString();
            string expectedMessageLine2 = this.GetType().Name;
            string expectedMessageLine3 = "Error";
            string expectedMessageLine4 = message;
           
            Assert.AreEqual<string>(expectedMessageLine1, logAppend[0]);
            Assert.AreEqual<string>(expectedMessageLine2, logAppend[1]);
            Assert.AreEqual<string>(expectedMessageLine3, logAppend[2]);
            Assert.AreEqual<string>(expectedMessageLine4, logAppend[3]);

            
        }


    }
}
