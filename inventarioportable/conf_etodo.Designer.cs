namespace inventarioportable
{
    partial class conf_etodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conf_etodo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_tsi = new System.Windows.Forms.Button();
            this.btn_tno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Se borrarán todos los registros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Desea Continuar?";
            // 
            // btn_tsi
            // 
            this.btn_tsi.Location = new System.Drawing.Point(64, 123);
            this.btn_tsi.Name = "btn_tsi";
            this.btn_tsi.Size = new System.Drawing.Size(75, 23);
            this.btn_tsi.TabIndex = 2;
            this.btn_tsi.Text = "Sí";
            this.btn_tsi.UseVisualStyleBackColor = true;
            this.btn_tsi.Click += new System.EventHandler(this.btn_tsi_Click);
            // 
            // btn_tno
            // 
            this.btn_tno.Location = new System.Drawing.Point(249, 123);
            this.btn_tno.Name = "btn_tno";
            this.btn_tno.Size = new System.Drawing.Size(75, 23);
            this.btn_tno.TabIndex = 3;
            this.btn_tno.Text = "No";
            this.btn_tno.UseVisualStyleBackColor = true;
            this.btn_tno.Click += new System.EventHandler(this.btn_tno_Click);
            // 
            // conf_etodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 160);
            this.Controls.Add(this.btn_tno);
            this.Controls.Add(this.btn_tsi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "conf_etodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tsi;
        private System.Windows.Forms.Button btn_tno;
    }
}