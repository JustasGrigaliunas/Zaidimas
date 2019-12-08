using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Adapter;
using Zaidimas.Mycharacter;

namespace Zaidimas.Mementoo
{
    class Originator
    {

        private MyCharacter characters;
        private List<IEnemy> enemies;
        public Originator() : this(null, null)
        {

        }
        public Originator(MyCharacter characters, List<IEnemy> enemies)
        {
            this.characters = characters;
            this.enemies = enemies;
        }
        public MyCharacter getStats()
        {
            return characters;
        }
        public List<IEnemy> getEnemies()
        {
            return enemies;
        }

        public void setState(MyCharacter characterStats, List<IEnemy> enemies)
        {
            this.characters = characterStats;
            this.enemies = enemies;
        }

        public Mementoo saveState()
        {
            return new Mementoo(characters, enemies);
        }
        public void getStateFromMemento(Mementoo mememto)
        {
            characters = mememto.GetCharacter();
            enemies = mememto.getEnemies();
        }

    }
}
