using System;
using System.Data;

namespace Tutorials
{
    class Program 
    {
        //Virtual/Override
        static void Main (string[] args)
        {
            Worker ozan = new Worker();
            ozan.Name = "ozan";
            ozan.SurName = "üstündağ";
            Engineer tesla = new Engineer();
            tesla.Name = "tesla";
            tesla.SurName = "yılmaz";
            Console.WriteLine(tesla.ToString() + tesla.Salary());
            Console.WriteLine(ozan.ToString() + ozan.Salary());


        }
        
        
        


    }
}
