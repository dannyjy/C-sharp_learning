using System.Security.Cryptography;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] letters = new string[] { "A", "B", "C", "D", "E" };

            // Variables.AllVariablesDeclarations();
            // Console.WriteLine(BreakContinue.findIndex("B", letters));
            // Console.WriteLine(BreakContinue.SkipAnIndex("C", letters));


            DataTypes.allDataTypes();
            decimal gradePointAverage = 3.99872831m;

            Console.WriteLine($"---------------------------------------------\n{(int)gradePointAverage}");
            Console.Beep();
        }
    }
}