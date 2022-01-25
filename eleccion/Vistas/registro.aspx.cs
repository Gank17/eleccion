using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eleccion.Vistas
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButRegistro_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Num_documento = int.Parse(TextDocumento.Text);
            usuario.Nombre1 = Textnombre1.Text;
            usuario.Nombre2 = TextBox1.Text;
            usuario.Apellido1 = Textapellido1.Text;
            usuario.Apellido2 = Textapellido2.Text;
            usuario.Usuario = TextUsuario.Text;
            usuario.Password = Textpassword.Text;
            usuario.ConPasseword = TextCon_password.Text;
            usuario.Telefono = TextTelefono.Text;
            usuario.Fk_genero = int.Parse(DropDownListGenero.SelectedValue);
            usuario.Fk_rol = int.Parse(DropDownListRol.SelectedValue);
            usuario.Fk_tipo_documento = int.Parse(DropDownListTipoDocu.SelectedValue);

            Control control = new Control();
            string respuesta = control.Controlregistro(usuario);

            if(respuesta.Length > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('" + respuesta + "');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Usuario registrado');", true);
            }
        }
    }
}