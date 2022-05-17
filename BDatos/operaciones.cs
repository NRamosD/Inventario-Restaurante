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
    public class operaciones
    {
        conexion objConnection = new conexion();

        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable MostrarIngrediente(string _id)
        {
            try
            {
                objConnection.abrir();
                SqlCommand comando = new SqlCommand("SELECT * FROM Ingredients WHERE intId_Ingredient = '" + _id + "'", objConnection.conectar);
                //SqlCommand comando = new SqlCommand("SELECT * FROM Ingredients WHERE intId_Ingredient = '4'", objConnection.conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método MostrarIngrediente ->" + ex);
                return tabla;
            }
        }
        public DataTable MostrarIngredientes()
        {
            try
            {
                objConnection.abrir();
                SqlCommand comando = new SqlCommand("SELECT * FROM Ingredients where intId_Ingredient <> 0 order by 1 asc", objConnection.conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método MostrarIngredientes ->" + ex);
                return tabla;
            }
        }
        public int CrearNuevoIdIngrediente()
        {
            try
            {
                objConnection.abrir();
                SqlCommand command = new SqlCommand("NewIdIngredient", objConnection.conectar);
                comando.CommandType = CommandType.StoredProcedure;
                DataTable id = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(id);
                objConnection.cerrar();
                return Convert.ToInt16(id.Rows[0][0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método CrearNuevoIdIngrediente ->" + ex);
                return 0;
            }
        }

        public int ObtenerTotalIngredientes()
        {
            try
            {
                objConnection.abrir();
                SqlCommand command = new SqlCommand("QuantiyIngredients", objConnection.conectar);
                comando.CommandType = CommandType.StoredProcedure;
                DataTable id = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(id);

                return Convert.ToInt16(id.Rows[0][0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método ObtenerTotalIngredientes ->" + ex);
                return 0;
            }
        }

        public void InsertarIngrediente(string _id, string _name, string _quantity, string _price)
        {
            try
            {
                objConnection.abrir();
                SqlCommand command = new SqlCommand(
                    "INSERT INTO [dbo].[Ingredients] (intId_Ingredient, txtName, bytIngredient_Quantity, tmnUnitPrice)" +
                    "VALUES(@id, @name, @quantity, @price)", objConnection.conectar);
                command.Parameters.Add("@id", SqlDbType.Int).Value = _id;
                command.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = _name;
                command.Parameters.Add("@quantity", SqlDbType.Int).Value = _quantity;
                command.Parameters.Add("@price", SqlDbType.Money).Value = _price;
                command.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método InsertarIngrediente ->" + ex);
            }
        }

        public void EditarIngrediente(string _id, string _name, string _quantity, string _price)
        {
            try
            {
                                objConnection.abrir();
                                SqlCommand command = new SqlCommand(
                                    "UPDATE Ingredients SET " +
                                    "txtName = '" + _name +
                                    "', bytIngredient_Quantity = '" + _quantity +
                                    "', tmnUnitPrice = '" + _price +
                                    "' WHERE intId_Ingredient = " + _id, objConnection.conectar);
                                command.ExecuteNonQuery();
                                objConnection.cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método EditarIngrediente ->" + ex);
            }
        }

        public void EliminarIngrediente(int _id)
        {
            try
            {
                objConnection.abrir();
                string cadena = "ALTER TABLE ProductsIngredients NOCHECK CONSTRAINT FK_Ingredients_ProductsIngredients";
                SqlCommand comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();

                cadena = "DELETE FROM Ingredients WHERE intId_Ingredient = " + _id;
                comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();

                cadena = "ALTER TABLE ProductsIngredients CHECK CONSTRAINT FK_Ingredients_ProductsIngredients";
                comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("->ERROR-> Método EliminarIngrediente ->" + ex);
            }
        }
    }
}
