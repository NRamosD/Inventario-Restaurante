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
<<<<<<< HEAD
    public class Operaciones
    {
        conexion objConnection = new conexion();
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable MostrarIngrediente(string _ci)
=======
    public class operaciones
    {
        conexion objConnection = new conexion();

        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable MostrarIngrediente(string _id)
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
        {
            try
            {
                objConnection.abrir();
<<<<<<< HEAD
                SqlCommand comando = new SqlCommand("SELECT * FROM Customers WHERE txtId_Card = '" + _ci + "'", objConnection.conectar);
=======
                SqlCommand comando = new SqlCommand("SELECT * FROM Ingredients WHERE intId_Ingredient = '" + _id + "'", objConnection.conectar);
                //SqlCommand comando = new SqlCommand("SELECT * FROM Ingredients WHERE intId_Ingredient = '4'", objConnection.conectar);
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                Console.WriteLine("->ERROR-> Método MostrarCliente ->" + ex);
=======
                Console.WriteLine("->ERROR-> Método MostrarIngrediente ->" + ex);
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
                return tabla;
            }
        }
        public DataTable MostrarIngredientes()
        {
            try
            {
                objConnection.abrir();
<<<<<<< HEAD
                SqlCommand comando = new SqlCommand("SELECT * FROM Products", objConnection.conectar);
=======
                SqlCommand comando = new SqlCommand("SELECT * FROM Ingredients where intId_Ingredient <> 0 order by 1 asc", objConnection.conectar);
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                Console.WriteLine("->ERROR-> Método MostrarProductos ->" + ex);
=======
                Console.WriteLine("->ERROR-> Método MostrarIngredientes ->" + ex);
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
                return tabla;
            }
        }
        public int CrearNuevoIdIngrediente()
        {
            try
            {
                objConnection.abrir();
<<<<<<< HEAD
                SqlCommand command = new SqlCommand("NewIdCustomer", objConnection.conectar);
=======
                SqlCommand command = new SqlCommand("NewIdIngredient", objConnection.conectar);
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
                comando.CommandType = CommandType.StoredProcedure;
                DataTable id = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(id);
                objConnection.cerrar();
                return Convert.ToInt16(id.Rows[0][0]);
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                Console.WriteLine("->ERROR-> Método CrearNuevoIdCliente ->" + ex);
=======
                Console.WriteLine("->ERROR-> Método CrearNuevoIdIngrediente ->" + ex);
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
                return 0;
            }
        }

        public int ObtenerTotalIngredientes()
        {
            try
            {
                objConnection.abrir();
<<<<<<< HEAD
                SqlCommand command = new SqlCommand("QuantiyProducts", objConnection.conectar);
=======
                SqlCommand command = new SqlCommand("QuantiyIngredients", objConnection.conectar);
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
                comando.CommandType = CommandType.StoredProcedure;
                DataTable id = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(id);

                return Convert.ToInt16(id.Rows[0][0]);
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                Console.WriteLine("->ERROR-> Método ObtenerTotalProductos ->" + ex);
=======
                Console.WriteLine("->ERROR-> Método ObtenerTotalIngredientes ->" + ex);
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
                return 0;
            }
        }

<<<<<<< HEAD
        public void InsertarIngrediente(int _id, string _ci, string _fn, string _ln, string _cp, string _ed, string _dir, string _sexo)
=======
        public void InsertarIngrediente(string _id, string _name, string _quantity, string _price)
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
        {
            try
            {
                objConnection.abrir();
                SqlCommand command = new SqlCommand(
<<<<<<< HEAD
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
=======
                    "INSERT INTO [dbo].[Ingredients] (intId_Ingredient, txtName, bytIngredient_Quantity, tmnUnitPrice)" +
                    "VALUES(@id, @name, @quantity, @price)", objConnection.conectar);
                command.Parameters.Add("@id", SqlDbType.Int).Value = _id;
                command.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = _name;
                command.Parameters.Add("@quantity", SqlDbType.Int).Value = _quantity;
                command.Parameters.Add("@price", SqlDbType.Money).Value = _price;
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
                command.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
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
=======
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
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
            }
        }

        public void EliminarIngrediente(int _id)
        {
            try
            {
                objConnection.abrir();
<<<<<<< HEAD
                string cadena = "ALTER TABLE Orders NOCHECK CONSTRAINT FK_Orders_Customers";
                SqlCommand comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();

                cadena = "DELETE FROM Customers WHERE intId_Customer = " + _id;
                comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();

                cadena = "ALTER TABLE Orders CHECK CONSTRAINT FK_Orders_Customers";
=======
                string cadena = "ALTER TABLE ProductsIngredients NOCHECK CONSTRAINT FK_Ingredients_ProductsIngredients";
                SqlCommand comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();

                cadena = "DELETE FROM Ingredients WHERE intId_Ingredient = " + _id;
                comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();

                cadena = "ALTER TABLE ProductsIngredients CHECK CONSTRAINT FK_Ingredients_ProductsIngredients";
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
                comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                Console.WriteLine("->ERROR-> Método EditarCliente ->" + ex);
=======
                Console.WriteLine("->ERROR-> Método EliminarIngrediente ->" + ex);
>>>>>>> 71eb87ca2865d8a4d2f4a885db3facacc18590b7
            }
        }
    }
}
