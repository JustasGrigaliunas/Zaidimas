using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Mycharacter;
using Zaidimas.Singleton;


namespace Zaidimas.Factory
{
    class ElfCharacter :MyCharacter
    {
        internal ElfCharacter(String n, int hp, int dmg, int lvl) :
            base(n, hp, dmg, lvl, 3, 20) //3 - type , 20- armor depends from character type
        { }
    }
}
