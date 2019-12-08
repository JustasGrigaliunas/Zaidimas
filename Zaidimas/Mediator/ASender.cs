using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Mediator
{
    public abstract class ASender
    {
        protected ATracker _mediator;

        public ASender(ATracker mediator)
        {
            _mediator = mediator;
        }
        public abstract void Send(string msg);

        public abstract void Receive(string msg);
    }
}
