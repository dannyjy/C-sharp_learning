namespace Arrays
{
    class Level3
    {
        public static void AllTop10()
        {
            // First
            List<string> dataLog = new List<string>() { "King", "Queen", "Prince", "Princess" };
            // Console.WriteLine(dataLog.Count);
            int i = dataLog.Count - 1;
            while (i >= 0)
            {
                // Console.WriteLine(dataLog[i]);
                i--;
            }

            // Third
            List<int> primary = new List<int> { 1, 2, 3 };
            List<int> secondary = new List<int> { 4, 5, 6 };
            // Option 1
            primary.AddRange(secondary);
            // Option 2
            List<int> ans = [.. primary, .. secondary];

            foreach (int val in primary)
            {
                // Console.WriteLine(val);
            }

            // Fourth
            List<double> temperatures = new List<double>() { 0.0,12.4,43.56,56.3,0.0 };
            // temperatures.ForEach((temp) => Console.WriteLine(temp));
            // Console.WriteLine("-------------------------------");
            temperatures.RemoveAll(temperature => temperature < 0.1);
            // temperatures.ForEach((temp) => Console.WriteLine(temp));

            // Fifth
            List<char> wordLetters = new List<char> { 'A','B','C','D','E','F'};
            // wordLetters.ForEach((c) => Console.WriteLine(c));
            wordLetters.Reverse();
            // wordLetters.ForEach((c) => Console.WriteLine(c));

            // Sixth
            List<string> strList = new List<string> { "Jose", "Patric", "Saul", "Mick"};
            int index = strList.FindIndex((str) => str[0] == 'S');
            // Console.WriteLine(strList.Capacity = 5);
            // Console.WriteLine(strList.Count);
            // Console.WriteLine(index);

            // Seventh
            string[] parts = {"Chirs", "Brown","Moses"};
            List<string> partList = parts.ToList();

            // Eigth
            List<int> tempReadings = new List<int> {34,23,65};
            int[] tempReadingArray = tempReadings.ToArray();

            // Ninth
            /*
                Capacity property is used to get and set the List length, Which means you can get the List length using
                capacity the the property count. But it's different from count because count gets the length of the can can't
                edit or set the count of the List.
            */
        }

        // Second
        public static int Occurrences(int[] arr,int target)
        {
            int count = 0;
            foreach(int value in arr)
            {
                if(value == target)
                {
                    count++;
                }
            }
            return count;
        }
        
        // Tenth
        public static List<int> SwapLastAndFirst(List<int> numbers)
        {
            int total = numbers[0] + numbers[numbers.Count - 1];
            numbers[0] = total - numbers[0];
            numbers[numbers.Count - 1] = total - numbers[numbers.Count - 1];
            return numbers;
        }
    }
}