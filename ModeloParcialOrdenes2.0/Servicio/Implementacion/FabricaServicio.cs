using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloParcialOrdenes2._0.Servicio.Interfaz;

namespace ModeloParcialOrdenes2._0.Servicio.Implementacion
{
    public class FabricaServicio : IFabricaServicio
    {
        public IServicio CrearServicio()
        {
            return new Servicio();
        }
    }
}
