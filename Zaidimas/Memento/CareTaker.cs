using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zaidimas.Adapter;
using Zaidimas.Mycharacter;

namespace Zaidimas.Mementoo
{
    class CareTaker
    {
        List<Mementoo> list;
        public CareTaker()
        {
            list = new List<Mementoo>();
        }
        public void add(Mementoo state)
        {
            list.Add(state);
        }
        public Mementoo get(int index)
        {
            Mementoo restoreState = list.ElementAt(index);
            list.RemoveAt(index);
            return restoreState;
        }
        public int size()
        {
            return list.Count;
        }

    }
}
