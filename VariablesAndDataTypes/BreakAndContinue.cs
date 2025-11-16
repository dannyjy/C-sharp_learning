namespace VariablesAndDataTypes
{
    public class BreakContinue
    {
        //Example with the break keyword.
        // It is used to end a loop or and another condition to move out of a certain condition.
        public static int findIndex(string letter, string[] letters)
        {
            int index = -1;

            for (int i = 0; i < letters.Length; i++)
            {
                Console.Write(letters[i] + " ");
                if (letter == letters[i])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
        
        // This example shows how continue is used to skipe a certain number if the condition is meet.
        public static string SkipAnIndex(string skipLetter, string[] letters)
        {
            List<int> indexs = new List<int>();

            for(int i = 0; i < letters.Length; i++)
            {
                if (skipLetter.Equals(letters[i]))
                {
                    continue;
                }
                indexs.Add(i);
            }

            return string.Join(", ",indexs);
        }
    }
}