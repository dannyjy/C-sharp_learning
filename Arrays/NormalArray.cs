class NormalArrays
{
    public static void General()
    {
        // Arrays can be created using the data type then a square bracket and a variable number
        /*
            You can create an array in three ways
            type[] variableName = new type[optional numbers values];
            type[] variableName = {}
            type[] variableName = new {}
        */
        string[] names = new string[9];
        int[] nums = new int[9];

        // Multi dimensional array
        int[,] arr2D =
        {
            {32,56,55},
            {23,5,7}
        };

        int[,,] arr3D = new int[2,2,3]
        {
            {{1,34,5},{5,68,7}},
            {{32,3,5},{9,7,45}},
        };

        // Testing a grid
        int[,] mygrid = new int[5,5]
        {
            {1,2,3,4,6},
            {17,2,3,4,6},
            {1,2,3,4,6},
            {1,2,3,4,6},
            {1,2,3,4,6}
        };

        int answer = mygrid[0,1];
        Console.WriteLine($"Answer: {answer}");

        // Jagged arrays
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] {2,4,56,4,23,45,6,7};
        jaggedArray[1] = new int[] {2,4,23,2};
        jaggedArray[2] = new int[] {2,4,56,23,45,6};

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.WriteLine($"Jagged [{i}][{j}]: {jaggedArray[i][j]}");
            }
        }
    }

    public void stringArray(int length)
    {
        string[] names = new string[length];
        string? value;

        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"Name {i+1}: ");
            value = Console.ReadLine();
            names[i] = value;
        }

        for (int i = 0; i < names.Length; i++)
        {
            Console.Write(names[i] + " ");
        }
    }

    public void intergerArray(int length)
    {
        int[] numbers = new int[length];
        int num;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            num = Convert.ToInt32(Console.ReadLine());
            numbers[i] = num;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }

        Console.ReadKey();
    }

    public void printDefinedValues()
    {
        double[] withDot = new double[3] { 22.4, 4343.5, 3.5 };
    }
}