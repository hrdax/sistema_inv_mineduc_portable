using inventarioportable.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
            //crea un objeto del form modificar
            modificar mod = new modificar();
            foreach(DataGridViewRow row in this.grid_db.SelectedRows)
            {
                mod.lblmod_id.Text = row.Cells[0].Value.ToString();
                
                //mod.modificar_nombre.Text = row.Cells[1].Value.ToString();
            }
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
            this.grid_db.Columns["inventarioid"].Visible = false;
        }

        private void grid_db_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica los indices de las filas si son mayores o igual a 0
            if (e.RowIndex >= 0)
            {
                //crea un objeto row desde las filas del dvg
                DataGridViewRow row = this.grid_db.Rows[e.RowIndex];
                //crea un objeto de form de modificar
                modificar mod = new modificar();
                //entrega los valores a los campos a modificar
                mod.lblmod_id.Text = row.Cells["inventarioid"].Value.ToString();
                mod.modificar_nombre.Text = row.Cells["Nombre"].Value.ToString();
                mod.modificar_apellido.Text = row.Cells["Apellidos"].Value.ToString();
                mod.modificar_RUT.Text = row.Cells["Rut"].Value.ToString();
                mod.modificarcbox_departamento.Text = row.Cells["Departamento"].Value.ToString();
                mod.modificarcbox_unidad.Text = row.Cells["Unidad"].Value.ToString();
                mod.modificarcbox_tipo_equipo.Text = row.Cells["Tipo_de_Equipo"].Value.ToString();
                mod.modificar_marca.Text = row.Cells["Marca"].Value.ToString();
                mod.modificar_modelo.Text = row.Cells["modelo"].Value.ToString();
                mod.modificar_serie.Text = row.Cells["serie"].Value.ToString();
                mod.modificar_inventario.Text = row.Cells["inventario"].Value.ToString();
                mod.modificar_usuario.Text = row.Cells["usuario"].Value.ToString();
                mod.modificar_nombre_equipo.Text = row.Cells["Nombre_de_Equipo"].Value.ToString();
                mod.modificar_MAC.Text = row.Cells["MAC"].Value.ToString();
                mod.modificar_RAM.Text = row.Cells["RAM"].Value.ToString();
                mod.modificar_espacio.Text = row.Cells["Espacio_Disco"].Value.ToString();
                mod.modificar_procesador.Text = row.Cells["Procesador"].Value.ToString();
                mod.modificarcbox_vwindows.Text = row.Cells["Version_Windows"].Value.ToString();
                mod.modificarcbox_voffice.Text = row.Cells["Version_Office"].Value.ToString();
                mod.modificarcbox_lojack.Text = row.Cells["Lojack"].Value.ToString();
                //muestra la ventana de modificar
                mod.Show();

                

            }
        }
    }
}
