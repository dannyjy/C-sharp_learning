using System.Net.NetworkInformation;

class Multi
{
    public static void UseParrellel()
    {
        System.Console.WriteLine("");
    }
    public static void GetValues()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Other thread: {i}");
        }
    }
}