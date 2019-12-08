using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Adapter
{
    public class EnemyHumanAdapter : IEnemy
    {
        EnemyHuman Human; 
        public EnemyHumanAdapter(EnemyHuman newHuman) 
        { 
            Human = newHuman; 
        }
        public void FireAtEnemy() 
        { 
            Human.HitAnEnemy(); 
        }
        public void ForwardToEnemy() 
        {
            Human.RunToEnemy(); 
        }
        public void ChangeWeapon() 
        {
            Human.ChangeWeapon(); 
        }
        public void Retreat() 
        {
            Human.Retreat(); 
        }
    }
}
