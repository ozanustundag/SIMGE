using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ (Language Integrated Query
            #region Data
            List<Student> students = new List<Student>()
            {
                new Student{ID=35,Name="sOzi",SurName="Yıldırım"},
                new Student{ID=46,Name="mOziş",SurName="Şimşek"},
                new Student{ID=7,Name="sOzibo",SurName="Thunder"},
                new Student{ID=9,Name="sOzo",SurName="Selami"},
                new Student{ID=3,Name="Ozer",SurName="Yıldırım"},
            };
            #endregion
            //Target = Id'si 4 ten büyük olan öğrenciler
            #region Normal C#
            //List<Student> targetList = new List<Student>();
            //foreach (Student student in students)
            //{
            //    if (student.ID > 4)
            //    {
            //        targetList.Add(student);
            //    }
            //}
            //foreach (Student item in targetList)
            //{
            //   // Console.WriteLine(item.Name + " " + item.SurName);
            //}
            #endregion
            #region LINQ
            //var query = from x in students
            //            where x.ID > 4
            //            select x;
            //foreach (var item in query)
            //{
            //   // Console.WriteLine(item.Name + " " + item.SurName);
            //}

            #endregion
            #region Lambda Expression
            //var q = students.Where(x => x.ID > 4);
            //foreach (var item in q)
            //{
            //    //Console.WriteLine(item.Name + " " + item.SurName);
            //}
            #endregion
            //Target = Adının ilk harfi s olan öğrenciler
            #region LINQ
            //var a = from y in students
            //        where y.Name.StartsWith('s')
            //        select y;
            //foreach (var item in a)
            //{
            //   // Console.WriteLine(item.Name + " " + item.SurName);
            //}
            #endregion
            #region Lamba Expression
            //var b = students.Where(z => z.Name.StartsWith('s'));
            //foreach (var item in b)
            //{
            //   // Console.WriteLine(item.Name + " " + item.SurName);
            //}

            #endregion
            // target = soyadının son harfi  m  olan öğrnciler
            #region LINQ
            //var c = from j in students
            //        where j.SurName.Last() == 'm'
            //        select j;
            //foreach (var item in c)
            //{
            //   // Console.WriteLine(item.Name + " " + item.SurName);
            //}
            #endregion
            #region Lambda Expression
            var d = students.Where(v => v.SurName.Last() == 'm');
            foreach (var item in d)
            {
               // Console.WriteLine(item.Name + " " + item.SurName);
            }
            #endregion
            //target = ıdsi 27 den küçük olan öğrenciler
            #region LINQ
            //var t = from s in students
            //        where s.ID < 27
            //        select s;
            //foreach (var item in t)
            //{
            //   // Console.WriteLine(item.Name + " " + item.SurName);
            //}

            #endregion
            #region Lambda Expression  
            var m = students.Where(q => q.ID < 27);
            foreach (var item in m)
            {
                Console.WriteLine(item.Name + " " + item.SurName + " " + item.ID);
            }
            #endregion

            var p = students.Select(i => i.ID < 27).ToList(); // oluşturlan nesnenin listee dönüşştürülmesi
            foreach (var item in p)
            {
               // Console.WriteLine(item.)  item.Name çalışmıyor ????
            }
            var a = students.Select(b => new
            {
                No = b.ID,
                name=b.Name
            }
            ) ;
            foreach (var item in a)
            {
                //Console.WriteLine(item.No + item.name);
            }
            //-----------------------------------------
            List<StudentDemo> demos = students.Select(x => new StudentDemo(x.Name, x.SurName)).ToList();
            foreach (var item in demos)
            {
               // Console.WriteLine(item.Name + " " + item.SurName);
            }
           
        }
        public class StudentDemo
        {
            public string Name { get; set; }
            public string SurName { get; set; }

            public StudentDemo()
            {

            }
            public StudentDemo(string name,string surName)
            {
                this.Name = name;
                this.SurName = surName;
            }
        }
    }
}
