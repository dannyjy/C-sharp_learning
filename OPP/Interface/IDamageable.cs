
namespace OPP.Interface
{
    public interface IDamageable
    {
        void TakeDamage(int amount);
    }

    public class Zombie : IDamageable
    {
        public void TakeDamage(int amount) => Console.WriteLine($"Zombie health is down by {amount}.");
    }

    public class WoodenFence : IDamageable
    {
        public void TakeDamage(int amount) => Console.WriteLine("Fence is splintering!");
    }
}