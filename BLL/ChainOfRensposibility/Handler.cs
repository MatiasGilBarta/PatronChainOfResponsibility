using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace BLL.ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler Successor { get; set; }

        public abstract void Aprobar(Presupuesto presupuesto);

        
        
        public void SetSuccessor(Handler handler)
        { 
            this.Successor = handler; 
        }
    }
}
