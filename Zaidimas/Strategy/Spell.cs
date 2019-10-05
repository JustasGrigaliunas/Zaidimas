using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Strategy
{
    public class Spell
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public ICastSpell primarySpellAction { get; set; }

        public Spell(string name, int damage, int level,  string description, ICastSpell primarySpellAction)

        {
            Name = name;
            Damage = damage;
            Level = level;
            Description = description;
            this.primarySpellAction = primarySpellAction;
        }
        
    }
}
