using System;
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
                myCharacter.Walk();
                myCharacter.CastSpell(blind);
                myCharacter.Walk();
                myCharacter.Walk();
                myCharacter.Walk();
                myCharacter.Walk();
                myCharacter.CastSpell(knockout);
                myCharacter.Walk();

            }

            Logger.Instance().Info("Program ended");
            myCharacter.Unsubscribe(achObserver);
            myCharacter.Unsubscribe(queObserver);
        }
    }
}
