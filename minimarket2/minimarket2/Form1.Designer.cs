namespace minimarket2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.botonInicio = new System.Windows.Forms.Button();
            this.botonProveedores = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.inicioProveedor1 = new minimarket2.InicioProveedor();
            this.inicioInicio1 = new minimarket2.inicioInicio();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sidePanel.Controls.Add(this.botonInicio);
            this.sidePanel.Controls.Add(this.botonProveedores);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 515);
            this.sidePanel.TabIndex = 0;
            // 
            // botonInicio
            // 
            this.botonInicio.Location = new System.Drawing.Point(25, 119);
            this.botonInicio.Name = "botonInicio";
            this.botonInicio.Size = new System.Drawing.Size(136, 42);
            this.botonInicio.TabIndex = 2;
            this.botonInicio.Text = "Inicio";
            this.botonInicio.UseVisualStyleBackColor = true;
            this.botonInicio.Click += new System.EventHandler(this.botonInicio_Click);
            // 
            // botonProveedores
            // 
            this.botonProveedores.Location = new System.Drawing.Point(25, 366);
            this.botonProveedores.Name = "botonProveedores";
            this.botonProveedores.Size = new System.Drawing.Size(136, 42);
            this.botonProveedores.TabIndex = 1;
            this.botonProveedores.Text = "Proveedores";
            this.botonProveedores.UseVisualStyleBackColor = true;
            this.botonProveedores.Click += new System.EventHandler(this.botonProveedores_Click);
            // 
            // inicioProveedor1
            // 
            this.inicioProveedor1.Location = new System.Drawing.Point(195, 0);
            this.inicioProveedor1.Name = "inicioProveedor1";
            this.inicioProveedor1.Size = new System.Drawing.Size(787, 515);
            this.inicioProveedor1.TabIndex = 1;
            // 
            // inicioInicio1
            // 
            this.inicioInicio1.Location = new System.Drawing.Point(195, -3);
            this.inicioInicio1.Name = "inicioInicio1";
            this.inicioInicio1.Size = new System.Drawing.Size(787, 518);
            this.inicioInicio1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 515);
            this.Controls.Add(this.inicioInicio1);
            this.Controls.Add(this.inicioProveedor1);
            this.Controls.Add(this.sidePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button botonInicio;
        private System.Windows.Forms.Button botonProveedores;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private InicioProveedor inicioProveedor1;
        private inicioInicio inicioInicio1;
    }
}

