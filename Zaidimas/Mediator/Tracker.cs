using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Mediator
{
    public class Tracker : ATracker
    {
        List<ASender> list = new List<ASender>();
        public Notification not { get; set; }

        public Achievement ach { get; set; }

        public void addSender(ASender a, string m)
        {
            list.Add(a);
        }

        public void SendMessage(ASender caller, string msg)
        {
            foreach (ASender sender in list)
            {
                if (caller != sender) sender.Receive(msg);
            }
        }

    }
}
