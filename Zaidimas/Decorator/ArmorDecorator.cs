using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Decorator.Interface;
using Zaidimas.Mycharacter;

namespace Zaidimas.Decorator
{
    public abstract class ArmorDecorator : Armor
    {

        protected Armor armor;
        public ArmorDecorator(Armor newarmor, ArmorUnit arUnit)
            : base(arUnit)
        {
            this.armor = newarmor;
        }
        public override ArmorUnit getArmors()
        {
            unit = armor.unit.IncreaseArmor(this.AddArmorAmount());
            return unit;
        }
        public abstract ArmorUnit AddArmorAmount();
    }
}
