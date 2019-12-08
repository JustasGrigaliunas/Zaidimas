using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Adapter;

namespace Zaidimas.Command
{
    public class CommandForwardToEnemy : ICommand
    {
        public CommandForwardToEnemy(IEnemy enemyUnderCommand) : base(enemyUnderCommand) { }
        public override void execute()
        {
            EnemyUnderCommand.ForwardToEnemy();
        }
        public override void undo()
        {
            Console.WriteLine("Moves back");
        }
    }
}
