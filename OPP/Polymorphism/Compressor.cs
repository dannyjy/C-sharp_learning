using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPP.Polymorphism
{
    public class Compressor
    {
        public virtual void Compress() => Console.WriteLine("Standard compression.");
    }

    public class ZipCompressor : Compressor
    {
        public override void Compress() => Console.WriteLine("Applying ZIP algorithm.");
    }

    public class RarCompressor : Compressor
    {
        public override void Compress() => Console.WriteLine("Applying RAR algorithm.");
    }
}