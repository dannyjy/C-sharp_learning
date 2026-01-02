using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPP.Inheritance
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public void ClockIn() => Console.WriteLine($"{Name} clocked in.");
    }

    public class Manager : Employee
    {
        public int TeamSize { get; set; } // Specific to Managers
    }

    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; } // Specific to Developers
    }
}