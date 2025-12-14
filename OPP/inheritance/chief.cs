namespace OOP;

class Chief
{
    public void makesChicken(){
        Console.WriteLine("Chief is making chicken");
    }

    public void makesPasta(){
        Console.WriteLine("Chief is making pasta");
    }

    public virtual void makeSpecialDish()
    {
        Console.WriteLine("Chief is making beef BBQ");
    }
}