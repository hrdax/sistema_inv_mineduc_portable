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
    public partial class verdatos : Form
    {
        public verdatos()
        {
            InitializeComponent();
        }
        //abre form de modificar y le entrega los valores
        private void btn_mod_el_Click(object sender, EventArgs e)
        {
            modificar mod = new modificar();
            mod.modificar_nombre.Text = "alo";
            mod.Show();
        }
    }
}
