using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Template
{
    public class ArrowAndBow : Weapon
    {
        protected override bool IsLongShot()
        {
            return true;
        }

        protected override bool IsHeavyWeapon()
        {
            return false;
        }

        protected override bool IsSecondaryWeapon()
        {
            return false;
        }

        protected  override void AddDamage()
        {
            Console.WriteLine("Arrow And Bow have " + Damage + " damage points");
        }


        protected override void AddArrowsAndBow()
        {
            Console.WriteLine("Added Arrows and Bow " + Name);

        }

        protected override void AddSword()
        {
            throw new NotImplementedException();
        }

        protected override void AddKnife()
        {
            throw new NotImplementedException();
        }

        protected override string GetName()
        {
            return Name;
        }

        public ArrowAndBow(int level, int damage, string name) : base(level, damage, name)
        {
        }
    }
}
