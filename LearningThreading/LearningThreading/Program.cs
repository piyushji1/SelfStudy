using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LearningThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) 
            {
                Thread mythread = new Thread(new ThreadStart(Work));
                mythread.Start();
                
            }
            Console.ReadLine();
        }
        static void Work()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Work Completed");
        }
        
    }
}
