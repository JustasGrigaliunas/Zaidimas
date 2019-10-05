using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Strategy
{
    class Blind : ICastSpell
    {
        public Blind() { }
        public void Cast(Spell spell)
        {
            Console.WriteLine($"Blinded and done {spell.Damage} damage");
        }
    }
}
