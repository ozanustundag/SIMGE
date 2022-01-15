using System;
namespace Hello_World
{
    class Student : User
    {

        public override void HelloToConsole()
        {
            Console.WriteLine("hello ı m student, my name is " + Name);
        }
    }
}
