using System;

namespace Hello_World // nameSpace - used for organization
{
    class Program // class - has memembers(such as methods)
    {
        static void Main(string[] args) // a method - contains a block of code
        {
            Program myProgram = new Program();
            myProgram.Print();
            Console.WriteLine(args[0]);
            // name space -> class -> members -> method -> statement
        }
         void Print()
        {
            System.Console.WriteLine("Fully Named"); // fully named
            Console.WriteLine("Hello World!"); // a statement
            Console.WriteLine("Ozan Ustundag"); // a statement
        }
        
    }
}
