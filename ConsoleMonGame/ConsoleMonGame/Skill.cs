using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class Skill
    {
        internal int Damage;
        internal int EnergyCost;
        internal string Name;
        internal Element element;

        public Skill()
        {

        }

        public Skill(int damage, int energyCost, string Name, Element element)
        {
            this.Damage = damage;
            this.EnergyCost = energyCost;
            this.Name = Name;
            this.element = element;
        }

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(EnergyCost);
            target.TakeDamage(Damage);
            if (target.weakness == element)
            {
                target.TakeDamage(Damage/2);
            }
        }
    }
}
