/*
    To declare a variable in C# you will have to use one of the data types known in C#.
    int, long, char, string, double, float, boolean
*/
namespace VariablesAndDataTypes
{
    public class Variables
    {
        public static void AllVariablesDeclarations()
        {
            int normalNumber = 9;
            long trial = 899;
            float withDotNumber = 9.99F;
            double anotherOneWithDot = 99.43;
            string name = "John Doe";
            char letter = 'D';
            bool isUnderstandable = true;

            Console.WriteLine($@"
                Interger: {normalNumber}
                Long: {trial}
                Floating: {withDotNumber}
                Double: {anotherOneWithDot}
                Name: {name}
                Charater: {letter}
                Boolean: {isUnderstandable}
            ");
        }
    }
}