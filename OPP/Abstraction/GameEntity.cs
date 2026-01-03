
namespace OPP.Abstraction
{
    public abstract class GameEntity
    {
        public int Health { get; set; }
        public abstract void OnDeath(); // How it dies depends on what it is
    }

    public class Enemy : GameEntity
    {
        public override void OnDeath() => Console.WriteLine("Enemy drops loot.");
    }
}