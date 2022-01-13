using System;

namespace Hello_World 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            //int a = -5;
            //int b = a;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //b = -10;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int[] a = { -5 };
            //int[] b = a;

            //Console.WriteLine(a[0]);
            //Console.WriteLine(b[0]);

            //b[0] = 1;

            //Console.WriteLine(a[0]);
            //Console.WriteLine(b[0]);
            int a = 5;
            int[] b = { 5 };

            Test(a,b);
            Console.WriteLine(a + " " + b[0] );






        }

        static void Test(int x, int[] y)
        {
            x = 100;
            y[0] = 100;
        }
            
    }
}
