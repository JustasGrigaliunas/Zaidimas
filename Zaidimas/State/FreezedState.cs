using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Mycharacter;
using Zaidimas.Strategy;

namespace Zaidimas.State
{
    public  class FreezedState : ICharacterState
    {
        private MyCharacter character;
        public FreezedState(MyCharacter newCharacter)
        {
            character = newCharacter;
        }
        public void Attack()
        {
            Console.WriteLine("Im frozen");
        }

        public void CastSpell(Spell spell)
        {
            Console.WriteLine("Cant cast, because frozen");
        }

        public void Move(int direction)
        {
            Console.WriteLine("Cant move, I'm frozen");
        }
    }
}
