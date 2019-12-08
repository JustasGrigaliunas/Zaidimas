using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Template
{
   public abstract class Weapon
    {
        public String Name { get; set; }
        public int Level { get; set; }
        public int Damage { get; set; }

        public Weapon(int level, int damage, string name)
        {
            Name = name;
            Level = level;
            Damage = damage;
        }
        public void SelectWeapon()
        {
            Console.WriteLine("started creating weapon");
            AddLevel();
            AddDamage();

            if (IsLongShot())
            {
                AddArrowsAndBow();
            }

            if (IsHeavyWeapon())
            {
                AddSword();
            }
            if (IsSecondaryWeapon())
            {
                AddKnife();
            }
            Console.WriteLine("Weapon created it is: "+ GetName());

        }

        protected abstract bool IsLongShot();
        protected abstract bool IsHeavyWeapon();
        protected abstract bool IsSecondaryWeapon();
        protected abstract void AddDamage();

        protected void AddLevel()
        {
            Console.WriteLine("Weapon are "+Level+" level");

        }
        protected abstract void AddArrowsAndBow();
        protected abstract void AddSword();
        protected abstract void AddKnife();
        protected abstract string GetName();



    }
}
