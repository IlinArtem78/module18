using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module18
{
    public class GateOpenAction : Command 
    {
        Gate gate;
        public GateOpenAction(Gate gate) {
        
            this.gate = gate;
        }

        public override void CloseButon()
        {
            gate.Close();
        }

        public override void OpenButon()
        {
            gate.Open();
        }
    }
}
