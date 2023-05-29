using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string Name;
        private List<Skill> skills = new List<Skill>();
        public Element weakness;

        public ConsoleMon() 
        {

        }
        public ConsoleMon(int health, int energy, string name,Element weakness)
        {
            this.health = health;
            this.energy = energy;
            this.Name = name;
            this.weakness = weakness;
        }

        internal void TakeDamage(int damage)
        {
            this.health = health - damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy = this.energy - energy;
        }
    }
}
