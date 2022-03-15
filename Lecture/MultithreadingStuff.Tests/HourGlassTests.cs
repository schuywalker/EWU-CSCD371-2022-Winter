using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingStuff.Tests;
[TestClass]
public class HourGlassTests
{
    public TestContext? TestContext { get; set; }
    [TestMethod]
    public void CallDisplayAsync()
    {
        Task task = DisplayAsync();
        // While the thread is executing
        task.Wait();
        // After thread completes.

    }

    async public Task DisplayAsync()
    {
        
        CancellationTokenSource cancellationTokenSource = 
            new CancellationTokenSource();

        HourGlass hourGlass = new HourGlass();
        int iterationCount = 
            await hourGlass.DisplayAsync('.', cancellationTokenSource.Token);
        cancellationTokenSource.Cancel();
        Assert.IsTrue(iterationCount > 0);
        int counter = 0;
        TestContext?.WriteLine($"{counter++}");
        TestContext?.WriteLine($"{counter++}");
        TestContext?.WriteLine($"{counter++}");
        TestContext?.WriteLine($"{counter++}");
    }

    async public Task DisplayTaskAsync()
    {
        // ThreadId 1
        CancellationTokenSource cancellationTokenSource =
            new CancellationTokenSource();

        HourGlass hourGlass = new HourGlass();
        Task<int> task =
            hourGlass.DisplayAsync('.', cancellationTokenSource.Token);
        // Thread 1
        // Timer avoid not waiting too long.
        // The user pressed ENTER
        cancellationTokenSource.Cancel();

        int iterationCount = await task.WaitAsync(default(CancellationToken));
        // Thread ?
        //Assert.IsTrue(iterationCount > 0);
        int counter = 0;
        TestContext?.WriteLine($"{counter++}");
        TestContext?.WriteLine($"{counter++}");
        TestContext?.WriteLine($"{counter++}");
        TestContext?.WriteLine($"{counter++}");
        iterationCount = task.Result;
        // A bunch more logic
    }
}