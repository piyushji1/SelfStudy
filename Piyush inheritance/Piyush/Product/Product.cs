using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piyush.Product
{
    public class Product
    {
        public int productid;
        public string productname;
        //string productdescription;
        public Product(int ID,string Name)
        {
            productid = ID;
            productname = Name;
            //Console.WriteLine("My Product");
        }
        public Product()
        {
            Console.WriteLine("Product info");
        }
        public void PublicInfo()
        {
            Console.WriteLine("Product Information");
        }
    }
}
