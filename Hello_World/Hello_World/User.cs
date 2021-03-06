using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
    public abstract class User
    {
        public User()
        {
            Console.WriteLine("user created");
        }
        public User(string name, string surName)
        {
            Name = name; SurName = surName;

        }
        string _name ;
        string _surName;

        public bool Verified
        {
            get;
            set;
        } = false;
        public string Name { get; }
        public string SurName { get; }
        public int Age { get; set; }
      
        public string FullName {
            get 
            {
                return _name + " " + _surName;
            }
        }

        public string Output(int x)
        {
            string message = "";
            for (int i = 0; i < x; i++)
            {
              message += FullName+"\n ";
            }
            return message ;
        }
        public string Output()
        {
            return FullName ;
        }

        public  static User GetUserFromList(List<User> users, User user)
        {
            foreach (var u in users)
            {
                if (u.Equals(user))
                {
                    return u;
                }
            }
            return null;
        }
        public static void PrintUser(User user)
        {
            Console.WriteLine(user.FullName);
        }
        public static void PrintUsers(List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine(user.FullName);
            }
        }
        public static int Find(List<User> users,string fullName)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].FullName == fullName)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int Find(List<User> users,User user)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Equals(user))
                {
                    return i;
                }
            }
            return -1;
        }
        public abstract void HelloToConsole();

        public override string ToString()
        {
            return FullName;
        }
        public override bool Equals(object obj)
        {
            if (FullName==((User)obj).FullName)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return FullName.GetHashCode();
        }
        
    }
}
