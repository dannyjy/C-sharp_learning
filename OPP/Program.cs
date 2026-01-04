using OPP.Encapsulation;

namespace OOP
{
    class Program
    {
        static void Main(String[] args)
        {

            Car toyota = new Car();
            toyota.year = 1995;
            toyota.color = "red";
            toyota.model = "GTRX10234";
            toyota.name = "Toyota Prado G6";
            // toyota.getCardDetails();

            // Using constructors
            Person p1 = new Person("John",34,"male");
            string? name = p1.name;
            // Console.WriteLine(name);


            Doctor neurologist = new Doctor("John Doe",34,"Male","03324","Brain Surgen");
            string detail = neurologist.GetDetails();
            // Console.WriteLine(detail);

            Movie sherk = new Movie("Sherk","Chirs Jones","Dog");
            // Console.WriteLine(sherk.Rating);

            // Encapsulation examples
            Thermostat thermostat = new Thermostat();
            thermostat.Temperature = -44;
            Console.WriteLine(thermostat.Temperature);

            Player alpha7777 = new Player();
            alpha7777.Health = 0;
            System.Console.WriteLine(alpha7777.Health);
            System.Console.WriteLine(alpha7777.IsDead);
        }
    }
}