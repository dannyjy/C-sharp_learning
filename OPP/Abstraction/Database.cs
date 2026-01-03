
namespace OPP.Abstraction
{
    public abstract class Database
    {
        public abstract void Connect(); // Every DB MUST connect, but differently
        public void Disconnect() => Console.WriteLine("Connection closed.");
    }

    public class SqlServer : Database
    {
        public override void Connect() => Console.WriteLine("Connecting to SQL Server...");
    }
}