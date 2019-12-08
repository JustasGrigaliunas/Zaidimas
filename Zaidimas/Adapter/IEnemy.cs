using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Adapter
{
    public interface IEnemy
    {
        void FireAtEnemy(); 
        void ForwardToEnemy(); 
        void ChangeWeapon(); 
        void Retreat();
    }
}
