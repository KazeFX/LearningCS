﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Packt.Shared
{
    public class Employee : Person
    {
        public string? EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public new void WriteToConsole()
        {
            WriteLine(format: "{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}",
                arg0: Name,
                arg1: DateOfBirth,
                arg2: HireDate);

        }

        public override string ToString()
        {
            return $"{Name}'s code is {EmployeeCode}";
        }
    }
}
