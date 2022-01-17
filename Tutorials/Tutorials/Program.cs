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
        static void Main (string[] args)
        {

            //  Dynamic Programming

            //dynamic a = 5;
            //Console.WriteLine(a);
            //a = "aa";
            //Console.WriteLine(a);

            //dynamic people = new ExpandoObject();
            //people.Name = "Ozi";
            //people.SurName = "Üstündağ";
            //Console.WriteLine(people.Name + " " + people.SurName);

            dynamic people = new ExpandoObject();
            people.Name = "Ozark";
            people.SurName = "kalander";
            people.ShowName = new Action(() =>
            {
                Console.WriteLine("Name: " + people.Name); 
            }
            );
            people.Repeat = new Func<string, string>(input =>
             {
                 return input;
             });
            //Çalıştırma işlemleri
            //people.ShowName();

            //dynamic result = people.Repeat("multi repeat");
            //Console.WriteLine(result);
            foreach (dynamic item in GetList())
            {
                Console.WriteLine("{0}{1}",item.Name,item.Idd );
            }

        }

        private static IEnumerable<dynamic> GetList()
        {
            List<User> users = new List<User> { new User() { FullName = "ozan Üstündağ", Id = 99 },
            new User() { FullName = "kamil Üstündağ", Id = 99 }};
            return from k in users
                   select new {Name=k.FullName, Idd=k.Id};
        }
        
     
    }
    class User
    {
        public string FullName { get; set; }
        public int Id { get; set; }
    }
}
