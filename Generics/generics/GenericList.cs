using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Generics
{
    public class GenericList<T> where T : INumber<T>
    {
        public static T SumValues(List<T> values) 
        {
            return values.Aggregate((a, b) => a + b);
        }
    }
}