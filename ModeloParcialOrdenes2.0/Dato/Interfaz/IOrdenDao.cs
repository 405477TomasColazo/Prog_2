using ModeloParcialOrdenes2._0.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialOrdenes2._0.Dato.Interfaz
{
    public interface IOrdenDao
    {
        List<Material> CargarMateriales();
    }
}
