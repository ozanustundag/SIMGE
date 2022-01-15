using System;
namespace Hello_World
{
    public class Teacher : User
    {
        public override void HelloToConsole()
        {
            Console.WriteLine("Hi I m teacher, my name is" + Name);
        }
    }
}
