using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ConsoleGenerator
{
    class Program
    {
        class Container
        {
            // A container class acts as a generic holder. Define a list to hold fibonacci numbers.
            public static List<int> fibseries = new List<int>();
            //In all methods below, we can reach this list by using Container.fibseries

        }

        public static void CreateFibSeries()
        //This method is used to create a list including first 10 elements of fibonacci series
        {
            int i;
            //Add first to elements of fibonacci series 0 and 1 to the list.
            Container.fibseries.Add(0);
            Container.fibseries.Add(1);
            //Starting from 2nd index, insert the other elements of fibonacci in the list.
            for (i = 2; i < 10; ++i)
                Container.fibseries.Insert(i, Container.fibseries[i - 1] + Container.fibseries[i - 2]);
        }

        public static void thread1()//first thread
        {
            /*    
            Call the method to create a list of Fibonacci elements: CreateFibSeries();
            Output the content of the list. (wait for half a second (0.5 seconds) before showing each element on the Console)
            */
            Console.Write("Fibonacci Series = ");                  //prints the title
            for (int i = 0; i < 10; i++)                          //for loop to execute the process and print 10 fibonacci numbers in order
            {
                CreateFibSeries();                              //here the function is called
                Console.Write(" " + Container.fibseries[i]);   //in order to print the fibonacci listed numbers I wrote this line. It puts a space between each number everytime.
                Thread.Sleep(500);                            //with this method the program pauses for 0.5 seconds everytime the program prints. 500 miliseconds.
            }
        }

        static void Main(string[] args)
        {
            /*
            Create two threads as t1 and t2 to run methods thread1 and thread2, respectively. Start t1. Then, suspend the main thread for 10 seconds (In other words, your program will wait for 10 seconds). After that, start t2.
            */
            thread1();             //thread1() is run. prints fibonacci numbers with 0.5 seconds between each time it outputs
            Thread.Sleep(10000);  // pauses program for 10 seconds
            Console.WriteLine(); // inserts a new line after thread1()
            //thread2() is run. prints fibonacci numbers in reverse order with 0.5 seconds between each time it outputs
            Console.ReadKey(); // the program stops
        }
    }
}