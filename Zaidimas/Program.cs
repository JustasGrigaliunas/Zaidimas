using System;
using Zaidimas.Decorator;
using Zaidimas.Decorator.Interface;
using Zaidimas.Factory;
using Zaidimas.Mycharacter;
using Zaidimas.Observer;
using Zaidimas.Singleton;
using Zaidimas.Strategy;

namespace Zaidimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance().Info("Program started");

            CharacterFactory CharFactory = new CharacterFactory();
            Spell blind = new Spell("Blind", 15, 3, "Blinds only near objects, with big amount of damage", new Blind());
            Spell knockout = new Spell("knockout", 2, 8, "Knockout created", new Knockout());


            MyCharacter myCharacter = CharFactory.CreateCharacter(2, "Elfas112");

            IObserver achObserver = new AchievementObserver();
            IObserver queObserver = new QuestObserver();
            
            myCharacter.Subscribe(achObserver);
            myCharacter.Subscribe(queObserver);

            if (myCharacter != null)
            {
                myCharacter.Notify("EVENT_CHARACTER_CREATION"); switch (myCharacter.GetType().ToString())
                {
                    case "Zaidimukas.Character.HumanCharacter": myCharacter.Notify("QUEST_BECOME_HUMAN"); break;
                    case "Zaidimukas.Character.ElfCharacter": myCharacter.Notify("QUEST_BECOME_ELF"); break;
                    case "Zaidimukas.Character.DwarfCharacter": myCharacter.Notify("QUEST_BECOME_DWARF");
                        break;

                }
                myCharacter.Walk(1);
                myCharacter.CastSpell(blind);
                myCharacter.Walk(1);
                myCharacter.Walk(2);
                myCharacter.Walk(3);
                myCharacter.Walk(1);
                myCharacter.CastSpell(knockout);
                myCharacter.Walk(4);
                ArmorUnit arm = new ArmorUnit("Shirts", 4);
                Armor arm1 = new Gloves(new BasicArmor(arm));
                myCharacter.SetArmor(arm1);
                Console.WriteLine(myCharacter.ArmorDecorator.getArmors().ToString());
                arm1 = new Gloves(arm1);
                


                myCharacter.SetArmor(arm1);
                Console.WriteLine(myCharacter.ArmorDecorator.getArmors().ToString());

                arm1 = new Helmet(arm1);



                myCharacter.SetArmor(arm1);
                Console.WriteLine(myCharacter.ArmorDecorator.getArmors().ToString());



            }

            Logger.Instance().Info("Program ended");
            myCharacter.Unsubscribe(achObserver);
            myCharacter.Unsubscribe(queObserver);
        }
    }
}
