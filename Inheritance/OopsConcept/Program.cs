using OopsConcept.ProductInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1,"Mobile");
            Console.WriteLine("product"); 
            Console.ReadLine(); 
            product.productInfo();
        }
    }
}
