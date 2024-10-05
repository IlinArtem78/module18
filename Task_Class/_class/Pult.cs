using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module18
{
    public class Pult
    {
        Command cmd;
        public void SetAction(Command comand)
        { 
           cmd = comand;    
        
        }
        public void OpenButton()
        {
           cmd.OpenButon();
        }
        public void CloseButton()
        {
            cmd.CloseButon();
        }
    }
}
