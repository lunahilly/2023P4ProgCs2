using System.Reflection.Metadata;

namespace FileDirOpdracht
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\lunah\OneDrive\Documenten\MA\bewijzenmap\jaar 1\periode 1.4\prog\2023P4ProgCs2");

            Console.WriteLine("Directories:");

            foreach (var fi in dir.GetDirectories())
            {
                Console.WriteLine(fi.Name);
            }

            Console.WriteLine("Files:");

            foreach (var fi in dir.GetFiles())
            {
                Console.WriteLine(fi.Name);
            };
        }
    }
}