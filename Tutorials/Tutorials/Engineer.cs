﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    class Engineer:Worker
    {


        public override int Salary()
        {
            return base.Salary()*3;
        }
    }
}
