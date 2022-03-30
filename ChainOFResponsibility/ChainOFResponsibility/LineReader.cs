using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOFResponsibility
{
    public class LineReader
    {
        public static void ReadLine()
        {
            while (true)
            {
                try
                {
                    TheGreatDivider.MaxIntDividedBy(Console.ReadLine());
                }

                catch (FormatException ex)
                {

                    Console.WriteLine("Caught:" + ex.Message);
                }
                catch(ArgumentException)
                {
                    Console.WriteLine("Enter A Number");
                }
            }
        }
    }
}
