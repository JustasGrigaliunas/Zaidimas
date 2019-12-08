using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Mediator
{
    public class Achievement : ASender
    {
        public Achievement(ATracker mediator) : base(mediator) { }

        public override void Send(string msg)
        {
            Console.WriteLine("Achievement:" + msg);
            _mediator.SendMessage(this, msg);
        }

        public override void Receive(string msg)
        {
            Console.WriteLine("Ach Received message:" + msg);
        }
    }
}
