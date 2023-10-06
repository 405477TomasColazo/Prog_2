using Venta_8_Julio.Service;

namespace Venta_8_Julio
{
    public partial class frm_Pastelitos : Form
    {
        List<Cliente> lista_Clientes;
        List<Vendedor> lista_Vendedores;
        ServicioPastelito oServicio;
        public frm_Pastelitos()
        {
            InitializeComponent();
            oServicio = new ServicioPastelito();
            lista_Clientes = new List<Cliente>();
            lista_Vendedores = new List<Vendedor>();
        }

        private void frm_Pastelitos_Load(object sender, EventArgs e)
        {
            Cargar_Lista(lst_Vendedores, "Vendedores");
            Cargar_Lista(lst_Clientes, "Clientes");
        }

        private void Cargar_Lista(ListBox lst, string nombreTabla)
        {
            if (lst == lst_Vendedores)
            {
                lista_Vendedores.Clear();
                lista_Vendedores = oServicio.TraerVendedores();
                lst.DataSource = lista_Vendedores;
            }
            else
            {
                lista_Clientes.Clear();
                lista_Clientes = oServicio.TraerClientes();
                lst.DataSource = lista_Clientes;
            }

        }
    }
}