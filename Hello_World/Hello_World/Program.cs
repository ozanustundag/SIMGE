using System;
using System.Linq;
using System.Collections.Generic;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //static methods -- these methods dont related with instance. you can acces them directly using dot operator.
            // class ------> obj obj.method
            //       ------> obj
            // class.method*
            User ozan = new User();
            ozan.Name = "ozi";
            ozan.SurName = "blablabla";
            //User.PrintUser(ozan);
            User sila = new User();
            sila.Name = "ayşe";
            sila.SurName = "baytar";
            List<User> users = new List<User>() { ozan,sila};
            User.PrintUsers(users);

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

