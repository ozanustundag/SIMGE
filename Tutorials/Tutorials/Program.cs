using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;

namespace Tutorials
{
    class Program 
    {
        static void Main (string[] args)
        {
            //delegate

            Calculate calculate = new Calculate(Product);
            Console.WriteLine(calculate(5, 4));
            calculate = Sum;
            Console.WriteLine(calculate(5, 4));
      

        }   
        delegate int Calculate(int x, int a);
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Product(int a,int b)
        {
            return a * b;
        }



    }
}
