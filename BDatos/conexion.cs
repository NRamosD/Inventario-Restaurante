using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BDatos
{
    internal class conexion
    {
        public string cadena = "Data Source = DESKTOP-LV5VE2S\\SQLEXPRESS; Initial Catalog = Invoice; Integrated Security = true";
        public SqlConnection conectar = new SqlConnection();

        public conexion()
        {
            conectar.ConnectionString = cadena;

        }

        public void abrir()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("Conectado");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error al conectarse.\n" + e);
            }
        }
        public void cerrar()
        {
            conectar.Close();
        }
    }
}
