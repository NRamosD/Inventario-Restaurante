using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BDatos
{
    class conexion
    {
        //Crhistian
        //public string cadena = "Data Source =DESKTOP-4561NSV\\SQLEXPRESS; Initial Catalog = Invoice; Integrated Security = true";
        //Nixon
        public string cadena = "Data Source =NR; Initial Catalog = Invoice; Integrated Security = true";
        //Willy
        //public string cadena = "Data Source = DESKTOP-8BF136O; Initial Catalog = Invoice; Integrated Security = true";

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
