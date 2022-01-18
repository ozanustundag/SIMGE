using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;

namespace Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reflection 
            /*Reflection Nedir?
             Reflection bize hakkında bilgi sahibi olmadığımız programatik nesnelerle 
            ilegli çalışma zamnında (run-time) bilgi alabilmemizi sağlayan bir yöntemdir.
            Örneğin programın çalışma anında farklı bir dll dosyasınu uygulama içerisine dahil
            ederek içerisindeki meot ve dışarı açık nesnleri kulallanabilmemizi sağlar.
             */
            User user = new User() { ID = 54, Name_k = "Ozan" };
            var props = user.GetType().GetProperties();
            foreach (var item in props)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.GetValue(user));
            }
            var prop1 = user.GetType().GetProperty("ID");
            Console.WriteLine( prop1.Name);
            Console.WriteLine(prop1.GetValue(user));


        }
        public class User
        {
            public int ID { get; set; }
            public string Name_k { get; set; }
        }




          
    }
    
}
