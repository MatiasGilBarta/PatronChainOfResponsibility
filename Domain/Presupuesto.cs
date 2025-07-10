using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Presupuesto
    {
        public Cliente Cliente { get; set; }

        public decimal Monto { get; set; }

        public EnumEstadoAprobacion Estado {get; set;}

        public Presupuesto()
        {
        this.Estado = EnumEstadoAprobacion.Solicitado;
        }
    }
}
