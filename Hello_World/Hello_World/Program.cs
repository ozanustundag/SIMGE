using System;

namespace Hello_World 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            string name = "ozan";
            name += "ustundag";
            char[] chracters = { 'h', 'e', 'l', 'l', 'o' };
            string greeting = new string(chracters);
            Console.WriteLine(greeting);

            string message = $"Hello, my name is {name}, and ı want to say {greeting}";
            Console.WriteLine(message);
            





        }


            
    }
}
