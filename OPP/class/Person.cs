
using System.Security.Cryptography;

namespace OOP
{
    class Person
    {
        public string? name;
        public int age;
        public string? gender;
        
        public Person(string? Name,int Age,string? Gender)
        {
            name = Name;
            age = Age;
            gender = Gender;
        }

        public string GetInfo()
        {
            return @$"
            Name: {name}
            Age: {age}
            Gender: {gender}
            ";
        }
    }
}