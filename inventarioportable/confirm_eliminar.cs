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
    public partial class confirm_eliminar : Form
    {
        public confirm_eliminar()
        {
            InitializeComponent();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_si_Click(object sender, EventArgs e)
        {
            // crea un objeto de la clase registro
            Registro registro_objeto = new Registro()
            {
                //entrega el id 
                inventarioid = Int32.Parse(lbl_id.Text)
            };
            // guarda una respuseta al momento de insertar para poder saber si esta insertando correctamente
            bool resp = controladorregistro.Instancia.eliminar(registro_objeto);
            MessageBox.Show("Registro eliminado");
            
            this.Close();
        }
    }
}
