using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.Products
{
    internal class Product
    {
      public int productid;
      public  string productname;
      //public  double price;
        public Product(int id,string name)
        {
            productid = id;
            productname = name;
        }

        //public Product()
        //{
        //    Console.WriteLine("Product Constructor");
        //}
        public void  ProductInfo()
        {

            Console.WriteLine("Product Information");
        }
    }
}
