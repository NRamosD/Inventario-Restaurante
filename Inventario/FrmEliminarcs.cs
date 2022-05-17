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
    public partial class FrmEliminarcs : Form
    {
        public FrmEliminarcs()
        {
            InitializeComponent();
        }
        Logica.LogicaOperaciones objL = new Logica.LogicaOperaciones();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar los datos del Ingrediente?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    objL.EliminarIngrediente(textBox1.Text);
                    MessageBox.Show("Ingrediente eliminado con éxito");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("No se puede realizar esta acción");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = objL.MostrarDatosIngredientes(textBox1.Text);
            if (tabla.Rows.Count > 0)
            {
                textBox4.Text = tabla.Rows[0][1].ToString();
                textBox2.Text = tabla.Rows[0][2].ToString();
                textBox3.Text = tabla.Rows[0][3].ToString();

                button1.Visible = true;
            }
            else
            {
                MessageBox.Show("Ingrediente no Encontrado");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
