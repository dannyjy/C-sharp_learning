namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // To create strings in C#, We use the string keyword.

            string name = "John Doe";
            string value = "John Doe";
            Console.WriteLine(value.Length);

            for (int i = 0; i < name.Length; i++)
            {

            }

            
            // We can use built in methods to perform certain tasks

            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.GetHashCode());
            Console.WriteLine(name.Split(" "));
            
        }
    }
}