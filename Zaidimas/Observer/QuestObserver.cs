using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Observer
{
    class QuestObserver : IObserver
    {
        public void Update(string message)
        {
            switch (message)
            {
                case "QUEST_BECOME_ELF":
                    Console.WriteLine("Quest finished: {0}", message);

                    break;
                case "QUEST_BECOME_DWARF":
                    Console.WriteLine("Quest finished: {0}", message);

                    break;
                case "QUEST_BECOME_HUMAN":
                    Console.WriteLine("Quest finished: {0}", message);

                    break;
            }
        }
    }
}
