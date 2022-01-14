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
            User ozan = new User();

            ozan.SurName = "ustundag";
            ozan.age = 12;
            ozan.Name = "OZİ";

            User aslı = new User();

            aslı.Name = "aslı";
            aslı.SurName = "cringe";

            List<User> users = new List<User>();
            users.Add(ozan); users.Add(aslı);

            foreach (User usersInfo in users)
            {
                Console.WriteLine(usersInfo.FullName);
            }

        }
    }
}   

