using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.generics
{
    public class SwapValues<TName>
    {
        public static void Swap(TName v1, TName v2)
        {
            Console.WriteLine($"Before: {v1} {v2}");
            TName temp = v1;
            v1 = v2;
            v2 = temp;
            Console.WriteLine($"After: {v1} {v2}");
        }
    }
}