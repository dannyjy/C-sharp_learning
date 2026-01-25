using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    public class Deserializer
    {
        public static T Deserialize<T>(string json) where T : new()
        {
            return System.Text.Json.JsonSerializer.Deserialize<T>(json);
        }
    }
}