using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace inventarioportable
{
    public class hover
    {
        //colores
        private static Color exportar = Color.FromArgb(152, 251, 152);
        private static Color borrar_t = Color.FromArgb(255, 0, 0);

        //metodo efecto hover que recibe los parametros
        public static void Hover(Button bbutton, string tipo)
        {
            //propiedades del button
            bbutton.FlatStyle = FlatStyle.Flat;
            //tamaño borde
            bbutton.FlatAppearance.BorderSize = 1;
           
            
            // asignara el color dependiendo del tipo de boton
            switch (tipo)
            {
                case "exportar":
                   bbutton.Text = "Exportar a Excel";
                   //borde
                    bbutton.FlatAppearance.BorderColor = exportar;
                    //color
                    bbutton.BackColor = exportar;
                    break;
                case "borrart":
                    bbutton.Text = "Borrar TODO";
                    //borde
                    bbutton.FlatAppearance.BorderColor = borrar_t;
                    //color
                    bbutton.BackColor = borrar_t;
                    break;
                    
            }
            bbutton.MouseEnter += new EventHandler(btn_MouseEnter);
            bbutton.MouseLeave += new EventHandler(btn_MouseLeave);
        }
        // metodo handler mouse
        private static void btn_MouseEnter(object sender, EventArgs e)
        {
            Button b = sender as Button;
            //si el color del fondo es al tipo exportar cambiara el color de la letra a de exportar

            if (b.Text == "Exportar a Excel")
                b.BackColor = exportar;
            else if (b.Text == "Borrar TODO")
                b.BackColor = borrar_t;
            //cambia de color de texto a blanco
            b.ForeColor = Color.White;

        }


        //metodo handler del evento mouse leave
        private static void btn_MouseLeave(object sender, EventArgs e)
        {
            // cambiara las letras a su color anterior cuando el mouse salga del boton
           Button b = sender as Button;
            if (b.Text == "Exportar a Excel")
                // devuelve el color de letra principal del texto
                b.ForeColor = exportar;
            else if (b.Text == "Borrar TODO")
                b.ForeColor = borrar_t;
            // pone el boton en transparente
            b.BackColor = Color.Transparent;
        }
        //llenara el color del boton
        public static void HoverA(Button bbutton, string tipo)
        {
            //propiedades del button
            bbutton.FlatStyle = FlatStyle.Flat;
            //tamaño borde
            bbutton.FlatAppearance.BorderSize = 1;


            // asignara el color dependiendo del tipo de boton
            switch (tipo)
            {
                case "exportar":
                    bbutton.Text = "Exportar a Excel";
                    //borde
                    bbutton.FlatAppearance.BorderColor = exportar;
                    //color
                    bbutton.ForeColor = exportar;
                    break;
                case "borrart":
                    bbutton.Text = "Borrar TODO";
                    //borde
                    bbutton.FlatAppearance.BorderColor = borrar_t;
                    //color
                    bbutton.ForeColor = borrar_t;
                    break;

            }

        }

    }
}
