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
<<<<<<< HEAD
        //Crhistian
        //public string cadena = "Data Source =DESKTOP-4561NSV\\SQLEXPRESS; Initial Catalog = Invoice; Integrated Security = true";
        //Nixon
        public string cadena = "Data Source =NR; Initial Catalog = Invoice; Integrated Security = true";
        //Willy
        //public string cadena = "Data Source = DESKTOP-8BF136O; Initial Catalog = Invoice; Integrated Security = true";

=======
        public string cadena = "Data Source = DESKTOP-LV5VE2S\\SQLEXPRESS; Initial Catalog = Invoice; Integrated Security = true";
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
        public SqlConnection conectar = new SqlConnection();

        public conexion()
        {
            conectar.ConnectionString = cadena;
<<<<<<< HEAD
=======

>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
        }

        public void abrir()
        {
            try
            {
                conectar.Open();
<<<<<<< HEAD
=======
                Console.WriteLine("Conectado");

>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
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
