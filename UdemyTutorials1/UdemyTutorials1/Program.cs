using System;
using System.Collections;
using System.Collections.Generic;

namespace UdemyTutorials1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract //sealed
            // abstract bu classların görevi diğer sınıflara miras vermektir. nesne örneği oluşturulamaz.
            // selaed lanmış classlar miras verilemez
            //abstract metotlar kesinlikle ezilmesi gerekiyor
            Student ozan = new Student("ozan","üstündağ",5);
            //ozan.Name = "OZAN";
            //ozan.SurName = "kayseri";
            //ozan.Age = 5;
            Teacher kemal = new Teacher("tesla", "ediosn", 5);
            {
                //Name = "Mustafa kemal",
                //SurName = "Atatürk",
                //Salary = 5
            };
            List<Person> schoolMembers = new List<Person>() { ozan, kemal };
            Console.WriteLine(kemal.Name + " " + kemal.SurName + " " + kemal.Salary +"Bus Price:"+kemal.BusTicketPrice());

            Console.WriteLine(ozan.Name + " "+ozan.SurName +" "+ ozan.Age + "Bus Price:" + ozan.BusTicketPrice());
        }
    }
}
