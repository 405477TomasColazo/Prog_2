using SimulacroParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1.Datos.Interfaces
{
    public interface IOrdenRetiroDAO
    {
        List<Material> ObtenerMateriales();
        bool Crear(OrdenRetiro oOrdenRetiro);
        bool ComprobarStock(int cantidad, Material material);
        int ObtenerNroNuevaOrdenRetiro();
    }
}
