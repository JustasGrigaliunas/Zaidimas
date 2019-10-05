using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Observer
{
    public interface IEntity
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify(string message);
    }
}
