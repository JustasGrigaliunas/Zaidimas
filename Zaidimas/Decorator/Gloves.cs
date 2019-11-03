using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Decorator.Interface;

namespace Zaidimas.Decorator
{
    public class Gloves :ArmorDecorator
    {
        public Gloves(Armor newArmor) : base(newArmor, new ArmorUnit())
        {
        }

        public override ArmorUnit AddArmorAmount()
        {
            return new ArmorUnit("GLOVES", 10) ; // gloves have 10 armor Amount
        }

    }
}
