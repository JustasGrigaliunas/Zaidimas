using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Observer;
using Zaidimas.Strategy;

namespace Zaidimas.Mycharacter
{
    public abstract class MyCharacter : IEntity
    {
        private int timesWalked = 0;
        private List<IObserver> observers = new List<IObserver>();
        private string name { get; set; }
        private int healthPoints { get; set; }
        private int damage { get; set; }
        private int level { get; set; }

        public ICastSpell spellAction;
        public MyCharacter(string n, int hp, int dmg, int lvl)
        {
            name = n;
            healthPoints = hp;
            damage = dmg;
            level = lvl;
        }
        public void Walk()
        {
            timesWalked++;
            Console.WriteLine(this.name + ": Walking");
            if (timesWalked == 1)
            {

                Notify("EVENT_TRIED_WALKING");
            }
            if (timesWalked == 5)
            {
                Notify("EVENT_WALKED_5_TIMES");
            }
        }
        public void CastSpell(Spell spell)
        {
            spellAction = spell.primarySpellAction;
            spellAction.Cast(spell);
        }
        public string GetName()
        {
            return this.name;
        }
        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string message)
        {
            observers.ForEach(x => x.Update(message));
        }


    }

}
