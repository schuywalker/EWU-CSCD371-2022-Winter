using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Lecture.Tests;

[TestClass]
public class DisposableTests
{
    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void UsingStatements()
    {
        using Stream stream = new MemoryStream();
        throw new InvalidOperationException();
    }
}
