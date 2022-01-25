using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eleccion
{
    public class Usuarios
    {
        int idpersona, num_documento, fk_rol, fk_genero, fk_tipo_documento;
        string nombre1, nombre2, apellido1, apellido2, usuario, password, conPasseword, telefono;

        public string Nombre1 { get => nombre1; set => nombre1 = value; }
        public string Nombre2 { get => nombre2; set => nombre2 = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string ConPasseword { get => conPasseword; set => conPasseword = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Fk_rol { get => fk_rol; set => fk_rol = value; }
        public int Fk_genero { get => fk_genero; set => fk_genero = value; }
        public int Fk_tipo_documento { get => fk_tipo_documento; set => fk_tipo_documento = value; }
        public int Num_documento { get => num_documento; set => num_documento = value; }
        public int Idpersona { get => idpersona; set => idpersona = value; }
    }
}