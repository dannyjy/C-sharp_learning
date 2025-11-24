namespace Arrays.leve1
{
    public class top10
    {
        public static void First5()
        {
            // First
            int[] scores = new int[5] {100,34,87,3,2};

            // Second
            string[] names = { "Alice", "Bob", "Charlie" };
            foreach(var name in names)
            {
                if(name == "Bob")
                {                
                    Console.WriteLine(name);
                }
            }

            // Third
            double[] prices = { 10.5, 20.99, 5.0};
            var sum = prices.Sum();
            Console.Write(sum);
            foreach(double price in prices)
            {
                Console.WriteLine($"{price} ");
            }
            
            // Fourth
            List<string> cities = new List<string>{"Juba","Kigali","Nairobi"};;
            cities.ForEach((city) => Console.WriteLine($"{city} "));

            // Fifth
            List<int> numbers = new List<int> {1,2,4,5,6,9};
            string[] users = {"Alpha","Guest","Admin"};

            string forList = numbers.Count % 2 == 0 ? "Even" : "Odd";
            string forArray = users.Length % 2 == 0 ? "Even" : "Odd";

            Console.WriteLine("\n"+forList);
            Console.WriteLine(forArray);
        }

        public static void Last5()
        {
            // First
            bool[] flags = {true,false,false};

            // Second
            int[] values = new int[5];
            // Console.Write(values[5]);
            /*
                This line throughs an error which states that the array is out of bounds due to the element doesn't and
                can't exits in this array because the element shouldn't exits in it.
            */

            // Third
            /*
                Array sizes are defined at the begining or creation of the array while for lists they are dynamic which means
                it's size is not static. Which means they are not set at the begining and it has not spacific size only based on the 
                size it obtains from the values it has inside.
            */

            // Fourth
            /*
                Arrays are staticly typed data types as their values are defined during creation which means if you choose
                intergers then it is set to intergers and no other data type can be assigned to the arrays.
            */

            // Fifth

            /*
                When you initialize an array with a size and no values there default values are set to 0 which means when you
                access the values at each location there default values would be 0.
            */
        }
    }
}
