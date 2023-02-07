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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_verdatos_Click(object sender, EventArgs e)
        {
            //llama a la funcion que mostrara el panel seleccionado
            this.abrirpanel(new verdatos());
        }
        //crea form nulo
        private Form formactivo = null;
        //funcion que abrira la opcion del menu
        private void abrirpanel(Form formhijo)
        {
            //si el formulario activo no es nulo cerrara el formulario
            if (formactivo != null)
                formactivo.Close();
            // guarda el formhijo en el form activo para que ya no quede nulo
            formactivo = formhijo;
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panel_opcion.Controls.Add(formhijo);
            panel_opcion.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.abrirpanel(new agregar());
        }
    }
}
