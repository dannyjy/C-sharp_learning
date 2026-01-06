using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPP.Interface
{
    public interface IPrintable
    {
        void Print();
    }

    public class Invoice : IPrintable
    {
        public void Print() => Console.WriteLine("Printing Invoice #001...");
    }

    public class Photo : IPrintable
    {
        public void Print() => Console.WriteLine("Printing 4x6 Glossy Photo...");
    }
}