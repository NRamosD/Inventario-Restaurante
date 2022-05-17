using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace BDatos
{
    public class Operaciones
    {
        conexion objConnection = new conexion();
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable MostrarIngrediente(string _ci)
        {
            try
            {
                objConnection.abrir();
                SqlCommand comando = new SqlCommand("SELECT * FROM Customers WHERE txtId_Card = '" + _ci + "'", objConnection.conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método MostrarCliente ->" + ex);
                return tabla;
            }
        }
        public DataTable MostrarIngredientes()
        {
            try
            {
                objConnection.abrir();
                SqlCommand comando = new SqlCommand("SELECT * FROM Products", objConnection.conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método MostrarProductos ->" + ex);
                return tabla;
            }
        }
        public int CrearNuevoIdIngrediente()
        {
            try
            {
                objConnection.abrir();
                SqlCommand command = new SqlCommand("NewIdCustomer", objConnection.conectar);
                comando.CommandType = CommandType.StoredProcedure;
                DataTable id = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(id);
                objConnection.cerrar();
                return Convert.ToInt16(id.Rows[0][0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método CrearNuevoIdCliente ->" + ex);
                return 0;
            }
        }

        public int ObtenerTotalIngredientes()
        {
            try
            {
                objConnection.abrir();
                SqlCommand command = new SqlCommand("QuantiyProducts", objConnection.conectar);
                comando.CommandType = CommandType.StoredProcedure;
                DataTable id = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(id);

                return Convert.ToInt16(id.Rows[0][0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método ObtenerTotalProductos ->" + ex);
                return 0;
            }
        }

        public void InsertarIngrediente(int _id, string _ci, string _fn, string _ln, string _cp, string _ed, string _dir, string _sexo)
        {
            try
            {
                objConnection.abrir();
                SqlCommand command = new SqlCommand(
                    "INSERT INTO [dbo].[Customers] (intId_Customer, txtId_Card, txtFirst_Name, txtLast_Name, txtCell_Phone, txtEmail_Direction, txtDirection, txtSex)" +
                    "VALUES(@id, @ci, @fn, @ln, @cp, @ed, @dir, @sexo)", objConnection.conectar);
                command.Parameters.Add("@id", SqlDbType.Int).Value = _id;
                command.Parameters.Add("@ci", SqlDbType.Char, 10).Value = _ci;
                command.Parameters.Add("@fn", SqlDbType.VarChar, 50).Value = _fn;
                command.Parameters.Add("@ln", SqlDbType.VarChar, 50).Value = _ln;
                command.Parameters.Add("@cp", SqlDbType.Char, 10).Value = _cp;
                command.Parameters.Add("@ed", SqlDbType.VarChar, 50).Value = _ed;
                command.Parameters.Add("@dir", SqlDbType.VarChar, 50).Value = _dir;
                command.Parameters.Add("@sexo", SqlDbType.Char, 1).Value = _sexo;
                command.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método InsertarCliente ->" + ex);
            }
        }

        public void EditarIngrediente(int _id, string _cp, string _ed, string _dir)
        {
            try
            {
                objConnection.abrir();
                SqlCommand command = new SqlCommand(
                    "UPDATE Customers SET " +
                    "txtCell_Phone = '" + _cp +
                    "', txtEmail_Direction = '" + _ed +
                    "', txtDirection = '" + _dir +
                    "' WHERE intId_Customer = " + _id, objConnection.conectar);
                command.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método EditarCliente ->" + ex);
            }
        }

        public void EliminarIngrediente(int _id)
        {
            try
            {
                objConnection.abrir();
                string cadena = "ALTER TABLE Orders NOCHECK CONSTRAINT FK_Orders_Customers";
                SqlCommand comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();

                cadena = "DELETE FROM Customers WHERE intId_Customer = " + _id;
                comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();

                cadena = "ALTER TABLE Orders CHECK CONSTRAINT FK_Orders_Customers";
                comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método EditarCliente ->" + ex);
            }
        }
    }
}
