﻿using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Mycharacter;

namespace Zaidimas.Factory
{
    public class DwarfCharacter : MyCharacter
    {
        internal DwarfCharacter(String n, int hp, int dmg, int lvl) :
            base(n, hp, dmg, lvl){ }
    }
}
