using System;
using System.Linq;
using System.Collections.Generic;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //Searching a List for Custom Object
            User ozan = new User();
            User ali = new User();
            User aleyna = new User();
            ozan.Name = "ozan";
            ozan.SurName = "ustundag";
            ali.Name = "adsasd";
            ali.SurName = "asdasd";
            aleyna.Name = "aleyna";
            List<User> users = new List<User>() { aleyna, ozan, ali };
           Console.WriteLine( User.Find(users, "ozan ustundag"));


        }
        public void DoSomething()
        {
            List<string> firstNames = new List<string>() { "ozan", "kadir", "ömer" };
            List<string> lastNNames = new List<string>() { "karadağ", "belçika", "kanada" };
            List<User> users = new List<User>();
            for (int i = 0; i <firstNames.Count; i++)
            {
                User user = new User();
                user.Name = firstNames[i];
                user.SurName = lastNNames[i];
                users.Add(user);
                //Console.WriteLine(user.FullName);
            }
        }
        public void TakeUser(User user)
        {
            user = new User();
            user.Name = "selami";
            Console.WriteLine(user.FullName);
        }
    }
}   

