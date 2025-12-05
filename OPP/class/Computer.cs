namespace OPP;

class Computer
{
    public string BrandName;
    public bool Is180Degree;
    public bool HasTypeCCharger;
    public bool hasKeyboard;


    // This is a constructor which uses the this keyword that references to the current class's properties.
    public Computer(string Brand,bool Is180,bool TypeC,bool keyboard)
    {
        this.BrandName = Brand;
        this.HasTypeCCharger = TypeC;
        this.Is180Degree = Is180;
        this.hasKeyboard = keyboard;
    }
}

class Laptop
{
    public string brandName;
    public string generation;
    public string computerName;
    public int numberOfProcessors;
    public int numberOfCores;
    public double baseSpeed;
    public double computerRam;
    public double storage;

    // Directly accessing elements and passing values from the constructors without using the this keyword.
    public Laptop(string brand,string gen,string name, int processors, int cores, double speed, double ram,double rom)
    {
        brandName = brand;
        generation = gen;
        computerName = name;
        numberOfProcessors = processors;
        numberOfCores = cores;
        baseSpeed = speed;
        storage = rom;
        computerRam = ram;
    }
}

class PC
{
    string brand;

    public PC(string b) => this.brand = b;
}