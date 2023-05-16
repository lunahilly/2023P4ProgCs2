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

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(EnergyCost);
            target.TakeDamage(Damage);
        }
    }
}
