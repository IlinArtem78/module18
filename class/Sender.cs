using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module18
{
    public class Sender
    {
        ICommand command;

        public void SetCommand(ICommand command)
        {
            command = command;
        }

        // Выполнить
        public void Run()
        {
            command.Run();
        }

        // Отменить
        public void Cancel()
        {
            command.Cancel();
        }
    }
}
