﻿using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Mycharacter;

namespace Zaidimas.Factory
{
    class ElfCharacter :MyCharacter
    {
        internal ElfCharacter(String n, int hp, int dmg, int lvl) :
            base(n, hp, dmg, lvl)
        { }
    }
}
