using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Decorator.Interface;

namespace Zaidimas.Decorator
{
    public class Helmet : ArmorDecorator
    {
        public Helmet(Armor newArmor) : base(newArmor, new ArmorUnit())
        {
        }

        public override ArmorUnit AddArmorAmount()
        {
            return new ArmorUnit("Helmet", 15); // Helmet have 55 armor Amount
        }
    }
}
