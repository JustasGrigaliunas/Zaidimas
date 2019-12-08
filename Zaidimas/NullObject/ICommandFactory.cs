using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Adapter;
using Zaidimas.Command;
using Zaidimas.Singleton;

namespace Zaidimas.NullObject
{
    class ICommandFactory
    {
        public ICommand CreateCommand(IEnemy enemyUnderCommand, int command)
        {
            switch (command)
            {

                case 1:
                    {
                        Logger.Instance().Info("Fire at enemy command created"); return new CommandFireAtEnemy(enemyUnderCommand);
                    }
                case 2:
                    {
                        Logger.Instance().Info("Forward to enemy command created"); return new CommandForwardToEnemy(enemyUnderCommand);
                    }
                case 3:
                    {
                        Logger.Instance().Info("Retreat command created"); return new CommandRetreat(enemyUnderCommand);
                    }
                default:
                    {
                        Logger.Instance().Info("Trying to create unknown command"); return new CommandNullObject(enemyUnderCommand);
                    }
            }
        }
    }
}
