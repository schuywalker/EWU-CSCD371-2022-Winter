using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class LogFactoryTests
    {
        [TestMethod]
        public void CreateLogger_ConfigureWithNull_Success()
        {
            // Arrange
            LogFactory? logFactory = new();
            BaseLogger? logger = logFactory.CreateLogger(nameof(LogFactoryTests));
            // Act

            // Assert

            Assert.IsNull(logger);
        }
        [TestMethod]
        public void CreateLogger_ConfigureWithPath_Success()
        {
            // Arrange
            LogFactory logFactory = new();
            logFactory.ConfigureFileLogger("file.txt");
            BaseLogger? logger = logFactory.CreateLogger(nameof(LogFactoryTests));
            // Act
            
            // Assert
            Assert.IsNotNull(logger); // we've tested its not null above, so we'll likely suppress this warning later
        }

    }
}
