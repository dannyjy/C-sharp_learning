// using FetchingData.FetchTasks;
// https://jsonplaceholder.typicode.com/todos/1

namespace FetchingData
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await Todos.GetTodosAsync();
            await Users.GetUsersAsync();
            GetSystemDetail();
        }


        public static void GetSystemDetail()
        {
            Console.WriteLine($"Machine Name: {Environment.MachineName}");
            Console.WriteLine($"Machine Name: {Environment.CommandLine}");
            Console.WriteLine($"OS Version: {Environment.OSVersion}");
            Console.WriteLine($"OS Description: {System.Runtime.InteropServices.RuntimeInformation.OSDescription}");
            Console.WriteLine($"Processor Count: {Environment.ProcessorCount}");
            Console.WriteLine($"64-bit OS: {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"User Name: {Environment.UserName}");
            Console.WriteLine($"System Directory: {Environment.SystemDirectory}");
            Console.WriteLine($"Working Set (Memory): {Environment.WorkingSet} bytes");
        }
    }
}