using System.Text.Json;
using OOP;

namespace OPP
{
    class Program
    {
        static void Main(String[] args)
        {
            Person p1 = new Person("John",34,"male");

            JsonSerializer.Serialize(p1);
            string fileName = "Users.json";

            // File file = new File();
        }
    }
}