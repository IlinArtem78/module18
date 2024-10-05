using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module18
{
    public class Download : ICommand
    {
        
        Receiver receiver;
        public Download (Receiver receiver)
        {
            this.receiver = receiver;
        }

       

        public void Cancel()
        {
           
        }

        public void Run()
        {
            receiver.DownloadOperation();
        }
    }
}
