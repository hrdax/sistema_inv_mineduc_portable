using inventarioportable.Controlador;
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
        //boton que borra todos los registros
        private void btn_borrartodo_Click(object sender, EventArgs e)
        {
            conf_etodo conftodo = new conf_etodo();
            conftodo.Show();
        }
        //funcion listar que limpia el datagridview y le pasa la lista de la db
        public void listar()
        {
            grid_db.DataSource = null;
            grid_db.DataSource = controladorregistro.Instancia.list();
        }
        //llama a la funcion listar cada vez que inicia carga verdatos
        private void verdatos_Load(object sender, EventArgs e)
        {
            listar();
        }
    }
}
