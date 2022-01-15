using System;
namespace Hello_World
{
    public class Teacher : User
    {
        public Teacher(string name , string surName)
        {
            Name =name; SurName = surName;

        }

        public override void HelloToConsole()
        {
            Console.WriteLine("Hi I m teacher, my name is" + Name);
        }
    }
}
