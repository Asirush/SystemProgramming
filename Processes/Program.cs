using System;
using System.Diagnostics;

namespace Processes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;

                    myProcess.StartInfo.FileName = "notepad.exe";
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();

                    myProcess.WaitForExit();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Console.ReadLine();
        }
    }
}