using inventarioportable.Controlador;
using Microsoft.Office.Interop.Excel;
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
using inventarioportable.Modelo;
using System.IO;
using System.Runtime.InteropServices;

namespace inventarioportable
{
    public partial class verdatos : Form, IForm
    {
        
        
        public verdatos()
        {
            InitializeComponent();
        }
        //metodo para el hover
        private void Hover()
        {
            hover.Hover(btn_excel, "Exportar a Excel");
            hover.Hover(btn_borrartodo, "Borrar TODO");
        }

        //abre form de modificar y le entrega los valores
        private void btn_mod_el_Click(object sender, EventArgs e)
        {
            //crea un objeto del form modificar
            modificar mod = new modificar(this);
            string id = grid_db.SelectedRows[0].Cells[0].Value.ToString();
            List<Registro> registro = controladorregistro.Instancia.listuno(id);
            mod.lblmod_id.Text = registro[0].ToString();
            mod.modificar_nombre.Text = registro[1].ToString();
            mod.Show();
        }
        //boton que borra todos los registros
        private void btn_borrartodo_Click(object sender, EventArgs e)
        {
            //crea un objeto del form y pasa la interfaz con la funcion
            conf_etodo conftodo = new conf_etodo(this);
            conftodo.Show();

        }
        //funcion listar que limpia el datagridview y le pasa la lista de la db
        public void listar()
        {
            grid_db.DataSource = null;
            grid_db.DataSource = controladorregistro.Instancia.list();
            this.grid_db.Columns["inventarioid"].Visible = false;
        }
        //llama a la funcion listar cada vez que inicia carga verdatos
        private void verdatos_Load(object sender, EventArgs e)
        {
            Hover();
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
                modificar mod = new modificar(this);
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

        private void btn_excel_Click_1(object sender, EventArgs e)
        {
            // guarda ruta hacia el escritorio
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // guarda ruta actual
            string ruta = Directory.GetCurrentDirectory();

            //crea una nueva app excel
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            
            // crea un nuevo libro excel
            Workbook libroexcel = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            // crea una nueva hoja excel
            Worksheet hojaexcel = (Worksheet)excel.ActiveSheet;
            

            //no abre el excel al momento de crearlo
            excel.Visible = false;

            // recorre todas las columnas en el datagridview
            foreach(DataGridViewColumn column in grid_db.Columns)
            {
                // recorre las celdas titulares
                hojaexcel.Cells[1, column.Index + 2] = column.HeaderText;
                //recorre las filas
                foreach(DataGridViewRow fila in grid_db.Rows)
                {
                   // recorre las celdas con los valores ingresados en el datagridview
                    hojaexcel.Cells[fila.Index + 2, column.Index + 2] = fila.Cells[column.Index].Value;
                    
                }
            }

            

            // crea rango para las celdas
            Microsoft.Office.Interop.Excel.Range range = hojaexcel.UsedRange;
            // especifica que los bordes sean continuos
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            //especifica que el grosor del borde sea delgado
            range.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            //Pone el color de las celdas como gris
            range.Interior.Color = Color.DarkGray;

            // crea rango para las celdas titulas desde el A1 AL T1
            Microsoft.Office.Interop.Excel.Range rangeheader = hojaexcel.get_Range("B1:U1");
            //le da estilo negrita a las celdas titulares
            rangeheader.Font.Bold = (int)Microsoft.Office.Core.MsoTriState.msoTrue;
            //le da color gris a las celdas titualres
            rangeheader.Interior.Color = Color.Gray;


            
            if(cbox_directorio.Text == "Escritorio" || cbox_directorio.Text == "")
            {
                //guarda el excel en la ruta
                libroexcel.SaveAs(desktop + "\\Inventario.xlsx");
            }
            else if(cbox_directorio.Text == "Carpeta del software")
            {
                libroexcel.SaveAs(ruta + "\\Inventario.xlsx");
            }
            //cierra el excel
            libroexcel.Close();
            // finaliza la application
            excel.Quit();
            //informa que se ha creado
            MessageBox.Show("Se ha exportado a Excel");
        }
        //filtrado por nombre
        private void txt_filtroN_TextChanged(object sender, EventArgs e)
        {
            ////si el textbox esta vacio dejara en nulo la celda actual
            //if(txt_filtroN.Text != "")
            //{
            //    grid_db.CurrentCell = null;
            //    //for que recorrera las filas y las ocultara
            //    foreach(DataGridViewRow row in grid_db.Rows)
            //    {
            //        row.Visible = false;
            //    }
            //    //for que recorrera las filas
            //    foreach (DataGridViewRow row in grid_db.Rows)
            //    {
            //        //for que recorrera las celdas
            //        foreach (DataGridViewCell cell in row.Cells)
            //        {
            //            //si el campo de nombre es igual a lo excrito en el textbox mostrara solo esos datos
            //            if ((row.Cells[1].Value.ToString().ToUpper()).IndexOf(txt_filtroN.Text.ToUpper()) == 0)
            //            {
            //                //mostrara los datos
            //                row.Visible = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    //si esta vacio muestra todos los datos
            //    listar();
            //}
        }

        private void RB_Nombre_CheckedChanged(object sender, EventArgs e)
        {
            //si el textbox esta vacio dejara en nulo la celda actual
            if (txt_filtroN.Text != "")
            {
                grid_db.CurrentCell = null;
                //for que recorrera las filas y las ocultara
                foreach (DataGridViewRow row in grid_db.Rows)
                {
                    row.Visible = false;
                }
                //for que recorrera las filas
                foreach (DataGridViewRow row in grid_db.Rows)
                {
                    //for que recorrera las celdas
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //si el campo de nombre es igual a lo excrito en el textbox mostrara solo esos datos
                        if ((row.Cells[1].Value.ToString().ToUpper()).IndexOf(txt_filtroN.Text.ToUpper()) == 0)
                        {
                            //mostrara los datos
                            row.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                //si esta vacio muestra todos los datos
                listar();
            }
        }

        

        private void RB_TipoEquipo(object sender, EventArgs e)
        {
            //si el textbox esta vacio dejara en nulo la celda actual
            if (txt_filtroN.Text != "")
            {
                grid_db.CurrentCell = null;
                //for que recorrera las filas y las ocultara
                foreach (DataGridViewRow row in grid_db.Rows)
                {
                    row.Visible = false;
                }
                //for que recorrera las filas
                foreach (DataGridViewRow row in grid_db.Rows)
                {
                    //for que recorrera las celdas
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //si el campo de tipo de equipo es igual a lo excrito en el textbox mostrara solo esos datos
                        if ((row.Cells[6].Value.ToString().ToUpper()).IndexOf(txt_filtroN.Text.ToUpper()) == 0)
                        {
                            //mostrara los datos
                            row.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                //si esta vacio muestra todos los datos
                listar();
            }
        }

        private void RB_Rut(object sender, EventArgs e)
        {
            //si el textbox esta vacio dejara en nulo la celda actual
            if (txt_filtroN.Text != "")
            {
                grid_db.CurrentCell = null;
                //for que recorrera las filas y las ocultara
                foreach (DataGridViewRow row in grid_db.Rows)
                {
                    row.Visible = false;
                }
                //for que recorrera las filas
                foreach (DataGridViewRow row in grid_db.Rows)
                {
                    //for que recorrera las celdas
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //si el campo de rut es igual a lo excrito en el textbox mostrara solo esos datos
                        if ((row.Cells[3].Value.ToString().ToUpper()).IndexOf(txt_filtroN.Text.ToUpper()) == 0)
                        {
                            //mostrara los datos
                            row.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                //si esta vacio muestra todos los datos
                listar();
            }
        }

        private void RB_Marca_CheckedChanged(object sender, EventArgs e)
        {
            //si el textbox esta vacio dejara en nulo la celda actual
            if (txt_filtroN.Text != "")
            {
                grid_db.CurrentCell = null;
                //for que recorrera las filas y las ocultara
                foreach (DataGridViewRow row in grid_db.Rows)
                {
                    row.Visible = false;
                }
                //for que recorrera las filas
                foreach (DataGridViewRow row in grid_db.Rows)
                {
                    //for que recorrera las celdas
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //si el campo de marca es igual a lo excrito en el textbox mostrara solo esos datos
                        if ((row.Cells[7].Value.ToString().ToUpper()).IndexOf(txt_filtroN.Text.ToUpper()) == 0)
                        {
                            //mostrara los datos
                            row.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                //si esta vacio muestra todos los datos
                listar();
            }
        }

    }
}
