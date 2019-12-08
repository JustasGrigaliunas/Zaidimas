using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Composite
{
    public interface IComponent
    {
        double GetGold();
        void addGold(double gold2);
        void printGoldAndName();
    }
}
