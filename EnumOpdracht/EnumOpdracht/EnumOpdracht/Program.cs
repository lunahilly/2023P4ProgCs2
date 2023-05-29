using System.Drawing;

namespace EnumOpdracht
{
    internal class Program
    {
        private static Colors MyMainThemeColor = Colors.green;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            if (MyMainThemeColor == Colors.green)
            {
                Console.WriteLine("Dat is mijn kleur!");
            }
        }
    }
}