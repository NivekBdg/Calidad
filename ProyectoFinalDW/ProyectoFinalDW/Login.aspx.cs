using ProyectoFinalDW.code_data.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalDW
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            code_data.objetos.objUsuario objUsuario = new code_data.objetos.objUsuario()
            {
                strUser = txtUser.Text,
                strPass = txtPass.Text,
            };

            CtrlHotel objHotel = new CtrlHotel();
            bool resultado = objHotel.ConsultarUsuario(objUsuario);

            if(resultado == true)
            {
                Session["usuario"] = txtUser.Text;
                Response.Redirect("frmMenuPrincipal.aspx");
            }
            else
            {
                
                dvError.Visible = true;
            }
        }
    }
}