using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Mycharacter;
using Zaidimas.Strategy;

namespace Zaidimas.State
{
    public class BlindedState : ICharacterState
    {
        private MyCharacter character;
        public BlindedState(MyCharacter newCharacter)
        {
            character = newCharacter;
        }
        public void Attack()
        {
            Console.WriteLine("I missed the target");
        }

        public void CastSpell(Spell spell)
        {
            Console.WriteLine("Cant see where to cast, because blinded");
        }

        public void Move(int direction)
        {
            character.Walk(direction);
        }
    }
}
