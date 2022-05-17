using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Aniadir : Form
    {
        public Aniadir()
        {
            InitializeComponent();
        }


        Logica.LogicaOperaciones objL = new Logica.LogicaOperaciones();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objL.InsertarIngrediente(txbCod.Text, txtNombre.Text, int.Parse(txtCantidad.Text), decimal.Parse(txtPrecio.Text));
                MessageBox.Show("Datos ingresados con éxito");

            }
            catch
            {
                MessageBox.Show("No se puede almacenar los datos ingresados");
            }
        }

        private void Aniadir_Load(object sender, EventArgs e)
        {
            txbCod.Text = objL.NuevoIngrediente().ToString();
        }
    }
}
