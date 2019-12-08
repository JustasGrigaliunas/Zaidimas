using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Mediator
{
    public interface ATracker
    {
        void addSender(ASender a, String m);
        void SendMessage(ASender caller, string msg);
    }
}
