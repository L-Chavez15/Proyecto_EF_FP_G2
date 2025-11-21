namespace Supermercado_Clases
{
    public class Clientes
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int DNI { get; set; }
        public int Celular { get; set; }

        //Metodo Constructor
        public Clientes()
        {
        }

        public Clientes(string G2_Nombres, string G2_Apellidos, int G2_DNI, int G2_Celular)
        {
            Nombres = G2_Nombres;
            Apellidos = G2_Apellidos;
            DNI = G2_DNI;
            Celular = G2_Celular;
        }
    }
}
