using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Adapter
{
    public class EnemyRobotAdapter : IEnemy
    {
        EnemyRobot Robot;
        public EnemyRobotAdapter(EnemyRobot newRobot)
        {
            Robot = newRobot;
        }
        public void FireAtEnemy()
        {
            Robot.HitAnEnemy();
        }
        public void ForwardToEnemy()
        {
            Robot.RunToEnemy();
        }
        public void ChangeWeapon()
        {
            Robot.ChangeWeapon();
        }
        public void Retreat()
        {
            Robot.Retreat();
        }
    }
}
