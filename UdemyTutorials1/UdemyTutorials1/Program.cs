using System;
using System.Collections;
using System.Collections.Generic;

namespace UdemyTutorials1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static
            Product product = new Product();
            Product product1 = new Product();
            Console.WriteLine(Product.StaticMethod());
            Console.WriteLine(product.normalMethod());
            Console.WriteLine(product1.normalMethod());

            Product product2 = new Product();
            Product product3 = new Product();
            Console.WriteLine(product2.normalMethod());
            Console.WriteLine(product3.normalMethod());

            Console.WriteLine(Product.StaticMethod());


        //    Static_Product static_Product = new Static_Product();//static class ın nesne örneğini oluşturamam.

        }
    }
}
