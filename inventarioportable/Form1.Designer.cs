namespace inventarioportable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_verdatos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_opcion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_lateral.SuspendLayout();
            this.panel_opcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.SystemColors.Control;
            this.panel_lateral.Controls.Add(this.btn_agregar);
            this.panel_lateral.Controls.Add(this.btn_verdatos);
            this.panel_lateral.Controls.Add(this.panel2);
            this.panel_lateral.Controls.Add(this.panel1);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(271, 661);
            this.panel_lateral.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(3, 337);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(264, 43);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_verdatos
            // 
            this.btn_verdatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_verdatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_verdatos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verdatos.Location = new System.Drawing.Point(4, 288);
            this.btn_verdatos.Name = "btn_verdatos";
            this.btn_verdatos.Size = new System.Drawing.Size(264, 43);
            this.btn_verdatos.TabIndex = 2;
            this.btn_verdatos.Text = "Ver Datos";
            this.btn_verdatos.UseVisualStyleBackColor = true;
            this.btn_verdatos.Click += new System.EventHandler(this.btn_verdatos_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(79, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(50, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 150);
            this.panel1.TabIndex = 0;
            // 
            // panel_opcion
            // 
            this.panel_opcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_opcion.Controls.Add(this.label1);
            this.panel_opcion.Location = new System.Drawing.Point(278, 13);
            this.panel_opcion.Name = "panel_opcion";
            this.panel_opcion.Size = new System.Drawing.Size(956, 630);
            this.panel_opcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Inventariado de Hardware";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1244, 661);
            this.Controls.Add(this.panel_opcion);
            this.Controls.Add(this.panel_lateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.panel_lateral.ResumeLayout(false);
            this.panel_opcion.ResumeLayout(false);
            this.panel_opcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_verdatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_opcion;
        private System.Windows.Forms.Label label1;
    }
}

