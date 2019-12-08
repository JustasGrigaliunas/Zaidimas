using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Adapter;

namespace Zaidimas.Command
{
    public abstract class ICommand
    {
        protected IEnemy EnemyUnderCommand;
        protected ICommand(IEnemy enemyUnderCommand)
        {
            this.EnemyUnderCommand = enemyUnderCommand;
        }
        abstract public void execute();
        abstract public void undo();
    }
}
