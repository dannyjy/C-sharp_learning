
namespace OPP.Abstraction
{
    public abstract class DocumentConverter
    {
        public abstract void Convert(string filePath);
    }

    public class PdfToWord : DocumentConverter
    {
        public override void Convert(string filePath) => Console.WriteLine("Parsing PDF to .docx...");
    }
}