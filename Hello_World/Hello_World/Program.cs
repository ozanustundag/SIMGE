using System;
using System.Linq;
using System.Collections.Generic;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a class and instantiating an object

            Program myProgram = new Program();//instantiate
            myProgram.DoSomething();        
        }
        public void DoSomething()
        {
            //ı m doing something
            User ozan = new User();
           // ozan.Name = "Ozan";
            ozan.SurName = "ustundag";
            ozan.age = 12;
            ozan.Name = "OZİ";
            Console.WriteLine(ozan.FullName);
        }
    }
}   

