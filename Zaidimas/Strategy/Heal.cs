using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Strategy
{
    class Heal : ICastSpell
    {
        public Heal() { }
        public void Cast(Spell spell)
        {
            Console.WriteLine($"Healed by {spell.Damage} helth");
        }
    }
}
