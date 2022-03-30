using Piyush.Product;

Product product = new Product(100,"Mobile");
Electronic electronic = new Electronic();
electronic.productname= "Television";
product.PublicInfo();
    
Console.WriteLine("Product name: " + electronic.productname);

