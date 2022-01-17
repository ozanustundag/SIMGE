using System;
using System.Data;
using PATA = ProjectA.TeamA;
using PBTA= ProjectB.TeamA;

namespace Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //NameSpace

            PATA.A a = new PATA.A();
            a.Print();
        }
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class A
        {
            public void Print()
            {
                Console.WriteLine("Project A - TEAM A - CLASS A");
            }
        }
        class B
        {
            public void Print()
            {
                Console.WriteLine("Project A - TEAM A - CLASS B");
            }
        }
    }
    namespace TeamB
    {
        class A
        {
            public void Print()
            {
                Console.WriteLine("Project A - TEAM B - CLASS A");
            }
        }
        class B
        {
            public void Print()
            {
                Console.WriteLine("Project A - TEAM A - CLASS B");
            }
        }
    }
}
namespace ProjectB
{
    namespace TeamA
    {
        class A
        {
            public void Print()
            {
                Console.WriteLine("Project B - TEAM A - CLASS A");
            }
        }
        class B
        {
            public void Print()
            {
                Console.WriteLine("Project B - TEAM A - CLASS B");
            }
        }
    }
}
