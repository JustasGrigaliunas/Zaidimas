using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Template
{
    public class Knife :Weapon
    {


        protected override bool IsLongShot()
        {
            return false;
        }

        protected override bool IsHeavyWeapon()
        {
            return false;

        }

        protected override bool IsSecondaryWeapon()
        {
            return false;

        }

        protected override void AddDamage()
        {
            Console.WriteLine("Knife have "+Damage+" damage points");
        }


        protected override void AddArrowsAndBow()
        {
            throw new NotImplementedException();
        }

        protected override void AddSword()
        {
            throw new NotImplementedException();
        }

        protected override void AddKnife()
        {
            Console.WriteLine("Added Knife name "+ Name);

        }

        protected override string GetName()
        {
            return Name;
        }

        public Knife(int level, int damage, string name) : base(level, damage, name)
        {
        }
    }
}
