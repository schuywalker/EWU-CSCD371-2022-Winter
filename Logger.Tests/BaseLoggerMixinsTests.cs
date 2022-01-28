using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Logger.Tests
{
    [TestClass]
    public class BaseLoggerMixinsTests
    {
        string message = "MixinsTests message";

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Error_WithNullLogger_ThrowsException()
        {
            // Arrange

            // Act
            BaseLoggerMixins.LogWarning(null, "");

            // Assert
            //Assert.ThrowsException<ArgumentNullException>(BaseLoggerMixins.LogError(null, message))
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Warning_WithNullLogger_ThrowsException()
        {
            // Arrange

            // Act
            BaseLoggerMixins.LogWarning(null, "");

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Information_WithNullLogger_ThrowsException()
        {
            // Arrange

            // Act
            BaseLoggerMixins.LogInformation(null, "");

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Debug_WithNullLogger_ThrowsException()
        {
            // Arrange

            // Act
            BaseLoggerMixins.LogDebug(null, "");

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
            Assert.AreEqual<int>(1, Logger.LoggedMessages.Count);
            Assert.AreEqual(LogLevel.Error, Logger.LoggedMessages[0].LogLevel);
            Assert.AreEqual<string>("Message 42", Logger.LoggedMessages[0].Message);
        }

        [TestMethod]
        public void Warning_WithData_LogsMessage()
        {
            // Arrange
            var Logger = new TestLogger();

            // Act
            Logger.LogWarning("Message {0}", 42);

            // Assert
            Assert.AreEqual<int>(1, Logger.LoggedMessages.Count);
            Assert.AreEqual(LogLevel.Warning, Logger.LoggedMessages[0].LogLevel);
            Assert.AreEqual<string>("Message 42", Logger.LoggedMessages[0].Message);
        }

        [TestMethod]
        public void Information_WithData_LogsMessage()
        {
            // Arrange
            var Logger = new TestLogger();

            // Act
            Logger.LogInformation("Message {0}", 42);

            // Assert
            Assert.AreEqual<int>(1, Logger.LoggedMessages.Count);
            Assert.AreEqual(LogLevel.Information, Logger.LoggedMessages[0].LogLevel);
            Assert.AreEqual<string>("Message 42", Logger.LoggedMessages[0].Message);
        }

        [TestMethod]
        public void Debug_WithData_LogsMessage()
        {
            // Arrange
            var Logger = new TestLogger();

            // Act
            Logger.LogDebug("Message {0}", 42);

            // Assert
            Assert.AreEqual<int>(1, Logger.LoggedMessages.Count);
            Assert.AreEqual(LogLevel.Debug, Logger.LoggedMessages[0].LogLevel);
            Assert.AreEqual<string>("Message 42", Logger.LoggedMessages[0].Message);
        }

    }
    
    public class TestLogger : BaseLogger
    {
        public List<(LogLevel? LogLevel, string Message)> LoggedMessages { get; } = new List<(LogLevel?, string)>();

        public override void Log(LogLevel? logLevel, string message)
        {
            (LogLevel? logLevel, string message) p = (logLevel, message);
            LoggedMessages.Add(p);
        }
    }
}
    