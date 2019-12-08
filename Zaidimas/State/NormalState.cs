using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Mycharacter;
using Zaidimas.Strategy;

namespace Zaidimas.State
{
    public class NormalState : ICharacterState
    {
        MyCharacter character;
        public NormalState(MyCharacter newCharacter)
        {
            character = newCharacter;
        }
        public void Attack()
        {
            Console.WriteLine("Attacking");
        }

        public void CastSpell(Spell spell)
        {
            Console.WriteLine($"Casting {spell.Name}, dealt {spell.Damage} dmg");
        }

        public void Move(int direction)
        {
            character.Walk(direction);
        }
    }
}
