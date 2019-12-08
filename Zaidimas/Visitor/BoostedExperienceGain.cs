using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Adapter;

namespace Zaidimas.Visitor
{
    class BoostedExperienceGain :ExperienceWorthCalculator
    {
        public int calculateExperienceWorth(EnemyHuman e)
        {
            int experienceWorth = 40;
            return experienceWorth;
        }
        public int calculateExperienceWorth(EnemyRobot e)
        {
            int experienceWorth = 100;
            return experienceWorth;
        }
    }
}
