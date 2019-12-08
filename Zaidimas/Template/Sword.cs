using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Template
{
    public class Sword : Weapon
    {
        protected override bool IsLongShot()
        {
            return false;
        }

        protected override bool IsHeavyWeapon()
        {
            return true;
        }

        protected override bool IsSecondaryWeapon()
        {
            return false;
        }

        protected override void AddDamage()
        {
            Console.WriteLine("Sword have " + Damage + " damage points");
        }


        protected  override void AddArrowsAndBow()
        {
            throw new NotImplementedException();
        }

        protected override void AddSword()
        {
            Console.WriteLine("Added Sword " + Name);

        }

        protected override void AddKnife()
        {
            throw new NotImplementedException();
        }

        protected override string GetName()
        {
            return Name;
        }

        public Sword(int level, int damage, string name) : base(level, damage, name)
        {
        }
    }
}
