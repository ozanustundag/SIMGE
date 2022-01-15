﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Hello_World
{
    class Program
    {
        public static object user { get; private set; }

        static void Main(string[] args)
        {
            // Inherit and Override Methods

            User ozan = new User();
            ozan.Name = "ozan";
            ozan.SurName = "belçika";

            User asli = new User();
            asli.Name = "ozan";
            asli.SurName = "asli";

           
            List<User> users = new List<User>() { ozan, asli };
            User search = new User();
            search.Name = "ozan";
            search.SurName = "belçika";

            Student george = new Student();
            george.Name = "george";

            george.HelloToConsole();
          
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

