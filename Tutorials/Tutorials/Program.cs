using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extension Methods

            object obj = new object();
            obj.DisplayASMInfo();
            int a = 5;
            Console.WriteLine( a.Squareee());
            List<string> list = new List<string>() { "ali0", "veli", "mehmet" };
            list.ShowList();

            


        }
    }
}
