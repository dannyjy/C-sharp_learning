using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FetchingData
{
    public class SystemInfo
    {
        public static void GetSystemDetail()
        {
            Console.WriteLine($"Machine Name: {Environment.MachineName}");
            Console.WriteLine($"Command Line: {Environment.CommandLine}");
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