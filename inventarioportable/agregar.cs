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
    public partial class agregar : Form
    {

        public agregar()
        {
            InitializeComponent();
        }
        //boton para agregar mas registros
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // crea un objeto de la clase registro
            Registro registro_objeto = new Registro()
            {
                //se le entrega a los atributos del objeto los valores de los inputs
                Nombre = ingreso_nombres.Text,
                Apellidos = ingreso_apellidos.Text,
                Rut = ingreso_RUT.Text,
                Departamento = cbox_departamento.Text,
                Unidad = cbox_unidad.Text,
                Tipo_de_Equipo = cbox_tipo_equipo.Text,
                Marca = ingreso_marca.Text,
                Modelo = ingreso_modelo.Text,
                Serie = ingreso_serie.Text,
                Inventario = ingreso_inventario.Text,
                Usuario = ingreso_usuario.Text,
                Nombre_de_Equipo = ingreso_nombre_equipo.Text,
                MAC = ingreso_MAC.Text,
                RAM = ingreso_RAM.Text,
                Espacio_Disco = ingreso_espacio.Text,
                Procesador = ingreso_procesador.Text,
                Version_Windows = cbox_vwindows.Text,
                Version_Office = cbox_voffice.Text,
                Lojack = cbox_lojack.Text,
            };
            // guarda una respuseta al momento de insertar para poder saber si esta insertando correctamente
            bool resp = controladorregistro.Instancia.insert(registro_objeto);

            MessageBox.Show("Agregado");

        }
    }
}
