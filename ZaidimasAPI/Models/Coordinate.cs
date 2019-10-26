using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZaidimasAPI.Models
{
    public class Coordinate
    {
        public long Id { get; set; }
        public long PlayerId { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        public Coordinate() { }

    }
}
