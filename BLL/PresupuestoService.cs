using BLL.ChainOfRensposibility;
using BLL.ChainOfResponsibility;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PresupuestoService
    {
        private static Handler mecanico;
        private static Handler jefe;
        private static Handler dueño;

        static PresupuestoService()
        {
            dueño = new DueñoTaller();
            jefe = new JefeMecanico();
            jefe.SetSuccessor(dueño);
            mecanico = new Mecanico();
            mecanico.SetSuccessor(jefe);

        }

        public static void Aprobar(Presupuesto monto) {
            mecanico.Aprobar(monto);
            //repository.add()
        }


    }
}
