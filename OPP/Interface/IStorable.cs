
namespace OPP.Interface
{
    public interface IStorable
    {
        void Save();
    }

    public class UserProfile : IStorable
    {
        public void Save() => Console.WriteLine("User saved to Database.");
    }

    public class Document : IStorable
    {
        public void Save() => Console.WriteLine("Document saved to Disk.");
    }
}