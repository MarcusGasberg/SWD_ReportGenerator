﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public interface IEmployee
    {
        string Name { get; }
        uint Salary { get; }
    }
}
