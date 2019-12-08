using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Chain_of_responsibility
{
    public class GoldRank : Rank
    {
        private int lowestlvl = 16;
        private int highestlvl = Int16.MaxValue;
        
        public GoldRank()
        {
            current = this;
            RankName = "Gold";
        }

        public override void levelDown()
        {
            current = back;
        }

        public override void levelUp()
        {
            current = next;
        }

        public override void setBackChain(Rank back)
        {
            this.back = back;
        }

        public override void setNextChain(Rank next)
        {
            this.next = next;
        }
    }
}
