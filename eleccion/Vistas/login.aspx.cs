using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eleccion.Vistas
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Butingresar_Click(object sender, EventArgs e)
        {
            string usuario = TexUsuario.Text;
            string password = TextPassword.Text;

            try
            {
                Control crtl = new Control();
                string respuesta = crtl.ctrlLogin(usuario, password);
                if (respuesta.Length >0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('" + respuesta + "');", true);
                }
                else
                {
                    Response.Redirect("Menu.aspx");
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('" + ex.Message + "');", true);
            }
        }

        protected void TextPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}