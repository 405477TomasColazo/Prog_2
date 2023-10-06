using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloParcialOrdenes2._0.Dato.Interfaz;
using ModeloParcialOrdenes2._0.Dato.Implementacion;
using ModeloParcialOrdenes2._0.Servicio.Interfaz;
using ModeloParcialOrdenes2._0.Dominio;

namespace ModeloParcialOrdenes2._0.Servicio.Implementacion
{
    public class Servicio : IServicio
    {
        IOrdenDao dao;
        public Servicio()
        {
            dao = new OrdenDao();
        }

        public List<Material> CargarMateriales()
        {
            return dao.CargarMateriales();
        }

        public bool CargarOrden(OrdenRetiro oOrden)
        {
            return dao.CargarOrden(oOrden);
        }
    }
}
