using Supermercado_Clases;
using System.Text;

namespace Proyecto_EF_FP_G2
{
    public partial class Form1 : Form
    {
        //falta terminar el código
        public List<Clientes> listaClientes = new List<Clientes>();
        public List<Productos> listaProductos = new List<Productos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvListadoClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ListarClientes();
            ListarProductos();
        }

        public void ListarClientes()
        {
            string G2_ruta = "cliente.txt";
            listaClientes.Clear();
            // 1. Verificar si el archivo existe 
            if (!File.Exists(G2_ruta)) return; // Si no existe, se sale y no hace nada
            dgvListadoClientes.DataSource = null;
            dgvListadoClientes.Rows.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(G2_ruta))
                {
                    string G2_linea;
                    while ((G2_linea = sr.ReadLine()) != null)
                    {
                        string[] g2_array = G2_linea.Split(',');
                        DataGridView G2_Item = new DataGridView();
                        G2_Item.Columns.Add("Nombres", "Nombres");
                        G2_Item.Columns.Add("Apellidos", "Apellidos");
                        G2_Item.Columns.Add("DNI", "DNI");
                        G2_Item.Columns.Add("Celular", "Celular");
                        dgvListadoClientes.Rows.Add(g2_array[0], g2_array[1], g2_array[2], g2_array[3]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar Clientes: " + ex.Message);
            }
        }
        public void ListarProductos()
        {
            string G2_rutaP = "producto.txt";
            listaProductos.Clear();
            // 1. Verificar si el archivo existe 
            if (!File.Exists(G2_rutaP)) return; // Si no existe, se sale y no hace nada
            dgvListadoProductos.DataSource = null;
            dgvListadoProductos.Rows.Clear();
            try
            {
                using (FileStream fs = new FileStream(G2_rutaP, FileMode.Open, FileAccess.Read))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    while (fs.Position < fs.Length)
                    {
                        double codigo = br.ReadDouble();
                        string nombre = br.ReadString();
                        string categoria = br.ReadString();
                        double precio = br.ReadDouble();
                        int stock = br.ReadInt32();
                        dgvListadoProductos.Rows.Add(codigo, nombre, categoria, precio, stock);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar Productos: " + ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 registrarClientes = new Form2();
            registrarClientes.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form3 registrarProducto = new Form3();
            registrarProducto.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
