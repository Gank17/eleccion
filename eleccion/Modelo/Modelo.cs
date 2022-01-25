using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eleccion
{
    public class Modelo
    {

        public int Registro(Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO persona (num_documento, nombre1, nombre2, apellido1, apellido2, usuario, password, telefono, fk_rol, fk_genero, fk_tipo_documento) VALUES ( @num_documento, @nombre1, @nombre2, @apellido1, @apellido2, @usuario, @password, @telefono, @fk_rol, @fk_genero, @fk_tipo_documento)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("num_documento", usuario.Num_documento);
            comando.Parameters.AddWithValue("nombre1", usuario.Nombre1);
            comando.Parameters.AddWithValue("nombre2", usuario.Nombre2);
            comando.Parameters.AddWithValue("apellido1", usuario.Apellido1);
            comando.Parameters.AddWithValue("apellido2", usuario.Apellido2);
            comando.Parameters.AddWithValue("usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("password", usuario.Password);
            comando.Parameters.AddWithValue("telefono", usuario.Telefono);
            comando.Parameters.AddWithValue("fk_rol", usuario.Fk_rol);
            comando.Parameters.AddWithValue("fk_genero", usuario.Fk_genero);
            comando.Parameters.AddWithValue("fk_tipo_documento", usuario.Fk_tipo_documento);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT num_documento FROM persona where usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Usuarios proUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idpersona, num_documento, nombre1, nombre2, apellido1, apellido2, usuario, password, telefono, fk_rol, fk_genero, fk_tipo_documento  FROM persona where usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();
            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Idpersona = int.Parse(reader["idpersona"].ToString());
                usr.Num_documento = int.Parse(reader["num_documento"].ToString());
                usr.Nombre1 = reader["nombre1"].ToString();
                usr.Nombre2 = reader["nombre2"].ToString();
                usr.Apellido1 = reader["apellido1"].ToString();
                usr.Apellido2 = reader["apellido2"].ToString();
                usr.Usuario = reader["usuario"].ToString();
                usr.Password = reader["password"].ToString();
                usr.Telefono = reader["telefono"].ToString();
                usr.Fk_rol = int.Parse (reader["fk_rol"].ToString());
                usr.Fk_genero = int.Parse(reader["fk_genero"].ToString());
                usr.Fk_tipo_documento = int.Parse(reader["fk_tipo_documento"].ToString());



            }

            return usr;
        }

    }
}