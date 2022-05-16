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
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }
        LogicaOperacion objL = new LogicaOperaciones();
        private void Listado_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objL.ListarIngredientes();
        }
    }
}
