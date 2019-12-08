using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Adapter;
using Zaidimas.Mycharacter;

namespace Zaidimas.Mementoo
{
   public class Mementoo
    {

        private MyCharacter character;
        private List<IEnemy> enemies;
        public Mementoo(MyCharacter character, List<IEnemy> enemies)
        {
            this.character = character;
            this.enemies = enemies;
        }

        public MyCharacter GetCharacter()
        {
            return character;
        }

        public List<IEnemy> getEnemies()
        {
            return enemies;
        }
    }
}
