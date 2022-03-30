using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oops.Products;

Product product = new Product(1, "Mobile");
ElectronicProducts electronic = new ElectronicProducts();
electronic.productname = "Television";
electronic.productid = 11;
Console.WriteLine("Product name: " +  electronic.productname);
product.ProductInfo();