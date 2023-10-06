using SimulacroParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1.Servicios.Interfaces
{
    public interface IServicio
    {
        List<Material> TraerMateriales();
        bool GrabarOrdenRetiro(OrdenRetiro oOrdenRetiro);
        bool ComprobarStock(int cantidad, Material material);
        int TraerNroNuevaOrdenRetiro();
    }
}
