﻿namespace inventarioportable
{
    partial class verdatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid_db = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mod_el = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_borrartodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_db)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_db
            // 
            this.grid_db.BackgroundColor = System.Drawing.Color.Snow;
            this.grid_db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_db.Location = new System.Drawing.Point(12, 65);
            this.grid_db.Name = "grid_db";
            this.grid_db.ReadOnly = true;
            this.grid_db.RowHeadersVisible = false;
            this.grid_db.Size = new System.Drawing.Size(932, 486);
            this.grid_db.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(848, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para modificar o elminar un registro puede hacer doble click en el mismo o selecc" +
    "ionarlo y presionar el botón de Modificar/Eliminar";
            // 
            // btn_mod_el
            // 
            this.btn_mod_el.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_mod_el.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mod_el.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mod_el.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod_el.Location = new System.Drawing.Point(12, 12);
            this.btn_mod_el.Name = "btn_mod_el";
            this.btn_mod_el.Size = new System.Drawing.Size(151, 34);
            this.btn_mod_el.TabIndex = 2;
            this.btn_mod_el.Text = "Modificar/Eliminar";
            this.btn_mod_el.UseVisualStyleBackColor = false;
            this.btn_mod_el.Click += new System.EventHandler(this.btn_mod_el_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.Location = new System.Drawing.Point(420, 12);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(138, 34);
            this.btn_excel.TabIndex = 3;
            this.btn_excel.Text = "Exportar a Excel";
            this.btn_excel.UseVisualStyleBackColor = false;
            // 
            // btn_borrartodo
            // 
            this.btn_borrartodo.BackColor = System.Drawing.Color.Red;
            this.btn_borrartodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrartodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_borrartodo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrartodo.Location = new System.Drawing.Point(806, 12);
            this.btn_borrartodo.Name = "btn_borrartodo";
            this.btn_borrartodo.Size = new System.Drawing.Size(138, 34);
            this.btn_borrartodo.TabIndex = 4;
            this.btn_borrartodo.Text = "Borrar TODO";
            this.btn_borrartodo.UseVisualStyleBackColor = false;
            this.btn_borrartodo.Click += new System.EventHandler(this.btn_borrartodo_Click);
            // 
            // verdatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(956, 630);
            this.Controls.Add(this.btn_borrartodo);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_mod_el);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_db);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "verdatos";
            this.Text = "verdatos";
            this.Load += new System.EventHandler(this.verdatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mod_el;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_borrartodo;
        public System.Windows.Forms.DataGridView grid_db;
    }
}