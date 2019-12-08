using System;
using System.Collections.Generic;
using System.Linq;
using Zaidimas.Adapter;
using Zaidimas.Command;
using Zaidimas.Composite;
using Zaidimas.Decorator;
using Zaidimas.Decorator.Interface;
using Zaidimas.Factory;
using Zaidimas.Iterator;
using Zaidimas.Mementoo;
using Zaidimas.Mycharacter;
using Zaidimas.NullObject;
using Zaidimas.Observer;
using Zaidimas.Singleton;
using Zaidimas.Strategy;
using Zaidimas.Template;
using Zaidimas.Visitor;

namespace Zaidimas
{



    class Program
    {

        static private CareTaker ct = new CareTaker();
        static private Originator org;
        static MyCharacter  myCharacter;
        static void Main(string[] args)
        {
            Logger.Instance().Info("Program started");

            CharacterFactory CharFactory = new CharacterFactory();
            Spell blind = new Spell("Blind", 15, 3, "Blinds only near objects, with big amount of damage", new Blind());
            Spell knockout = new Spell("knockout", 2, 8, "Knockout created", new Knockout());

            EnemyRobotAdapter ERobot = new EnemyRobotAdapter(new EnemyRobot( 25, 25, 50, 7, new Tuple<int, int>(13, 1)));
            ICommand ERobot_command_fire = new CommandFireAtEnemy((IEnemy)ERobot);
            ICommand ERobot_command_forward = new CommandForwardToEnemy((IEnemy)ERobot);
            ICommand ERobot_command_retreat = new CommandRetreat((IEnemy)ERobot);

            ERobot_command_forward.execute();
            ERobot_command_fire.execute();
            ERobot_command_retreat.execute();
            ERobot_command_retreat.undo();


            myCharacter = CharFactory.CreateCharacter(2, "Elfas112");

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
                


                //myCharacter.SetArmor(arm1);
                //Console.WriteLine(myCharacter.ArmorDecorator.getArmors().ToString());

                //arm1 = new Helmet(arm1);



                //myCharacter.SetArmor(arm1);
                //Console.WriteLine(myCharacter.ArmorDecorator.getArmors().ToString());



            }
            // state

            myCharacter.AttackInState();
            myCharacter.changeState(myCharacter.blindedState, 3000);
            myCharacter.AttackInState();
            myCharacter.CastSpellInState(blind);
            myCharacter.WalkInState(3);
            myCharacter.changeState(myCharacter.normalState, 3000);
            myCharacter.WalkInState(4);

            // composite
            MyCharacter elf = CharFactory.CreateCharacter(2, "Elf");
            myCharacter.printGoldAndName();
            MyCharacter humanChar = CharFactory.CreateCharacter(3, "Human");
            MyCharacter humanChar2 = CharFactory.CreateCharacter(3, "Human2");
            MyCharacter humanChar3 = CharFactory.CreateCharacter(2, "Human3");

            int goldForKill = 3000;
            Console.WriteLine($"You have gained {goldForKill} coins!");
            IComponent elfComp = elf;
            IComponent humanCharComp = humanChar;
            IComponent myCharacterComp = myCharacter;
            IComponent humanChar2Comp = humanChar2;
            IComponent humanChar3Comp = humanChar3;

            IComponent party = new Team
            {
                name = "Best party ever",
                players =
                {
                    elfComp,
                    humanCharComp,
                    humanChar2Comp,
                    humanChar3Comp
                }
            };
            IComponent teams = new Team
            {
                players = { party, myCharacter }
            };
            Logger.Instance().Info("Team");
            teams.addGold(goldForKill);
            teams.printGoldAndName();
            // chain of responsibility
            myCharacter.GetRank();
            myCharacter.LevelUp();
            myCharacter.GetRank();
            myCharacter.LevelUp();
            
            myCharacter.GetRank();
            myCharacter.LevelDown();
            myCharacter.GetRank();
            //null object

            ICommandFactory commandFactory = new ICommandFactory();
            EnemyHuman EHuman = new EnemyHuman(50, 100, 1000, 1, new Tuple<int, int>(15, 5));
            IEnemy enemyHuman = new EnemyHumanAdapter(EHuman);
            ICommand retreatCommand = commandFactory.CreateCommand(enemyHuman, 3);
            ICommand nullCommand = commandFactory.CreateCommand(enemyHuman, 1123464);

            //visitor

            EnemyHuman tank = new EnemyHuman(2, 2, 2, 2, new Tuple<int, int>(2, 1));
            ExperienceWorthCalculator normalGain = new NormalExperienceGain();
            ExperienceWorthCalculator boostedGain = new BoostedExperienceGain();

            Console.WriteLine($"Without exp boost enemy is worth: {tank.GetExp(normalGain)} exp");
            Console.WriteLine($"With exp boost enemy is worth: {tank.GetExp(boostedGain)} exp");

            //template

            Sword sword = new Sword(1,5, "long Sword");
            sword.SelectWeapon();

            Knife knife =new Knife(1, 4, "Fast Knife");
            knife.SelectWeapon();

            //iterator

            KnifeList kl = new KnifeList();
            kl.AddKnife(knife);
            kl.AddKnife(1, 9, "Dagger");
            var a1 = kl.GetEnumerator();
            a1.MoveNext();
            var g = a1.Current;

            Swords sws = new Swords();
            sws.Add(sword);
            sws.Add(new Sword(1, 9, "test"));
            var test =sws.GetEnumerator();
            test.MoveNext();

            //MEMENTO
            org = new Originator(myCharacter, null);


            var list = new IEnemy[]{
                (IEnemy)ERobot
            };
            saveState(list);
            Console.Write("");

            Console.Write("charaacter before update");
            myCharacter.CharacterToString();

            myCharacter.Walk(1);
            myCharacter.Walk(1);
            myCharacter.healthPoints = 4;
            Console.Write("charaacter After update");
            myCharacter.CharacterToString();

            Console.Write("charaacter Restored");
            restoreState();
            myCharacter.CharacterToString();

            Logger.Instance().Info("Program ended");
            myCharacter.Unsubscribe(achObserver);
            myCharacter.Unsubscribe(queObserver);
        }

        private static void saveState(IEnemy[] enemies)
        {
            ct.add(new Mementoo.Mementoo((MyCharacter) myCharacter.Clone(), enemies.ToList()));
        }
        private static void restoreState()
        {
            org.getStateFromMemento(ct.get(ct.size() - 1));
            myCharacter = org.getStats();
        }
    }
}
