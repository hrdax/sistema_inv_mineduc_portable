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
    public partial class modificar : Form
    {
        public modificar()
        {
            InitializeComponent();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            confirm_eliminar conf = new confirm_eliminar();
            conf.lbl_id.Text = lblmod_id.Text;
            conf.lbl_nombre.Text = modificar_nombre.Text;
            conf.Show();
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            // crea un objeto de la clase registro
            Registro registro_objeto = new Registro()
            {
                //se le entrega a los atributos del objeto los valores de los inputs
                inventarioid = Int32.Parse(lblmod_id.Text),
                Nombre = modificar_nombre.Text,
                Apellidos = modificar_apellido.Text,
                Rut = modificar_RUT.Text,
                Departamento = modificarcbox_departamento.Text,
                Unidad = modificarcbox_unidad.Text,
                Tipo_de_Equipo = modificarcbox_tipo_equipo.Text,
                Marca = modificar_marca.Text,
                Modelo = modificar_modelo.Text,
                Serie = modificar_serie.Text,
                Inventario = modificar_inventario.Text,
                Usuario = modificar_usuario.Text,
                Nombre_de_Equipo = modificar_nombre_equipo.Text,
                MAC = modificar_MAC.Text,
                RAM = modificar_RAM.Text,
                Espacio_Disco = modificar_espacio.Text,
                Procesador = modificar_procesador.Text,
                Version_Windows = modificarcbox_vwindows.Text,
                Version_Office = modificarcbox_voffice.Text,
                Lojack = modificarcbox_lojack.Text,
            };
            // guarda una respuseta al momento de insertar para poder saber si esta insertando correctamente
            bool resp = controladorregistro.Instancia.modificar(registro_objeto);
            MessageBox.Show("Registro modificado");
            //limpia los campos
            this.Close();
            
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
