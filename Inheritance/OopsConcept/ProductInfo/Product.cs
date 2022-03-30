using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.ProductInfo
{
    
    public class Product
    {
        public int productId;
        public string productName;
        public Product(int Id,string Name)
        {
            productId = Id;
            productName = Name;
           

        }
        public void productInfo()
        {
            Console.WriteLine("Product Information");
        }
    }
}
