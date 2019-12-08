using System;
using System.Collections.Generic;

using System.Text;

namespace Zaidimas.Composite
{
    class Team : IComponent
    {
        public List<IComponent> players { get; set; }
        public string name { get; set; }
        public Team()
        {
            players = new List<IComponent>();
        }

        public void printGoldAndName()
        {

            foreach (IComponent member in players)
            {
                member.printGoldAndName();
            }
        }

        public double GetGold()
        {
            double totalGold = 0;
            foreach (IComponent player in players)
            {
                totalGold += player.GetGold();
            }

            return totalGold;
        }

        public void addGold(double gold2)
        {
            double eachSplit = gold2 / players.Count;
            double leftOver = gold2 % players.Count;
            foreach (IComponent player in players)
            {
                player.addGold(eachSplit + leftOver);
                leftOver = 0;
            }
        }
    }
}
