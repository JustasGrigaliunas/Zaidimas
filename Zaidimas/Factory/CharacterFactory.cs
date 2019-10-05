using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Mycharacter;

namespace Zaidimas.Factory
{
    public class CharacterFactory
    {
        public MyCharacter CreateCharacter(int charClass, String charName)
        {
            switch (charClass)
            {
                case 1:
                    {
                        return new DwarfCharacter(charName, 120, 8, 1);
                    }
                case 2:
                    {
                        return new ElfCharacter(charName, 80, 12, 1);
                    }
                case 3:
                    {
                        return new HumanCharacter(charName, 100, 10, 1);
                    }
                default: return null;
            }
        }
    }
}
