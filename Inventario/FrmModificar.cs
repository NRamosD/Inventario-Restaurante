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
    public partial class FrmModificar : Form
    {
        public FrmModificar()
        {
            InitializeComponent();
        }
        Logica.LogicaOperaciones objL = new Logica.LogicaOperaciones();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea confirmar los cambios?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    objL.EditarIngrediente(textBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text);
                    MessageBox.Show("Cambios efectuados exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se han realizado los cambios");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("No se puede realizar esta acción");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();
            tabla = objL.MostrarDatosIngredientes(textBox4.Text);

            if (tabla.Rows.Count > 0)
            {
                textBox1.Text = tabla.Rows[0][1].ToString();
                textBox2.Text = tabla.Rows[0][2].ToString();
                textBox3.Text = tabla.Rows[0][3].ToString();
                button1.Visible = true;
            }
            else
            {
                MessageBox.Show("Ingrediente no Encontrado");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {

        }
    }
}
