using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Strategy
{
    class Knockout : ICastSpell
    {
        public Knockout() { }
        public void Cast(Spell spell)
        {
            Console.WriteLine($"Knockouted and done {spell.Damage} damage");
        }
    }
}
