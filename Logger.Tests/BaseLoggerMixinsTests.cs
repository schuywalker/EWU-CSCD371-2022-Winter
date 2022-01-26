using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Logger.Tests
{
    [TestClass]
    public class BaseLoggerMixinsTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Error_WithNullLogger_ThrowsException()
        {
            // Arrange

            // Act
            //BaseLoggerMixins.LogError(null, "");

            // Assert
        }

        [TestMethod]
        public void Error_WithData_LogsMessage()
        {
            // Arrange
            var Logger = new TestLogger();

            // Act
            Logger.LogError("Message {0}", 42);

            // Assert
            Assert.AreEqual(1, Logger.LoggedMessages.Count);
            Assert.AreEqual(LogLevel.Error, Logger.LoggedMessages[0].LogLevel);
            Assert.AreEqual("Message 42", Logger.LoggedMessages[0].Message);
        }

    }

    public class TestLogger : BaseLogger
    {
        public List<(LogLevel LogLevel, string Message)> LoggedMessages { get; } = new List<(LogLevel, string)>();

        public override void Log(LogLevel logLevel, string message)
        {
            LoggedMessages.Add((logLevel, message));
        }
    }
}// Assert.AreEqual<INSERT DATA TYPE>(...)
