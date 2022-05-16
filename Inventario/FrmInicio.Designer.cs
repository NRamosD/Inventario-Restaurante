namespace Inventario
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAniadirIngrediente = new System.Windows.Forms.Button();
            this.btnListadoIngredientes = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAniadirIngrediente);
            this.panel1.Controls.Add(this.btnListadoIngredientes);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 571);
            this.panel1.TabIndex = 0;
            // 
            // btnAniadirIngrediente
            // 
            this.btnAniadirIngrediente.Location = new System.Drawing.Point(3, 87);
            this.btnAniadirIngrediente.Name = "btnAniadirIngrediente";
            this.btnAniadirIngrediente.Size = new System.Drawing.Size(215, 78);
            this.btnAniadirIngrediente.TabIndex = 8;
            this.btnAniadirIngrediente.Text = "Añadir";
            this.btnAniadirIngrediente.UseVisualStyleBackColor = true;
            this.btnAniadirIngrediente.Click += new System.EventHandler(this.btnAniadirIngrediente_Click);
            // 
            // btnListadoIngredientes
            // 
            this.btnListadoIngredientes.Location = new System.Drawing.Point(3, 3);
            this.btnListadoIngredientes.Name = "btnListadoIngredientes";
            this.btnListadoIngredientes.Size = new System.Drawing.Size(215, 78);
            this.btnListadoIngredientes.TabIndex = 7;
            this.btnListadoIngredientes.Text = "Listado";
            this.btnListadoIngredientes.UseVisualStyleBackColor = true;
            this.btnListadoIngredientes.Click += new System.EventHandler(this.btnListadoIngredientes_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(6, 171);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(215, 78);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 255);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(215, 78);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 517);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(212, 51);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(221, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(671, 571);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 571);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInicio";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnCerrarSesion;
        private Panel PanelPrincipal;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAniadirIngrediente;
        private Button btnListadoIngredientes;
    }
}