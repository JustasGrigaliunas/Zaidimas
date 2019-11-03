using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Decorator.Interface
{
    public abstract class Armor
    {
        public ArmorUnit unit;

        public Armor(ArmorUnit unit)
        {
            this.unit = unit;
        }

        public abstract ArmorUnit getArmors();
    }
}
