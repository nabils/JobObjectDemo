using System;
using System.Diagnostics;

namespace JobObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var process =
                Process.Start(
                    @"C:\Users\Nabil Shuhaiber\Documents\Dev\BlockingProcess\BlockingProcess\bin\Debug\BlockingProcess.exe");

            var job = new Job();
            job.AddProcess(process.Id);

            Console.WriteLine("Running... Press key to kill");
            Console.ReadLine();
        }
    }
}
