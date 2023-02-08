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

            //guarda los valores de la columna seleccionado
            String id = grid_db.SelectedRows[0].Index.ToString();
            String nombres = Convert.ToString(grid_db.SelectedRows[0].Cells[1].Value);
            String apellidos = Convert.ToString(grid_db.SelectedRows[0].Cells[2].Value);
            String rut = Convert.ToString(grid_db.SelectedRows[0].Cells[3].Value);
            String departamento = Convert.ToString(grid_db.SelectedRows[0].Cells[4].Value);
            String unidad = Convert.ToString(grid_db.SelectedRows[0].Cells[5].Value);
            String tipo_equipo = Convert.ToString(grid_db.SelectedRows[0].Cells[6].Value);
            String marca = Convert.ToString(grid_db.SelectedRows[0].Cells[7].Value);
            String modelo = Convert.ToString(grid_db.SelectedRows[0].Cells[8].Value);
            String serie = Convert.ToString(grid_db.SelectedRows[0].Cells[9].Value);
            String inventario = Convert.ToString(grid_db.SelectedRows[0].Cells[10].Value);
            String usuario = Convert.ToString(grid_db.SelectedRows[0].Cells[11].Value);
            String nombre_equipo = Convert.ToString(grid_db.SelectedRows[0].Cells[12].Value);
            String mac = Convert.ToString(grid_db.SelectedRows[0].Cells[13].Value);
            String memoria_ram = Convert.ToString(grid_db.SelectedRows[0].Cells[14].Value);
            String espacio_disco = Convert.ToString(grid_db.SelectedRows[0].Cells[15].Value);
            String procesador = Convert.ToString(grid_db.SelectedRows[0].Cells[16].Value);
            String version_windows = Convert.ToString(grid_db.SelectedRows[0].Cells[17].Value);
            String version_office = Convert.ToString(grid_db.SelectedRows[0].Cells[18].Value);
            String lojack = Convert.ToString(grid_db.SelectedRows[0].Cells[19].Value);

            //entrega los valores a los campos de modificar
            mod.lblmod_id.Text = id;
            mod.modificar_nombre.Text = nombres;
            mod.modificar_apellido.Text = apellidos;
            mod.modificar_RUT.Text = rut;
            mod.modificarcbox_departamento.Text = departamento;
            mod.modificarcbox_unidad.Text = unidad;
            mod.modificarcbox_tipo_equipo.Text = tipo_equipo;
            mod.modificar_marca.Text = marca;
            mod.modificar_modelo.Text = modelo;
            mod.modificar_serie.Text = serie;
            mod.modificar_inventario.Text = inventario;
            mod.modificar_usuario.Text = usuario;
            mod.modificar_nombre_equipo.Text = nombre_equipo;
            mod.modificar_MAC.Text = mac;
            mod.modificar_RAM.Text = memoria_ram;
            mod.modificar_espacio.Text = espacio_disco;
            mod.modificar_procesador.Text = procesador;
            mod.modificarcbox_vwindows.Text = version_windows;
            mod.modificarcbox_voffice.Text = version_office;
            mod.modificarcbox_lojack.Text = lojack;
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
    }
}
