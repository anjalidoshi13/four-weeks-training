using System.Diagnostics;
namespace AsyncAwaitBasics
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int numberOfTasks = 2;
            await PerformCalculations(numberOfTasks);
            Console.WriteLine($"All {numberOfTasks} tasks completed in  milliseconds.");
        }
        static async Task SimulateLongRunningTask(int delayInSeconds)
        {
            await Task.Delay(delayInSeconds * 5000);
            Console.WriteLine($" long-running task with {delayInSeconds} second delay completed.");
        }
        static async Task PerformCalculations(int numberOfTasks)
        {
            Task[] tasks = new Task[numberOfTasks];
            for (int i = 0; i < numberOfTasks; i++)
            {
                int delay = i + 1; // increase delay for each task
                tasks[i] = SimulateLongRunningTask(delay);
            }
            await Task.WhenAll(tasks);
        }
    }
}