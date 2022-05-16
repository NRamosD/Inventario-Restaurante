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
        LogicaOperacion objL = new LogicaOperaciones();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar los datos del cliente?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    objL.EliminarCliente(textBox1.Text);
                    MessageBox.Show("Cliente eliminado con éxito");
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
            tabla = objL.MostrarDatosProducto(int.Parse(textBox1.Text));
            if (tabla.Rows.Count > 0)
            {
                byte[] arr;
                textBox1.Text = tabla.Rows[0][0].ToString();
                textBox4.Text = tabla.Rows[0][1].ToString();
                textBox2.Text = tabla.Rows[0][2].ToString();
                textBox3.Text = tabla.Rows[0][3].ToString();
                arr = (byte[])tabla.Rows[0][5];
                button1.Visible = true;
            }
            else
            {
                MessageBox.Show("Producto no Encontrado");
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
