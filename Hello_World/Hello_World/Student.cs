using System;
namespace Hello_World
{
    class Student : User
    {
        public Student()
        {
            Console.WriteLine("student created");
        }

        public Student(string name , string surName)
        {
            Name = name; SurName = surName;
        }

        public override void HelloToConsole()
        {
            Console.WriteLine("hello ı m student, my name is " + Name);
        }
    }
}
