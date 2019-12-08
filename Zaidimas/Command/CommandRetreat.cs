using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Adapter;

namespace Zaidimas.Command
{
    public class CommandRetreat : ICommand
    {
        public CommandRetreat(IEnemy enemyUnderCommand) : base(enemyUnderCommand) { }
        public override void execute()
        {
            EnemyUnderCommand.Retreat();
        }
        public override void undo()
        {
            Console.WriteLine("Moves Forward back");
        }
    }
}
