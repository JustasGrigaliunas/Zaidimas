using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Adapter;

namespace Zaidimas.Visitor
{
    public interface ExperienceWorthCalculator
    {
        int calculateExperienceWorth(EnemyHuman e);
        int calculateExperienceWorth(EnemyRobot e);
    }
}
