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
            Student student = new Student() { _name="Ozan",_surName ="Üstündağ"};
            Type studentType = typeof(Student);

            FieldInfo[] studentFields = studentType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (var studentField in studentFields)
            {
                Console.WriteLine("Field: " + studentField.Name);
                Console.WriteLine("Value: " + studentField.GetValue(student));
                Console.WriteLine("*************");
            }
            


        }
    }
    class Student
    {
        public string _name;
        public string _surName;
        string email;
    }
}
