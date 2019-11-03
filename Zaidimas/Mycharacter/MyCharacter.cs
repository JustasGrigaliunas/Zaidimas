using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Observer;
using Zaidimas.Singleton;
using Zaidimas.Strategy;
using System.Runtime.Serialization;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Zaidimas.Models;
using Zaidimas.Decorator.Interface;
using Zaidimas.Decorator;

namespace Zaidimas.Mycharacter
{
    public abstract class MyCharacter : IEntity
    {
        private long id = 0;
        private int timesWalked = 0;
        private List<IObserver> observers = new List<IObserver>();
        public string name {get; set; }
        public int healthPoints { get; set; }
        public int damage { get; set; }
        public int level { get; set; }
        public int type { get; set; }


        private int coordinateX { get; set; }

        private int coordinateY { get; set; }

        public Armor ArmorDecorator;


        public ICastSpell spellAction;

        //public ArmorUnit characterArmors;

        public MyCharacter(string n, int hp, int dmg, int lvl, int tp, int arm)
        {
            name = n;
            healthPoints = hp;
            damage = dmg;
            level = lvl;
            type = tp;
            coordinateX = 0;
            coordinateY = 0;
            //characterArmors = new ArmorUnit("Shirts And pants", arm); 



            var json = JsonConvert.SerializeObject(this);
            json = json.Remove(2, 41); //remove spellAction from string 
            var response = HttpClientToAPI.Instance().Post("players", json);
            Player pl = JsonConvert.DeserializeObject<Player>(response);
            id = pl.Id;
            HttpClientToAPI.Instance().Post("coordinates", "{\"PlayerId\":" + id + ", \"CoordinateX\":0, \"CoordinateY\":0}");
        }
        public void Walk(int type)
        {
            switch (type)
            {
                case 1: //right
                    coordinateX += 1;
                    HttpClientToAPI.Instance().Put("coordinates/"+id, "{ \"CoordinateX\":"+ coordinateX + "}");

                    break;
                case 2: //left\
                    coordinateX -= 1;
                    HttpClientToAPI.Instance().Put("coordinates/" + id, "{ \"CoordinateX\":" + coordinateX + "}");

                    break;
                case 3: //up
                    coordinateY += 1;
                    HttpClientToAPI.Instance().Put("coordinates/" + id, "{ \"CoordinateY\":" + coordinateY + "}");

                    break;
                case 4: //down
                    coordinateY -= 1;
                    HttpClientToAPI.Instance().Put("coordinates/" + id, "{ \"CoordinateY\":" + coordinateY + "}");

                    break;

                default:
                    break;
            }

            timesWalked++;
            Console.WriteLine(this.name + ": Walking. Coordinates: "+coordinateX +" And "+coordinateY);
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

        public void SetArmor(Armor arm)
        {
             ArmorDecorator = arm;
        }
        public ArmorUnit getArmors()
        {
            return ArmorDecorator.getArmors();

        }
        //public ArmorUnit getArmors()
        //{
        //    return ArmorDecorator.getArmors();
        //}


    }

}
