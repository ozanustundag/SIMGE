using System;
using System.Collections;
using System.Collections.Generic;

namespace UdemyTutorials1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ozan = new Student();
            ozan.Name = "OZAN";
            ozan.SurName = "kayseri";
            ozan.Age = 5;
            Console.WriteLine(ozan.Name + " "+ozan.SurName +" "+ ozan.Age);
        }
    }
}
