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
        public List<Clientes> listaClientes = new List<Clientes>();
        string G2_ruta = "cliente.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            G2_Guardar();
            G2_Limpiar();
        }
        public void G2_Limpiar()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
        }
        public void G2_Guardar()
        {
            try
            {
                if (!ValidarDatos(txtNombre.Text, 0))
                {
                    MessageBox.Show("El Nombre no debe contener números ni estar vacío.", "Error");
                    return;
                }
                if (!ValidarDatos(txtApellidos.Text, 0))
                {
                    MessageBox.Show("Los Apellidos no deben contener números ni estar vacíos.", "Error");
                    return;
                }
                if (!ValidarDni(txtDni.Text, 0))
                {
                    MessageBox.Show("El DNI debe tener 8 dígitos numéricos.", "Error");
                    return;
                }
                if (!ValidarTelefono(txtTelefono.Text, 0))
                {
                    MessageBox.Show("El Teléfono debe tener 9 dígitos numéricos.", "Error");
                    return;
                }
                using (StreamWriter sw = new StreamWriter(G2_ruta, true))
                {
                    string G2_cadena = txtNombre.Text + ",";
                    G2_cadena += txtApellidos.Text + ",";
                    G2_cadena += txtDni.Text + ",";
                    G2_cadena += txtTelefono.Text;
                    sw.WriteLine(G2_cadena);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer: " + ex.Message);
                throw;
            }
        }
        //recursividad
        private bool ValidarDni(string G2_textoDni, int G2_indice)
        {
            if (G2_textoDni.Length != 8) return false;
            if (G2_indice == 8) return true;
            if (!char.IsDigit(G2_textoDni[G2_indice])) return false;
            return ValidarDni(G2_textoDni, G2_indice + 1);
        }
        private bool ValidarTelefono(string G2_textoTelf, int G2_indice)
        {
            if (G2_textoTelf.Length != 9) return false;
            if (G2_indice == 9) return true;
            if (!char.IsDigit(G2_textoTelf[G2_indice])) return false;
            return ValidarTelefono(G2_textoTelf, G2_indice + 1);
        }
        private bool ValidarDatos(string texto, int indice)
        {
            if (string.IsNullOrWhiteSpace(texto)) return false;
            if (indice == texto.Length) return true;
            if (char.IsDigit(texto[indice])) return false;
            return ValidarDatos(texto, indice + 1);
        }
        //public void Leer()
        //{//lectura secuencial-cliente
        //    try
        //    {
        //        using (StreamReader sr = new StreamReader(G2_ruta))
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
