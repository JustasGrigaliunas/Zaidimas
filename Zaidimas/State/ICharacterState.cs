using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Strategy;

namespace Zaidimas.State
{
    public interface ICharacterState
    {
        void Move(int direction);
        void CastSpell(Spell spell);
        void Attack();
    }
}
