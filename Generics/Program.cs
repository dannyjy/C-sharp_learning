using Generics.generics;

namespace Generics;
class Program
{
    // Reference Type,where T : class,"T must be a class, interface, or delegate."
    class ReferenceTypeExample<T> where T : class {}
    // Value Type, where T : struct,"T must be a non-nullable value type (like int, bool)."
    class ValueTypeExample<T> where T : struct {}
    // Constructor,where T : new (),T must have a public parameterless constructor.
    class ConstructorExample<T> where T : new() {}
    // Base Class,where T : BaseClass, T must be or inherit from BaseClass.
    class BaseClassExample<T> where T : Product {}
    // Interface,where T : IMyInterface, T must implement IMyInterface.
    class InterfaceExample<T> where T : ISpecification<Product> {}

    static void Main(string[] args)
    {
        var intBox = new Box<int> { Content = 123 };
        var strBox = new Box<string> { Content = "Hello" };
        Console.WriteLine($"Int Box contains: {intBox.Content}");
        Console.WriteLine($"String Box contains: {strBox.Content}");

        SwapValues<int>.Swap(10, 20);
        int sum = GenericList<int>.SumValues(new List<int> { 1, 2, 3, 4, 5 });
        Console.WriteLine($"The Sum using the generics is {sum}");

        var cacheService = new CacheService<int>();
        cacheService.Store("one", 1);
        int value = cacheService.Retrieve("one");
    }
}