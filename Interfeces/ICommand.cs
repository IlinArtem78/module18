using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module18
{
    public interface ICommand
    {
        void Run();
        void Cancel();
      
    }
}
