﻿namespace ConsoleMonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //TestConsoleMonFunctions();
            //TestSkillFunctions();
            TestConstructors();
        }
        static void TestConsoleMonFunctions()
        {
            Console.WriteLine("TestConsoleMonFunctions:");
            ConsoleMon mon = new ConsoleMon();
            mon.TakeDamage(100);
            mon.DepleteEnergy(20);

            Console.WriteLine(mon.health == -100);

            Console.WriteLine(mon.energy == -20);
        }

        static void TestSkillFunctions()
        {
            Console.WriteLine("TestSkillFunctions:");
            ConsoleMon casterMon = new ConsoleMon();
            ConsoleMon targetMon= new ConsoleMon();
            Skill skill = new Skill()
            {
                Damage = 100,
                EnergyCost = 20,
            };
            skill.UseOn( targetMon, casterMon );
            Console.WriteLine(targetMon.health == -150);
            Console.WriteLine(casterMon.energy == -20);
        }
        static void TestConstructors()
        {
            Console.WriteLine("TestConstructors");
            ConsoleMon mon = new ConsoleMon(200, 200, "ConsoleColorMon", Element.Earth);

            Console.WriteLine(mon.energy == 200);
            Console.WriteLine(mon.Name == "ConsoleColorMon");
            Console.WriteLine(mon.health == 200);
            Console.WriteLine(mon.weakness == Element.Earth);


            Skill skill = new Skill(90, 80, "FireBlade", Element.Fire);
            Console.WriteLine(skill.EnergyCost == 80);
            Console.WriteLine(skill.Name == "FireBlade");
            Console.WriteLine(skill.Damage == 90);
            Console.WriteLine(skill.element == Element.Fire);

        }
    }
}