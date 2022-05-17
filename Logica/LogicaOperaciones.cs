using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BDatos;

namespace Logica
{
    public class LogicaOperaciones
    {
        private operaciones objOpe = new operaciones();
        DataTable tabla = new DataTable();
        public DataTable MostrarDatosIngredientes(int _id)
        {
            DataTable tabla = new DataTable();
            tabla = objOpe.MostrarIngrediente(_id);
            return tabla;
        }

        public DataTable MostrarDatosIngredientes()
        {
            DataTable tabla = new DataTable();
            tabla = objOpe.MostrarIngredientes();
            return tabla;
        }

        public int ObterTotalIng()
        {
            return objOpe.ObtenerTotalIngredientes();
        }

        public int NuevoIngrediente()
        {
            return objOpe.CrearNuevoIdIngrediente();
        }

        public void InsertarIngrediente(string _id, string _nom, int _cant, decimal _precio_unit)
        {
            objOpe.InsertarIngrediente(Convert.ToInt16(_id), _nom, Convert.ToInt16(_cant), _precio_unit);
        }

        public void EditarIngrediente(string _id, string _nom, int _cant, decimal _precio_unit)
        {
            objOpe.EditarIngrediente(Convert.ToInt16(_id), _nom, Convert.ToInt16(_cant), _precio_unit);
        }

        public void EliminarIngrediente(string _id)
        {
            objOpe.EliminarIngrediente(Convert.ToInt16(_id));   
        }
    }   
}
