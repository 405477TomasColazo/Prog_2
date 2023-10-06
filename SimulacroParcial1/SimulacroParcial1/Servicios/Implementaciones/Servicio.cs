using SimulacroParcial1.Datos.Implementaciones;
using SimulacroParcial1.Datos.Interfaces;
using SimulacroParcial1.Entidades;
using SimulacroParcial1.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1.Servicios.Implementaciones
{
    public class Servicio : IServicio
    {
        private IOrdenRetiroDAO dao;

        public Servicio()
        {
            dao = new OrdenRetiroDAO();
        }
        public bool ComprobarStock(int cantidad, Material material)
        {
            return dao.ComprobarStock(cantidad,material);
        }

        public bool GrabarOrdenRetiro(OrdenRetiro oOrdenRetiro)
        {
            return dao.Crear(oOrdenRetiro);
        }

        public List<Material> TraerMateriales()
        {
           return dao.ObtenerMateriales();
        }

        public int TraerNroNuevaOrdenRetiro()
        {
            return dao.ObtenerNroNuevaOrdenRetiro();
        }
    }
}
