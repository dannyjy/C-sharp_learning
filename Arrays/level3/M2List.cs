using System.Linq.Expressions;

namespace Arrays
{
    public class M2List
    {
        public static void M2Top10()
        {
            // Qn1
            List<int> userNumbers = new List<int>();
            // string? input = "";

            // while(input != "done")
            // {
            //     Console.Write("Add a number to the array\nNumber: ");
            //     input = Console.ReadLine();
            //     if(input == "done")
            //     {
            //         Console.WriteLine($"The new array length is: {userNumbers.Count}");
            //         Console.WriteLine("Adding elements was completed");
            //     }
            //     else
            //     {
            //         userNumbers.Add(Convert.ToInt32(input));
            //     }
            // }

            // Qn2
            int[] storage = new int[5] {2,46,7,7,9};
            Array.Resize(ref storage,8);

            // Qn3
            List<int> removeDepulicts = new List<int> { 2,34,5,2,1,9,7,5 };
            List<int> unique = new List<int>();
            foreach (int value in removeDepulicts)
            {
                if (!unique.Contains(value))
                {
                    unique.Add(value);
                }
            }

            // unique.ForEach((val) => Console.WriteLine(val));

            TypeCode test = 'A'.GetTypeCode();
            Console.WriteLine(test);
            
            // Qn4

            // Qn5
            
        }

        // Qn6
        public static int SumIntegres(int[] numbers) => numbers.Aggregate((acc,val) => acc + val);
        // Qn7
        public static string MaxMin(List<decimal> balance){
            balance.ForEach((val) => Console.WriteLine(val));
            return "";
        }
    }
}