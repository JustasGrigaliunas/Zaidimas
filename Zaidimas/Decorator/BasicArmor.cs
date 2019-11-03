using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Decorator.Interface;

namespace Zaidimas.Decorator
{
    class BasicArmor : Armor
    {
        ArmorUnit basic;
        public BasicArmor(ArmorUnit armU) :base(armU) {
            basic = armU;
        }

        public override ArmorUnit getArmors()
        {
            return basic;
        }
    }
}
