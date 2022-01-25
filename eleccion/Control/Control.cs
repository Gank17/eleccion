using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace eleccion
{
    public class Control
    {

        public String Controlregistro(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            String respuesta = "";

            if (usuario.Num_documento == 0 || string.IsNullOrEmpty(usuario.Nombre1) ||  string.IsNullOrEmpty(usuario.Apellido1) || string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConPasseword) || string.IsNullOrEmpty(usuario.Telefono) || usuario.Fk_rol == 0 || usuario.Fk_genero == 0 || usuario.Fk_tipo_documento == 0)
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (usuario.Password == usuario.ConPasseword)
                {
                    if (modelo.existeUsuario(usuario.Usuario))
                    {
                        respuesta = "el usuario ya fue registrado";
                    }
                    else
                    {
                        usuario.Password = GenerarSHA1(usuario.Password);
                        modelo.Registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las contraseña no coinciden";
                }
            }
            return respuesta;
        }

        public string ctrlLogin(string usuario, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsiarios = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password) )
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosUsiarios = modelo.proUsuario(usuario);
                if (datosUsiarios==null )
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosUsiarios.Password != GenerarSHA1(password))
                    {
                        respuesta = "EL usuario y/o la contraseña no coinciden";
                    }
                }
            }
            return respuesta;
        }

        private string GenerarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }

    }
}