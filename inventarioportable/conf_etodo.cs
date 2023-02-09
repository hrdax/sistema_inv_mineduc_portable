using inventarioportable.Controlador;
using inventarioportable.Modelo;
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
    public partial class conf_etodo : Form
    {
        private IForm _form;
        public conf_etodo(IForm form)
        {
            InitializeComponent();
            _form = form;
        }

        private void btn_tno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tsi_Click(object sender, EventArgs e)
        {

            //eliminara todo desde el metodo
            bool resp = controladorregistro.Instancia.eliminarTODO();
            MessageBox.Show("Registros eliminados");
            this.Close();
            _form.listar();

        }
    }
}
