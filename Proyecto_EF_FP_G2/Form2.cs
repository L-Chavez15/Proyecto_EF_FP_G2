using Supermercado_Clases;
using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        string ruta = "cliente.txt";
        public List<Clientes> listaClientes = new List<Clientes>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {//secuencial-cliente
            Guardar();
            
            Limpiar();
        }
        public void Limpiar()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
        }
        public void Guardar()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    writer.WriteLine(txtNombre.Text + "," + txtApellidos.Text + "," + txtDni.Text + "," + txtTelefono.Text);
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error al leer: " + ex.Message);
                throw;
            }
        }
        //public void Leer()
        //{
        //    try
        //    {
        //        using (StreamReader sr = new StreamReader(ruta))
        //        {
        //            string linea;
        //            while ((linea = sr.ReadLine()) != null)
        //            {
        //                string[] datos = linea.Split(',');
        //                // Validamos que la línea tenga los 4 datos necesarios
        //                if (datos.Length == 4)
        //                {
        //                    Clientes c = new Clientes();
        //                    c.Nombres = datos[0];
        //                    c.Apellidos = datos[1];
        //                    // Usamos TryParse para evitar que el programa explote si el archivo está corrupto
        //                    int.TryParse(datos[2], out int dni);
        //                    int.TryParse(datos[3], out int cel);
        //                    c.DNI = dni;
        //                    c.Celular = cel;

        //                    listaClientes.Add(c);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al leer clientes: " + ex.Message);
        //    }
        //}
    }
}
