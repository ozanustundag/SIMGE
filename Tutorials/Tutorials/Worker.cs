using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    abstract class Worker
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public string Job { get; set; }

        abstract public int Salary();
      
        //public override string ToString()
        //{
        //    return Name + SurName;
        //}
    }
}
