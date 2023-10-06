using SimulacroParcial1.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1.Servicios.Implementaciones
{
    public class FabricaServicios : IFabricaServicios
    {
        public IServicio CrearServicio()
        {
            return new Servicio();

        }
    }
}
