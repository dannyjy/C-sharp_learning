using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.generics
{
    public class Max
    {
        public T GetMax<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}