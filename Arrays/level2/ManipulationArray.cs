using Microsoft.VisualBasic;

namespace Arrays.leve2
{
    class Level2
    {
        public static void First5()
        {
            // One
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            // numbers.ForEach((number) => Console.WriteLine(number));

            // Two
            List<string> colors = new List<string> {"Red", "Green", "Blue"};
            colors.Remove("Green");
            // colors.ForEach((color) => Console.WriteLine(color));

            // Three
            int lastElement = colors.Count - 1;
            colors.RemoveAt(lastElement);
            // colors.ForEach((color) => Console.WriteLine(color));

            // Fourth
            List<int> ages = new List<int> { 23,45,98 };
            // Console.WriteLine(ages.Contains(98));

            // Fifth
            List<double> tempertures = new List<double> { 29.3, 23.5, 34.6, 98.2, 2.0 };
            // tempertures.ForEach((temp) => Console.Write($"{temp} "));
            // Console.WriteLine();
            tempertures.Sort();
            // tempertures.ForEach((a) => Console.WriteLine(a));
            var decending = tempertures.OrderDescending().ToList();
            // decending.ForEach((d) => Console.WriteLine(d));

            //Sixth
            int[] inventoryIDs = new int[] {23,5,2,45,9,34,25};
            var i = Array.IndexOf(inventoryIDs,45);
            // Console.WriteLine(i);

            // Seventh
            List<char> alphabets = new List<char> {'A','C','D'};
            alphabets.Insert(1,'B');
            // alphabets.ForEach((a) => Console.WriteLine(a));

            // Eight
            int[] usersID = new int[5] { 1,2,3,4,5 };
            // Console.WriteLine($"Previouse: {usersID.Length}");
            Array.Resize(ref usersID,6);
            // Console.WriteLine($"Current: {usersID.Length}");


            // Ninth
            char[] sourceArray = new char[3] {'s','e','d'};
            char[] destinationArray = new char[sourceArray.Length];

            for(int j = 0; j < sourceArray.Length; j++)
            {
                destinationArray[j] = sourceArray[j];
            }

            foreach(char copyValue in destinationArray)
            {
                Console.WriteLine(copyValue);
            }

            // Tenth
            List<DateTime> timeStamps = new List<DateTime>();
            timeStamps.Add(new DateTime(2032,02,02));
            timeStamps.Add(new DateTime(2021,03,30));
            timeStamps.ForEach((t) => Console.WriteLine(t));
            timeStamps.Clear();
            Console.WriteLine("Cleared");
            timeStamps.ForEach((t) => Console.WriteLine(t));
        }
    }
}