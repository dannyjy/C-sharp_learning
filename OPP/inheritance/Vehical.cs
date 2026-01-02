using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPP.Inheritance
{
    public class Vehicle
    {
        public int MaxSpeed { get; set; }
        public void StartEngine() => Console.WriteLine("Engine started.");
    }

    public class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }
    }

    public class Bicycle : Vehicle
    {
        // Overriding behavior because bicycles don't have engines
        public new void StartEngine() => Console.WriteLine("No engine, just start pedaling!");
    }
}