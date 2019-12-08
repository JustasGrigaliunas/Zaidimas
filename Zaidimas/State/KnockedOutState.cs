using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Mycharacter;
using Zaidimas.Strategy;

namespace Zaidimas.State
{
    public class KnockedOutState : ICharacterState
    {
        private MyCharacter character;
        public KnockedOutState(MyCharacter newCharacter)
        {
            character = newCharacter;
        }
        public void Attack()
        {
            Console.WriteLine("I can't get up");
        }

        public void CastSpell(Spell spell)
        {
            Console.WriteLine("Cant cast, because knocked out");
        }

        public void Move(int direction)
        {
            Console.WriteLine("Cant move, before i get up");
        }
    }
}
