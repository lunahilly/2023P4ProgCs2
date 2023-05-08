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
            //haal je energycost van caster af door de deplete energy aan te roepen op caster
            //geef je damage aan de target door door de takedamage funtie aan te roepen op target

            caster.DepleteEnergy(EnergyCost);
            target.TakeDamage(Damage);
        }
    }
}
