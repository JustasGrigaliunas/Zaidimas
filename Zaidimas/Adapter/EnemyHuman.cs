using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Prototype;

namespace Zaidimas.Adapter
{
    public class EnemyHuman : Prototype.IPrototype
    {
        int damage; 
        int armor; 
        int health; 
        int speed; 
        Tuple<int, int> position; 
        public EnemyHuman(int dmg, int arm, int health, int speed, Tuple<int, int> pos) 
        { 
            this.damage = dmg;
            this.armor = arm;
            this.health = health;
            this.speed = speed;
            this.position = pos; 
        }
        public void HitAnEnemy()
        {
            Console.WriteLine("Enemy Human hits" + damage); 
        }
        public void RunToEnemy() 
        { 
            Console.WriteLine("Enemy Human run towards Character at" + speed + " speed");
        }
        public void ChangeWeapon()
        {
            Console.WriteLine("Enemy Human Changes Weapon"); 
        }
        public void Retreat() 
        {
            Console.WriteLine("Enemy Human retreats");
        }

        public IPrototype Clone()
        {
            return (IPrototype)MemberwiseClone();
        }
        public string GetDetails()
        {
            return string.Format("Damage: {0}, Armor: {1}, Health: {2}, Speed: {3}, Position: {4},{5}", damage, armor, health, speed, position.Item1, position.Item2);
        }
    }
}
