using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZaidimasAPI.Models
{
    public class Player
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }
        public Player() { }
    }
}
