namespace OOP;

class Properties
{
    // C# has what is well known as properties in create a property it most contain the get or set method in C#

    // When use the default values of the method they tend to set the value obtained from the field and when ever need the
    // the get method is automatically called to get the field value.
    public int Year { get; set; }
    // This creates a read only property
    public string Name { get; } = "Doe";

    // This 
    public DateTime DateOfBirth { get; set; } = DateTime.Now;
}