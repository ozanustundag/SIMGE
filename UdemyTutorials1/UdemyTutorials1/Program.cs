using System;
using System.Collections;
using System.Collections.Generic;

namespace UdemyTutorials1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface
            //fieldları olmaz
            Student ozan = new Student("ozan","üstündağ",5);
            Engineer elon = new Engineer();
            Teacher kemal = new Teacher("tesla", "ediosn", 5);
       
            List<Person> schoolMembers = new List<Person>() { ozan, kemal };
            Console.WriteLine(kemal.Name + " " + kemal.SurName + " " + kemal.Salary +"Bus Price:"+kemal.BusTicketPrice());

            Console.WriteLine(ozan.Name + " "+ozan.SurName +" "+ ozan.Age + "Bus Price:" + ozan.BusTicketPrice());
            List<ISchoolMember> schoolMembers1 = new List<ISchoolMember>() { ozan, kemal /*elon*/ };//elon eklersem hata veriyor
        }
    }
}
