// This file is no longer included in the project compile.
using System.Diagnostics;
using System.Net;

public class Program
{
    static int iterationCount = 0;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        CancellationTokenSource cancellationTokenSource = 
            new CancellationTokenSource();

        Task<int> taskDisplay = Task.Run(
            () => Display('.', cancellationTokenSource.Token)                
            );

        static void Decrement()
        {
            while (true)
            {
                Console.Write('-');
                iterationCount--;
            }
        };
        Task taskDecrement = Task.Run(Decrement);

        iterationCount--;
        Console.WriteLine("ENTER to exit");
        Console.ReadLine();
        cancellationTokenSource.Cancel();
        iterationCount = taskDisplay.Result;
        Console.WriteLine($"IterationCount = {iterationCount}");
        Console.WriteLine("Exiting!!!");
    }
    static int Display(char character, CancellationToken cancellationToken)
    {
        iterationCount = 0;
        Thread.CurrentThread.Name = "DisplayThread";
        while (!cancellationToken.IsCancellationRequested)
        {
            Console.Write(character);
            iterationCount++;
        }
        return iterationCount;
    }


    public int StartProcess(int interations)
    {
        Process process = Process.Start("ping", "google.com");
        // Other code here
        process.WaitForExit();
        return process.ExitCode;
    }


    public void DownloadFile()
    {
        WebClient webClient = new WebClient();
        Task<byte[]> task = webClient.DownloadDataTaskAsync("IntelliTect.com");

        // do other stuff here.
        task.Wait();
    }
}

