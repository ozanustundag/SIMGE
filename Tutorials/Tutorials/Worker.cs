using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    class Worker
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public string Job { get; set; }

        virtual public int Salary()
        {
            return 1300;
        }
        public override string ToString()
        {
            return Name + SurName;
        }
    }
}
