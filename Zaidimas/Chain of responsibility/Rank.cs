using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Chain_of_responsibility
{
    public abstract class Rank
    {
        protected Rank next;
        protected Rank back;
        public Rank current;
        public string RankName;

        public Rank() {}

        public abstract void levelUp();
        public abstract void levelDown();
        public abstract void setNextChain(Rank next);
        public abstract void setBackChain(Rank back);
    }
}
