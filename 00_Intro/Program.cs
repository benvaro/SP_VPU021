using System;
using System.Diagnostics;

namespace _00_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new Process();
            //process.StartInfo = new ProcessStartInfo("calc.exe");
            //process.Start();
            //ShowInfo(process);

            //process = Process.Start("notepad.exe");

            ////Thread.Sleep(6000);
            ////process.Kill();

            //foreach (var item in Process.GetProcesses()
            //    .Where(x => x.ProcessName.StartsWith("n", StringComparison.InvariantCultureIgnoreCase)))
            //{
            //    ShowInfo(item);
            //}
            //var pid = int.Parse(Console.ReadLine());
            //process = Process.GetProcessById(pid);
            //process.Kill();

            ShowInfo(Process.GetCurrentProcess());
        }

        private static void ShowInfo(Process process)
        {
            Console.WriteLine($"Process ID: {process.Id}");
            //Console.WriteLine($"Process Machine: {process.MachineName}");
            //Console.WriteLine($"Process Module: {process.MainModule}");
            //Console.WriteLine($"Process BasePriority: {process.BasePriority}");
            Console.WriteLine($"Process ProcessName: {process.ProcessName}");
            try
            {
                foreach (ProcessModule item in process.Modules)
                {
                    try
                    {
                        Console.WriteLine("\t" + item.FileName);
                    }
                    catch { }
                }
            }
            catch
            {

            }
            Console.WriteLine();
        }
    }
}
