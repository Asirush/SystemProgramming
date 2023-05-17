using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RandNumGenerator
{
    internal class Thread1
    {
        public static void thread1()//first thread
        {
            for (int i = 0; i < 10; i++)                          //for loop to execute the process and print 10 fibonacci numbers in order
            {
                FibonachiSeries.CreateFibSeries();                              //here the function is called
                Console.Write(" " + Container.fibseries[i]);   //in order to print the fibonacci listed numbers I wrote this line. It puts a space between each number everytime.
                Thread.Sleep(500);                            //with this method the program pauses for 0.5 seconds everytime the program prints. 500 miliseconds.
            }
        }
    }
}
