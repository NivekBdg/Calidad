using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalDW
{
    public partial class frmMenuPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("frmLogin.aspx");
            }
        }

        protected void btnReserva_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmReservar.aspx");
        }
        
        protected void btnAgregarUsuario_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmUsuario.aspx");
        }

        protected void btnBebida_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmBebidas.aspx");
        }

        protected void btnAgregarHotel_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmHotel.aspx");
        }

        protected void btnHabitacion_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmHabitacion.aspx");
        }

        protected void btnExit_Click(object sender, ImageClickEventArgs e)
        {
            Session["usuario"] = "";
            Response.Redirect("Login.aspx");
        }

        protected void btnPermisos_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmAdminUsuarios.aspx");
        }
    }
}