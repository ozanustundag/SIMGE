using System;
using System.Collections;
using System.Collections.Generic;

namespace UdemyTutorials1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance
            Student ozan = new Student();
            ozan.Name = "OZAN";
            ozan.SurName = "kayseri";
            ozan.Age = 5;
            Teacher kemal = new Teacher()
            {
                Name = "Mustafa kemal",
                SurName = "Atatürk",
                Salary = 5
            };
            Console.WriteLine(kemal.Name + " " + kemal.SurName + " " + kemal.Age);

            Console.WriteLine(ozan.Name + " "+ozan.SurName +" "+ ozan.Age);
        }
    }
}
