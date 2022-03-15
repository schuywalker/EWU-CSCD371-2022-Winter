using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingStuff;

public class HourGlass
{
    public Task<int> DisplayAsync(char character, 
        CancellationToken cancellationToken = default)
    {
        Task<int> taskDisplay = Task.Run(
            () => Display('.', cancellationToken)
            );
        return taskDisplay;
    }

    public int Display(char character, 
        CancellationToken cancellationToken = default)
    {
        int iterationCount = 0;
        Thread.CurrentThread.Name = "DisplayThread";
        do
        {
            Console.Write(character);
            iterationCount++;
        }
        while (!cancellationToken.IsCancellationRequested &&
            iterationCount<20000);
        return iterationCount;
    }
}
