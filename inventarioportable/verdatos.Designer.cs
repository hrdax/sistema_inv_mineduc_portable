namespace inventarioportable
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
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_borrartodo = new System.Windows.Forms.Button();
            this.cbox_directorio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_filtroN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RB_Nombre = new System.Windows.Forms.RadioButton();
            this.RB_Rutb = new System.Windows.Forms.RadioButton();
            this.RB_Marca = new System.Windows.Forms.RadioButton();
            this.RB_Tipo_Equipo = new System.Windows.Forms.RadioButton();
            this.lbl_filtrado = new System.Windows.Forms.Label();
            this.cboxf_TE = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_db)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_db
            // 
            this.grid_db.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_db.BackgroundColor = System.Drawing.Color.Snow;
            this.grid_db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_db.Location = new System.Drawing.Point(12, 65);
            this.grid_db.Name = "grid_db";
            this.grid_db.ReadOnly = true;
            this.grid_db.RowHeadersVisible = false;
            this.grid_db.Size = new System.Drawing.Size(932, 486);
            this.grid_db.TabIndex = 0;
            this.grid_db.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_db_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(911, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para modificar o elminar un registro debe hacer doble click en el mismo  y se des" +
    "plegará una ventana con las opciones de modificar o eliminar.";
            // 
            // btn_excel
            // 
            this.btn_excel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_excel.BackColor = System.Drawing.Color.Transparent;
            this.btn_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_excel.Location = new System.Drawing.Point(371, 13);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(165, 40);
            this.btn_excel.TabIndex = 3;
            this.btn_excel.Text = "Exportar a Excel";
            this.btn_excel.UseVisualStyleBackColor = false;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click_1);
            // 
            // btn_borrartodo
            // 
            this.btn_borrartodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_borrartodo.BackColor = System.Drawing.Color.Transparent;
            this.btn_borrartodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrartodo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrartodo.ForeColor = System.Drawing.Color.Red;
            this.btn_borrartodo.Location = new System.Drawing.Point(779, 13);
            this.btn_borrartodo.Name = "btn_borrartodo";
            this.btn_borrartodo.Size = new System.Drawing.Size(165, 40);
            this.btn_borrartodo.TabIndex = 4;
            this.btn_borrartodo.Text = "Borrar TODO";
            this.btn_borrartodo.UseVisualStyleBackColor = false;
            this.btn_borrartodo.Click += new System.EventHandler(this.btn_borrartodo_Click);
            // 
            // cbox_directorio
            // 
            this.cbox_directorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbox_directorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_directorio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbox_directorio.FormattingEnabled = true;
            this.cbox_directorio.Items.AddRange(new object[] {
            "Escritorio",
            "Carpeta del software"});
            this.cbox_directorio.Location = new System.Drawing.Point(554, 23);
            this.cbox_directorio.Name = "cbox_directorio";
            this.cbox_directorio.Size = new System.Drawing.Size(121, 21);
            this.cbox_directorio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "¿Dónde desea guardar el informe?";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Escritorio por defecto)";
            // 
            // txt_filtroN
            // 
            this.txt_filtroN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filtroN.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtroN.Location = new System.Drawing.Point(209, 23);
            this.txt_filtroN.Multiline = true;
            this.txt_filtroN.Name = "txt_filtroN";
            this.txt_filtroN.Size = new System.Drawing.Size(144, 27);
            this.txt_filtroN.TabIndex = 8;
            this.txt_filtroN.TextChanged += new System.EventHandler(this.txt_filtroN_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filtrar por";
            // 
            // RB_Nombre
            // 
            this.RB_Nombre.AutoSize = true;
            this.RB_Nombre.Location = new System.Drawing.Point(15, 23);
            this.RB_Nombre.Name = "RB_Nombre";
            this.RB_Nombre.Size = new System.Drawing.Size(62, 17);
            this.RB_Nombre.TabIndex = 10;
            this.RB_Nombre.TabStop = true;
            this.RB_Nombre.Text = "Nombre";
            this.RB_Nombre.UseVisualStyleBackColor = true;
            this.RB_Nombre.CheckedChanged += new System.EventHandler(this.RB_Nombre_CheckedChanged);
            // 
            // RB_Rutb
            // 
            this.RB_Rutb.AutoSize = true;
            this.RB_Rutb.Location = new System.Drawing.Point(15, 43);
            this.RB_Rutb.Name = "RB_Rutb";
            this.RB_Rutb.Size = new System.Drawing.Size(42, 17);
            this.RB_Rutb.TabIndex = 11;
            this.RB_Rutb.TabStop = true;
            this.RB_Rutb.Text = "Rut";
            this.RB_Rutb.UseVisualStyleBackColor = true;
            this.RB_Rutb.CheckedChanged += new System.EventHandler(this.RB_Rut);
            // 
            // RB_Marca
            // 
            this.RB_Marca.AutoSize = true;
            this.RB_Marca.Location = new System.Drawing.Point(83, 43);
            this.RB_Marca.Name = "RB_Marca";
            this.RB_Marca.Size = new System.Drawing.Size(55, 17);
            this.RB_Marca.TabIndex = 13;
            this.RB_Marca.TabStop = true;
            this.RB_Marca.Text = "Marca";
            this.RB_Marca.UseVisualStyleBackColor = true;
            this.RB_Marca.CheckedChanged += new System.EventHandler(this.RB_Marca_CheckedChanged);
            // 
            // RB_Tipo_Equipo
            // 
            this.RB_Tipo_Equipo.AutoSize = true;
            this.RB_Tipo_Equipo.Location = new System.Drawing.Point(83, 23);
            this.RB_Tipo_Equipo.Name = "RB_Tipo_Equipo";
            this.RB_Tipo_Equipo.Size = new System.Drawing.Size(97, 17);
            this.RB_Tipo_Equipo.TabIndex = 12;
            this.RB_Tipo_Equipo.TabStop = true;
            this.RB_Tipo_Equipo.Text = "Tipo de Equipo";
            this.RB_Tipo_Equipo.UseVisualStyleBackColor = true;
            this.RB_Tipo_Equipo.CheckedChanged += new System.EventHandler(this.RB_TipoEquipo);
            // 
            // lbl_filtrado
            // 
            this.lbl_filtrado.AutoSize = true;
            this.lbl_filtrado.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtrado.Location = new System.Drawing.Point(72, 5);
            this.lbl_filtrado.Name = "lbl_filtrado";
            this.lbl_filtrado.Size = new System.Drawing.Size(0, 15);
            this.lbl_filtrado.TabIndex = 14;
            // 
            // cboxf_TE
            // 
            this.cboxf_TE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxf_TE.FormattingEnabled = true;
            this.cboxf_TE.Items.AddRange(new object[] {
            "",
            "Notebook",
            "Escritorio",
            "Data-Show",
            "Impresora",
            "Escáner",
            "Data/Proyector"});
            this.cboxf_TE.Location = new System.Drawing.Point(219, 26);
            this.cboxf_TE.Name = "cboxf_TE";
            this.cboxf_TE.Size = new System.Drawing.Size(121, 21);
            this.cboxf_TE.TabIndex = 15;
            this.cboxf_TE.Visible = false;
            this.cboxf_TE.TextChanged += new System.EventHandler(this.cboxf_TE_TextChanged);
            // 
            // verdatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(956, 630);
            this.Controls.Add(this.cboxf_TE);
            this.Controls.Add(this.lbl_filtrado);
            this.Controls.Add(this.RB_Marca);
            this.Controls.Add(this.RB_Tipo_Equipo);
            this.Controls.Add(this.RB_Rutb);
            this.Controls.Add(this.RB_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_filtroN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_directorio);
            this.Controls.Add(this.btn_borrartodo);
            this.Controls.Add(this.btn_excel);
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
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_borrartodo;
        public System.Windows.Forms.DataGridView grid_db;
        private System.Windows.Forms.ComboBox cbox_directorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_filtroN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RB_Nombre;
        private System.Windows.Forms.RadioButton RB_Rutb;
        private System.Windows.Forms.RadioButton RB_Marca;
        private System.Windows.Forms.RadioButton RB_Tipo_Equipo;
        private System.Windows.Forms.Label lbl_filtrado;
        private System.Windows.Forms.ComboBox cboxf_TE;
    }
}