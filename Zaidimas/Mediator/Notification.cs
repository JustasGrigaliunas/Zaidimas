using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Mediator
{
    public class Notification : ASender
    {
        public Notification(ATracker mediator) : base(mediator) { }

        public override void Receive(string msg) { }
        public override void Send(string msg)
        {
            Console.WriteLine("Notification:" + msg);
            _mediator.SendMessage(this, msg);
        }
    }
}
