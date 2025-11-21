using Supermercado_Clases;
using System.Text;

namespace Proyecto_EF_FP_G2
{
    public partial class Form1 : Form
    {

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
            string ruta = "cliente.txt";

            // 1. Verificar si el archivo existe 
            if (!File.Exists(ruta)) return; // Si no existe, se sale y no hace nada
            dgvListadoClientes.DataSource = null;
            dgvListadoClientes.Rows.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] array = linea.Split(',');
                        if (array.Length >= 4)
                        {
                            dgvListadoClientes.Rows.Add(array[0], array[1], array[2], array[3]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer: " + ex.Message);
            }
        }
        public void ListarProductos()
        {
            string rutaP = "producto.txt";
            // EL TAMAÑO TOTAL DEBE SER LA SUMA DE LOS CAMPOS (10+30+20+10+10 = 80)
            int tamañoRegistro = 80;

            if (!File.Exists(rutaP)) return;

            dgvListadoProductos.Rows.Clear();

            try
            {
                using (FileStream fs = new FileStream(rutaP, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    // Calculamos cuántos registros hay
                    long cantidad = fs.Length / tamañoRegistro;

                    for (int i = 0; i < cantidad; i++)
                    {
                        // 1. Mover el puntero (Igual a tu imagen)
                        long posicion = i * tamañoRegistro;
                        fs.Seek(posicion, SeekOrigin.Begin);

                        // 2. Leer el registro completo en un buffer
                        byte[] buffer = reader.ReadBytes(tamañoRegistro);

                        // 3. Convertir todo a un solo String
                        string registro = Encoding.ASCII.GetString(buffer);

                        // 4. Extraer los campos con Substring (Cortar el texto)
                        // Cuidado con los índices: empiezan donde termina el anterior
                        string codigo = registro.Substring(0, 10).Trim();   // De 0 a 10
                        string nombre = registro.Substring(10, 30).Trim();  // De 10, toma 30 caracteres
                        string cat = registro.Substring(40, 20).Trim();     // 10+30 = 40. Desde 40, toma 20.
                        string precio = registro.Substring(60, 10).Trim();  // 40+20 = 60. Desde 60, toma 10.
                        string stock = registro.Substring(70, 10).Trim();   // 60+10 = 70. Desde 70, toma 10.

                        // 5. Agregar al DataGridView
                        dgvListadoProductos.Rows.Add(codigo, nombre, cat, precio, stock);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer: " + ex.Message);
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
    }
}
