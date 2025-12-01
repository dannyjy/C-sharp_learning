using System.Globalization;

namespace OOP;

class Car
{
    public string? color { get; set;}
    public string? name { get; set;}
    public string? model { get; set;}
    public int? year { get; set;}

    public void getCardDetails()
    {
        Console.WriteLine($@"
            Name: {name}
            Model: {model}
            Color: {color}
            Year: {year}
        ");
    }
}