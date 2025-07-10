using BLL.ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace BLL.ChainOfRensposibility
{
    public class Mecanico : Handler
    {
        public override void Aprobar(Presupuesto presupuesto)
        {
            Console.WriteLine($"Ejecutando la aprovacion -> Mecanico");
            //aplicar las reglas de negocio de acuerdo al dominio
            if (presupuesto.Monto <= 500)
                presupuesto.Estado = EnumEstadoAprobacion.Aprobado;
            else if (this.Successor != null)
                this.Successor.Aprobar(presupuesto);
            else
                presupuesto.Estado = EnumEstadoAprobacion.Desaprobado;
        }
    }
}
