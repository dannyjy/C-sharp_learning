namespace OOP;
// This folder shows the primary constructor implimentation
class Animal(int legs,string gender)
{
    public int numberOfLegs => legs;
    public string animalGender => gender;

    public virtual void MakeSound()
    {
        Console.WriteLine("Making sound");
    }
}


class Dog(int legs, string gender, string breed) : Animal(legs,gender)
{
    public string breed = breed;

    // This here show or uses the default values passed to it if a user doesn't pass values to the constructor.
    public Dog() : this(4,"male","Wolf") {}

    public override void MakeSound()
    {
        Console.WriteLine("Bark bark.......");
    }
    public void Display()
    {
        Console.WriteLine($"Breed: {this.breed}");
        Console.WriteLine($"Legs: {this.numberOfLegs}");
        Console.WriteLine($"Gender: {this.animalGender}");
    }
}