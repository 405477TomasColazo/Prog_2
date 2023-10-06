using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloParcialOrdenes2._0.Dominio;

namespace ModeloParcialOrdenes2._0.Servicio.Interfaz
{
    public interface IServicio
    {
         List<Material> CargarMateriales();
    }
}
