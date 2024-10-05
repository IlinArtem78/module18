using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module18
{
    public class Description : ICommand
    {
        Receiver receiver;
        public Description(Receiver receiver) 
        { 
            this.receiver = receiver;
        
        }

        public void Cancel()
        {
            
        }

        public void Run()
        {
            receiver.DescOperation();
        }
    }
}
