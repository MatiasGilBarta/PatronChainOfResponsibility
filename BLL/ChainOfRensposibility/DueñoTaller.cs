using BLL.ChainOfResponsibility;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ChainOfRensposibility
{
    public class DueñoTaller : Handler
    {
        public override void Aprobar(Presupuesto presupuesto)
        {
            Console.WriteLine($"Ejecutando la aprovacion -> Dueño del taller");
            //aplicar las reglas de negocio de acuerdo al dominio
            if (presupuesto.Monto > 2000)
                presupuesto.Estado = EnumEstadoAprobacion.Aprobado;
            else if (this.Successor != null)
                this.Successor.Aprobar(presupuesto);
            else
                presupuesto.Estado = EnumEstadoAprobacion.Desaprobado;
        }
    }
}
