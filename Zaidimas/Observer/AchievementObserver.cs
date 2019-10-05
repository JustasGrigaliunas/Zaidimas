using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Observer
{
    class AchievementObserver : IObserver
    {
        public void Update(string message)
        {
            switch (message)
            {
                case "EVENT_CHARACTER_CREATION":
                    Console.WriteLine("Achievement Unlocked: New beginnings!"); break;
                case "EVENT_TRIED_WALKING":
                    Console.WriteLine("Achievement Unlocked: First steps!"); break;
                case "EVENT_TRIED_ATTACKING":
                    Console.WriteLine("Achievement Unlocked: Shots fired!"); break;
                case "EVENT_WALKED_5_TIMES":
                    Console.WriteLine("Achievement Unlocked: Slow down speedy!");

                    break;
            }
        }
    }
}
