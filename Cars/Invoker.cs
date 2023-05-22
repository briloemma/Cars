using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Invoker
    {
        private ICommand firstCommand;

        private ICommand secondCommand;

        public void SetFirstCommand(ICommand command)
        {
            firstCommand = command;
        }

        public void SetSecondCommand(ICommand command)
        {
            secondCommand = command;
        }

        public void DoFirstOrSecondCommand()
        {
            while (firstCommand.Execute() == 0);
            
            while (secondCommand.Execute() != 5);
        }
    }
}
