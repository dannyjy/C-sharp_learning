namespace RefAndOut
{
    struct Task
    {
        
    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            Reference test = new Reference();
            int num = 7;
            // int mult = num * 3;

            Console.WriteLine(num);
            Reference.RefTest1(ref num);

            Console.WriteLine(num);
            // Console.WriteLine(ans);
        }
    }
}