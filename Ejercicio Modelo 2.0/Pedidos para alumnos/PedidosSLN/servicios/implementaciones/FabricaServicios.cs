using RecetasSLN.servicios.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.servicios.implementaciones
{
    public class FabricaServicios : IFabricaServicios
    {
        public IServicio CrearServicio()
        {
            return new Servicio();
        }
    }
}
