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
        private string rutaP = "producto.txt";
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            
            Guardar(new Productos
            {
                Codigo = int.Parse(txtCodigo.Text),
                Nombre = txtNombreP.Text,
                Categoria = cbbCategoria.SelectedItem.ToString(),
                Precio = double.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text)
            });
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
            string rutaP = "producto.txt";

            // DEFINIMOS LOS TAMAÑOS (Igual que haremos en la lectura)
            // Total = 10 + 30 + 20 + 10 + 10 = 80 bytes
            int tamCodigo = 10;
            int tamNombre = 30;
            int tamCat = 20;
            int tamPrecio = 10;
            int tamStock = 10;

            try
            {
                using (FileStream fs = new FileStream(rutaP, FileMode.Append, FileAccess.Write))
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    // Construimos una sola cadena larga concatenando todo
                    string registro = "";

                    // 1. Código (Convertir a string, rellenar a la derecha, cortar si sobra)
                    registro += prod.Codigo.ToString().PadRight(tamCodigo).Substring(0, tamCodigo);

                    // 2. Nombre
                    registro += prod.Nombre.PadRight(tamNombre).Substring(0, tamNombre);

                    // 3. Categoría
                    registro += prod.Categoria.PadRight(tamCat).Substring(0, tamCat);

                    // 4. Precio
                    registro += prod.Precio.ToString().PadRight(tamPrecio).Substring(0, tamPrecio);

                    // 5. Stock
                    registro += prod.Stock.ToString().PadRight(tamStock).Substring(0, tamStock);

                    // ESCRIBIMOS LA CADENA CONVERTIDA A BYTES
                    byte[] buffer = Encoding.ASCII.GetBytes(registro);
                    bw.Write(buffer);
                }
                MessageBox.Show("Producto guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
        //public Productos Leer(int numeroRegistro)
        //{
        //    const int TAMAÑO_REGISTRO = 42; // 4 + 30 + 8

        //    using (FileStream fs = new FileStream(rutaP, FileMode.Open))
        //    using (BinaryReader br = new BinaryReader(fs))
        //    {
        //        // Calcular posición exacta
        //        long posicion = numeroRegistro * TAMAÑO_REGISTRO;

        //        // Mover el puntero
        //        fs.Seek(posicion, SeekOrigin.Begin);

        //        // Leer datos
        //        Productos est = new Productos();
        //        est.Codigo = br.ReadInt32();
        //        est.Nombre = br.ReadString().Trim();
        //        est.Categoria = br.ReadString().Trim();
        //        est.Precio = br.ReadDouble();
        //        est.Stock = br.ReadInt32();

        //        return est;
        //    }
        //}
    }
}
