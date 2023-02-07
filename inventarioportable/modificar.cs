using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventarioportable
{
    public partial class modificar : Form
    {
        public modificar()
        {
            InitializeComponent();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            confirm_eliminar conf = new confirm_eliminar();
            conf.Show();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro modificado");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
