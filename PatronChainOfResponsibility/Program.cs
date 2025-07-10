using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BLL.ChainOfRensposibility;
using BLL;

namespace PatronChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Presupuesto presupuesto = new Presupuesto();
            presupuesto.Cliente = cliente;
            presupuesto.Monto = 750;

            PresupuestoService.Aprobar(presupuesto);

            Console.WriteLine($"El presupuesto quedo en estado: {presupuesto.Estado}");

            presupuesto.Estado = EnumEstadoAprobacion.Desaprobado;
            presupuesto.Monto = 20000;

            PresupuestoService.Aprobar(presupuesto);
            Console.WriteLine($"El presupuesto quedo en estado: {presupuesto.Estado}");

            Console.ReadLine();
        }
    }
}
