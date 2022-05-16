namespace Inventario
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnListadoIngredientes_Click(object sender, EventArgs e)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
            Listado frmListado = new Listado();
            frmListado.TopLevel = false;
            frmListado.FormBorderStyle = FormBorderStyle.None;
            frmListado.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(frmListado);
            frmListado.Show();
        }

        private void btnAniadirIngrediente_Click(object sender, EventArgs e)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
            Aniadir frmAniadir = new Aniadir();
            frmAniadir.TopLevel = false;
            frmAniadir.FormBorderStyle = FormBorderStyle.None;
            frmAniadir.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(frmAniadir);
            frmAniadir.Show();
        }
    }
}