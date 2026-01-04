using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPP.Polymorphism
{
    public class Animal
    {
        public virtual void Speak() => Console.WriteLine("Animal makes a sound.");
    }

    public class Dog : Animal
    {
        public override void Speak() => Console.WriteLine("Bark!");
    }

    public class Cat : Animal
    {
        public override void Speak() => Console.WriteLine("Meow!");
    }
}