﻿using System;
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
                //query insert
                string query = "INSERT INTO inventario(" +
                    "Nombre, Apellidos, Rut, Departamento, Unidad, Tipo_de_Equipo, " +
                    "Marca, Modelo,Serie, Inventario, Usuario, Nombre_de_Equipo, " +
                    "MAC, RAM, Espacio_Disco, Procesador, Version_Windows, Version_Office, Lojack" +
                    "VALUES(" +
                    "@Nombre, @Apellidos,@Rut, @Departamento, @Unidad, @Tipo_de_Equipo," +
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
                cmd.Parameters.Add(new SQLiteParameter("@Nombre_de_Equpo", obj.Nombre_de_Equipo));
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
        public List<Registro> list()
        {
            List<Registro> lista = new List<Registro>();

            using (SQLiteConnection con = new SQLiteConnection(cdena))
            {
                con.Open();
                //query insert
                string query = "SELECT * FROM inventario";
                //sqlcommand
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader reader = cmd.ExecuteReader()) 
                {
                    while (reader.Read()) 
                    {
                        lista.Add(new Registro()
                        {
                            inventarioid = int.Parse(reader["inventarioid"].ToString()),
                            Nombre = reader["Nombre"].ToString(),
                            Apellidos = reader["Apellido"].ToString(),
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
                            Version_Windows = reader["Version_Windows"].ToString(),
                            Version_Office = reader["Version_Office"].ToString(),
                            Lojack = reader["Lojack"].ToString(),

                        });
                    }
                }
            }

            return lista;
        }
    }
}
