using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Mycharacter;

namespace Zaidimas.Factory
{
    class HumanCharacter : MyCharacter
    {
        internal HumanCharacter(String n, int hp, int dmg, int lvl) :
            base(n, hp, dmg, lvl, 1, 5) { } //1 - type , 5- armor depends from character type
    }
}
