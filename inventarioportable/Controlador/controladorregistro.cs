using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using inventarioportable.Modelo;
using System.Data.SQLite;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Drawing;

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
                con.Open();
                //query insert
                string query = "INSERT INTO inventario(" +
                    "Nombre, Apellidos, Rut, Departamento, Unidad, Tipo_de_Equipo, " +
                    "Marca, Modelo, Serie, Inventario, Usuario, Nombre_de_Equipo, " +
                    "MAC, RAM, Espacio_Disco, Procesador, Version_Windows, Version_Office, Lojack)" +
                    "VALUES(" +
                    "@Nombre, @Apellidos, @Rut, @Departamento, @Unidad, @Tipo_de_Equipo," +
                    "@Marca, @Modelo, @Serie, @Inventario, @Usuario, @Nombre_de_Equipo," +
                    "@MAC, @RAM, @Espacio_Disco, @Procesador, @Version_Windows, @Version_Office, @Lojack)";
                //sqlcommand
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                //se añade los parametros al command
                
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@Apellidos", obj.Apellidos));
                cmd.Parameters.Add(new SQLiteParameter("@Rut", obj.Rut));
                cmd.Parameters.Add(new SQLiteParameter("@Departamento", obj.Departamento));
                cmd.Parameters.Add(new SQLiteParameter("@Unidad", obj.Unidad));
                cmd.Parameters.Add(new SQLiteParameter("@Tipo_de_Equipo", obj.Tipo_de_Equipo));
                cmd.Parameters.Add(new SQLiteParameter("@Marca", obj.Marca));
                cmd.Parameters.Add(new SQLiteParameter("@Modelo", obj.Modelo));
                cmd.Parameters.Add(new SQLiteParameter("@Serie", obj.Serie));
                cmd.Parameters.Add(new SQLiteParameter("@Inventario", obj.Inventario));
                cmd.Parameters.Add(new SQLiteParameter("@Usuario", obj.Usuario));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre_de_Equipo", obj.Nombre_de_Equipo));
                cmd.Parameters.Add(new SQLiteParameter("@MAC", obj.MAC));
                cmd.Parameters.Add(new SQLiteParameter("@RAM", obj.RAM));
                cmd.Parameters.Add(new SQLiteParameter("@Espacio_Disco", obj.Espacio_Disco));
                cmd.Parameters.Add(new SQLiteParameter("@Procesador", obj.Procesador));
                cmd.Parameters.Add(new SQLiteParameter("@Version_Windows", obj.Version_Windows));
                cmd.Parameters.Add(new SQLiteParameter("@Version_Office", obj.Version_Office));
                cmd.Parameters.Add(new SQLiteParameter("@Lojack", obj.Lojack));
                // el command sera de tipo texto
                cmd.CommandType = System.Data.CommandType.Text;
                //verifica si se ejecuto correctamente la query analizando el numero de filas afectadas
                if (cmd.ExecuteNonQuery() < 1)
                {
                    resp = false;
                }

            }

            return resp;

        }
        //metodo modificar
        public bool modificar(Registro obj)
        {
            bool resp = true;
            using (SQLiteConnection con = new SQLiteConnection(cdena))
            {
                con.Open();
                //query update
                string query = "UPDATE inventario SET " +
                    "Nombre = @Nombre, Apellidos = @Apellidos, Rut = @Rut, Departamento = @Departamento," +
                    "Unidad = @Unidad, Tipo_de_Equipo = @Tipo_de_Equipo, " +
                    "Marca = @Marca, Modelo = @Modelo, Serie = @Serie, Inventario = @Inventario, " +
                    "Usuario = @Usuario, Nombre_de_Equipo = @Nombre_de_Equipo, " +
                    "MAC = @MAC, RAM = @RAM, Espacio_Disco = @Espacio_Disco, Procesador = @Procesador," +
                    "Version_Windows = @Version_Windows, Version_Office = @Version_Office, " +
                    "Lojack = @Lojack WHERE inventarioid = @inventarioid";
                //sqlcommand
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                //se añade los parametros al command
                cmd.Parameters.Add(new SQLiteParameter("@inventarioid", obj.inventarioid));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@Apellidos", obj.Apellidos));
                cmd.Parameters.Add(new SQLiteParameter("@Rut", obj.Rut));
                cmd.Parameters.Add(new SQLiteParameter("@Departamento", obj.Departamento));
                cmd.Parameters.Add(new SQLiteParameter("@Unidad", obj.Unidad));
                cmd.Parameters.Add(new SQLiteParameter("@Tipo_de_Equipo", obj.Tipo_de_Equipo));
                cmd.Parameters.Add(new SQLiteParameter("@Marca", obj.Marca));
                cmd.Parameters.Add(new SQLiteParameter("@Modelo", obj.Modelo));
                cmd.Parameters.Add(new SQLiteParameter("@Serie", obj.Serie));
                cmd.Parameters.Add(new SQLiteParameter("@Inventario", obj.Inventario));
                cmd.Parameters.Add(new SQLiteParameter("@Usuario", obj.Usuario));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre_de_Equipo", obj.Nombre_de_Equipo));
                cmd.Parameters.Add(new SQLiteParameter("@MAC", obj.MAC));
                cmd.Parameters.Add(new SQLiteParameter("@RAM", obj.RAM));
                cmd.Parameters.Add(new SQLiteParameter("@Espacio_Disco", obj.Espacio_Disco));
                cmd.Parameters.Add(new SQLiteParameter("@Procesador", obj.Procesador));
                cmd.Parameters.Add(new SQLiteParameter("@Version_Windows", obj.Version_Windows));
                cmd.Parameters.Add(new SQLiteParameter("@Version_Office", obj.Version_Office));
                cmd.Parameters.Add(new SQLiteParameter("@Lojack", obj.Lojack));
                // el command sera de tipo texto
                cmd.CommandType = System.Data.CommandType.Text;
                //verifica si se ejecuto correctamente la query analizando el numero de filas afectadas
                if (cmd.ExecuteNonQuery() < 1)
                {
                    resp = false;
                }
                return resp;
            }
        }

        //metodo modificar
        public bool eliminar(Registro obj)
        {
            bool resp = true;
            using (SQLiteConnection con = new SQLiteConnection(cdena))
            {
                con.Open();
                //query update
                string query = "DELETE FROM inventario WHERE inventarioid = @inventarioid";
                //sqlcommand
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                //se añade los parametros al command
                cmd.Parameters.Add(new SQLiteParameter("@inventarioid", obj.inventarioid));
                // el command sera de tipo texto
                cmd.CommandType = System.Data.CommandType.Text;
                //verifica si se ejecuto correctamente la query analizando el numero de filas afectadas
                if (cmd.ExecuteNonQuery() < 1)
                {
                    resp = false;
                }
                return resp;
            }
        }

        public bool eliminarTODO()
        {
            bool resp = true;
            using (SQLiteConnection con = new SQLiteConnection(cdena))
            {
                con.Open();
                //query update
                string query = "DELETE FROM inventario";
                //sqlcommand
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                // el command sera de tipo texto
                cmd.CommandType = System.Data.CommandType.Text;
                //verifica si se ejecuto correctamente la query analizando el numero de filas afectadas
                if (cmd.ExecuteNonQuery() < 1)
                {
                    resp = false;
                }
                return resp;
            }
        }

        //crea una funcion de tipo lista de la clase registro
        public List<Registro> list()
        {
            //crea un objeto lista de registro
            List<Registro> lista = new List<Registro>();
            //usa la coneccion para poder luego hacer la query
            using (SQLiteConnection con = new SQLiteConnection(cdena))
            {
                //abre la conexion
                con.Open();
                //query select todo de inventario
                string query = "SELECT * FROM inventario";
                //sqlcommand
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                //se le da que sera de tipo texto
                cmd.CommandType = System.Data.CommandType.Text;
                // crea un objeto del data reader para poder leer lo que retornara el command
                using (SQLiteDataReader reader = cmd.ExecuteReader()) 
                {
                    // mientras el reader esta leyendo
                    while (reader.Read()) 
                    {
                        // que añanada los datos de la tabla en la lista de clase registro
                        lista.Add(new Registro()
                        {
                            // datos que leera y parseara a string
                            inventarioid = int.Parse(reader["inventarioid"].ToString()),
                            Nombre = reader["Nombre"].ToString(),
                            Apellidos = reader["Apellidos"].ToString(),
                            Rut = reader["Rut"].ToString(),
                            Departamento = reader["Departamento"].ToString(),
                            Unidad = reader["Unidad"].ToString(),
                            Tipo_de_Equipo = reader["Tipo_de_Equipo"].ToString(),
                            Marca = reader["Marca"].ToString(),
                            Modelo = reader["Modelo"].ToString(),
                            Serie = reader["Serie"].ToString(),
                            Inventario = reader["Inventario"].ToString(),
                            Usuario = reader["Usuario"].ToString(),
                            Nombre_de_Equipo = reader["Nombre_de_Equipo"].ToString(),
                            MAC = reader["MAC"].ToString(),
                            RAM = reader["RAM"].ToString(),
                            Espacio_Disco = reader["Espacio_Disco"].ToString(),
                            Procesador = reader["Procesador"].ToString(),
                            Version_Windows = reader["Version_Windows"].ToString(),
                            Version_Office = reader["Version_Office"].ToString(),
                            Lojack = reader["Lojack"].ToString(),

                        });
                    }
                }
            }
            //retorna la lista
            return lista;
        }
    }
}
