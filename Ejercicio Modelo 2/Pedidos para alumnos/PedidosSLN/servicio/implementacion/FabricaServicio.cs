using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetasSLN.servicio.interfaz;

namespace RecetasSLN.servicio.implementacion
{
    public class FabricaServicio : IFabricaServicio
    {
        public IServicio CrearServicio()
        {
            return new Servicio();
        }
    }
}
