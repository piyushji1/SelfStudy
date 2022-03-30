using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningNulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int? s = 1;// "hello";
            //int str = s ?? 2;
            //Console.WriteLine(str);
            //Console.ReadLine();

            //////***** for String
            //String s = null;// "Hello";
            //String str = s ?? "Default";
            //Console.WriteLine(str);


            Person person = new Person(); //{ Name = "Tim"};
            
           
             Console.WriteLine(person?.Name??"Not Set");
            Console.ReadLine();
        }
    }
}
