namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> birds = new List<string> { "uil, " , "kraai ," , "hond" , "papegaai ," };
            List<string> birds2 = new List<string> { "meeuw, " , "druif" };

            birds.AddRange(birds2);
            birds.Remove("hond");

            for (int i = 0; i < birds.Count; i++)
            {
                Console.Write(birds[i]);
            }
        }
    }
}