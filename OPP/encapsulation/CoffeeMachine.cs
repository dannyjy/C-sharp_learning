namespace OPP.Encapsulation
{
    public class CoffeeMachine
    {
        // Public interface (The only button the user sees)
        public void MakeCoffee()
        {
            BoilWater();
            GrindBeans();
            Brew();
            Console.WriteLine("Coffee is ready!");
        }

        // Internal steps (Hidden from the user)
        private void BoilWater() { /* Logic */ }
        private void GrindBeans() { /* Logic */ }
        private void Brew() { /* Logic */ }
    }
}