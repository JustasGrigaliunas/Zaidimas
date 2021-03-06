﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZaidimasAPI.Models
{
    public class PlayerContext :DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Coordinate> Coordinates { get; set; }

    }
}
