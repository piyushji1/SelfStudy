using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    var person = new Person();
            //    person.Name = null;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();
            Console.WriteLine("Connected to Database");

            try
            {
                throw new Exception("error while accessing database resource");
            }
            
            finally
            {
                Console.WriteLine("Disconnecting Database");
            }
            Console.ReadLine();
        }
    }
}
