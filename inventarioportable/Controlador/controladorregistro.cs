using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using inventarioportable.Modelo;
using System.Data.SQLite;
namespace inventarioportable.Controlador
{
    public class controladorregistro
    {
        //crea una variable que guardara la string de connection de la configuracion
        private static string cdena = ConfigurationManager.ConnectionStrings["string"].ConnectionString;
        // crea una instancia nula
        private static controladorregistro inst = null;
        //constructor
        public controladorregistro()
        {

        }
        //permite hacer instancia unica al registro
        public static controladorregistro Instancia
        {
            get
            {
                if(inst == null)
                {
                    inst = new controladorregistro();
                }
                //retorna la instancia
                return inst;
            }
        }
        public bool insert(Registro obj)
        {
            bool resp = true;

            using (SQLiteConnection con = new SQLiteConnection(cdena)) 
            {

            }

            return resp;

        }
    }
}
