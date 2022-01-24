using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class LogFactoryTests
    {
        [TestMethod]
        public void NotNull_CreateLogger()
        {
            // Arrange
            string path = "testPath";
            // Act
            FileLogger? logger = LogFactory.CreateLogger(path);
            // Assert

            Assert.IsNotNull(logger);
        }
        [TestMethod]
        public void CreateLogger_BaseLoggerClassNameSet()
        {
            // Arrange
            string path = "testPath";
            // Act
            FileLogger? logger = LogFactory.CreateLogger(path);
            // Assert
            Assert.AreEqual(logger.ClassName, path); // we've tested its not null above, so we'll likely suppress this warning later
        }
    }
}
