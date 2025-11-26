using Supermercado_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_EF_FP_G2
{
    public partial class Form3 : Form
    {
        public List<Productos> listaProductos = new List<Productos>();
        //private const int TAM_REGISTRO = 42;
        private string G2_rutaP = "producto.txt";
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {

            Productos G2_nuevo = new Productos();
            G2_nuevo.Codigo = int.Parse(txtCodigo.Text);
            G2_nuevo.Nombre = txtNombreP.Text;
            G2_nuevo.Categoria = cbbCategoria.SelectedItem.ToString();
            G2_nuevo.Precio = double.Parse(txtPrecio.Text);
            G2_nuevo.Stock = int.Parse(txtStock.Text);
            Guardar(G2_nuevo);
            Limpiar();
        }
        public void Limpiar()
        {
            txtCodigo.Clear();
            txtNombreP.Clear();
            cbbCategoria.SelectedIndex = -1;
            txtPrecio.Clear();
            txtStock.Clear();
        }
        public void Guardar(Productos prod)
        {

            // DEFINIMOS LOS TAMAÑOS 
            // Total = 10 + 30 + 20 + 10 + 10 = 80 bytes
            //int G2_tamCodigo = 10;
            //int G2_tamNombre = 30;
            //int G2_tamCat = 20;
            //int G2_tamPrecio = 10;
            //int G2_tamStock = 10;

            try
            {
                using (FileStream fs = new FileStream(G2_rutaP, FileMode.Append, FileAccess.Write))
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(prod.Codigo);                                         // 4 bytes (int)
                    bw.Write(prod.Nombre.PadRight(30).Substring(0, 30));          // 30 bytes (string)
                    bw.Write(prod.Categoria.PadRight(20).Substring(0, 20));       // 20 bytes (string)
                    bw.Write(prod.Precio);                                         // 8 bytes (double)
                    bw.Write(prod.Stock);
                }
                MessageBox.Show("Producto registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
        public Productos Leer(int numeroRegistro)
        {
            const int tamañoRegistro = 80;

            try
            {
                using (FileStream fs = new FileStream(G2_rutaP, FileMode.Open, FileAccess.Read))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    // Calcular posición exacta del registro
                    long posicion = numeroRegistro * tamañoRegistro;

                    if (posicion >= fs.Length)
                    {
                        MessageBox.Show("El registro no existe.");
                        return null;
                    }

                    // Mover el puntero
                    fs.Seek(posicion, SeekOrigin.Begin);

                    // Leer el registro completo en un buffer
                    Productos prod = new Productos();
                    prod.Codigo = br.ReadInt32();
                    prod.Nombre = br.ReadString().Trim();
                    prod.Categoria = br.ReadString().Trim();
                    prod.Precio = br.ReadDouble();
                    prod.Stock = br.ReadInt32();
                    return prod;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("El archivo no existe.");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el registro: {ex.Message}");
                return null;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
