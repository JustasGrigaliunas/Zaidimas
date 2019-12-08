using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Adapter;

namespace Zaidimas.Command
{
    public class CommandFireAtEnemy : ICommand
    {
        public CommandFireAtEnemy(IEnemy enemyUnderCommand) : base(enemyUnderCommand) { }
        public override void execute()
        {
            EnemyUnderCommand.FireAtEnemy();
        }
        public override void undo()
        {
            Console.WriteLine("Moves back");
        }
    }
}
