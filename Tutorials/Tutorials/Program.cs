using System;

namespace Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref and out parameters
            // bu parametreler value type ların değerlerinin metot içerisinde değiştirilmesine yarıyor.

            int number = 5;
            int numberOut ;

            Console.WriteLine("Before Param:" + number);
            Param(number);
            Console.WriteLine("Afer Param:" + number);
            //--------------------------------------------------
            Console.WriteLine("Before ParamOut:" + 0);
            ParamOut(out numberOut);
            Console.WriteLine("Afer ParamOut:" + numberOut);
            //--------------------------------------------------
            Console.WriteLine("Before ParamRef:" + numberOut);
            ParamRef(ref numberOut);
            Console.WriteLine("Afer ParamRef:" + numberOut);

        }

        static void Param(int x)
        {
            x = x * 2;
        }
        static void  ParamOut(out int x)
        {
            x = 2; // out değer atamayı zorunlu kılıyor meteto içerisinde.
        }
        static void ParamRef(ref int x)
        {
            x = x+ 8;
        }
    }
}
