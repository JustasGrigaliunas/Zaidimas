using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Observer
{
    public interface IObserver
    {
        void Update(string message);
    }
}
