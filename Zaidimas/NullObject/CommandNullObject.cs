using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Adapter;
using Zaidimas.Command;

namespace Zaidimas.NullObject
{
    class CommandNullObject : ICommand
    {
        public CommandNullObject(IEnemy enemyUnderCommand) : base(enemyUnderCommand) { }

        public override void execute()
        {
            Console.WriteLine("Command not found, doing nothing");
        }
        public override void undo()
        {
            Console.WriteLine("Command not found, doing nothing");
        }
    }
}
