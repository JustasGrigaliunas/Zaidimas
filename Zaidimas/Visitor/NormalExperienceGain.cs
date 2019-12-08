using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Adapter;

namespace Zaidimas.Visitor
{
    class NormalExperienceGain : ExperienceWorthCalculator
    {
        public int calculateExperienceWorth(EnemyHuman e)
        {
            int experienceWorth = 20;
            return experienceWorth;
        }
        public int calculateExperienceWorth(EnemyRobot e)
        {
            int experienceWorth = 50;
            return experienceWorth;
        }
    }
}
