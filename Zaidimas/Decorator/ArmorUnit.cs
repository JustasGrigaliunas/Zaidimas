using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Decorator
{
    public class ArmorUnit
    {
        public string Name { get; set; }
        public int ArmorAmount { get; set; }

        public ArmorUnit()
        {

        }

        public ArmorUnit(int ArmAmount)
        {
            ArmorAmount = ArmAmount;
        }
        public ArmorUnit(string name, int ArmAmount) : this(ArmAmount)
        {
            Name = name;
        }

        public ArmorUnit IncreaseArmor(ArmorUnit armorUnit)
        {
            ArmorAmount += armorUnit.ArmorAmount;
            if (Name != null)
            {
                Name += $" plus {armorUnit.Name}";
            }
            else
            {
                Name = armorUnit.Name;
            }

            return this;
        }

        public override String ToString()
        {
            return $"{Name} Have Armor amount of {ArmorAmount}";
        }

    }
}
