using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZaidimasAPI.Models
{
    public class Spell
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Damage { get; set; }
        public int Level { get; set; }
        public double Cooldown { get; set; }
        public string Description { get; set; }

        public Spell() { }
    }
}
