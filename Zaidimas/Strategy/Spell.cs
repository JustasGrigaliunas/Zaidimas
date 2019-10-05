using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Strategy
{
    public class Spell
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public int Level { get; set; }
        public double Cooldown { get; set; }
        public string Description { get; set; }
        public ICastSpell primarySpellAction { get; set; }

        public Spell(string name, double damage, int level, double cooldown, string description, ICastSpell primarySpellAction)

        {
            Name = name;
            Damage = damage;
            Level = level;
            Cooldown = cooldown;
            Description = description;
            this.primarySpellAction = primarySpellAction;
        }
        
    }
}
