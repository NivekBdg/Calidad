using ProyectoFinalDW.code_data.controller;
using ProyectoFinalDW.code_data.objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalDW
{
    public partial class frmAdminUsuarios : System.Web.UI.Page
    {
        DataTable dtUsuario;
        DataTable dtRol;

        protected void Page_Load(object sender, EventArgs e)
        {

            //try
            //{
            //    if (Session["usuario"].ToString() == "")
            //    {
            //        Response.Redirect("Login.aspx");
            //    }
            //}
            //catch
            //{
            //    Response.Redirect("Login.aspx");
            //}

            //if (!IsPostBack)
            //{
            //    CtrlHotel objHotel = new CtrlHotel();
            //    dtUsuario = objHotel.consultarUsuarioRol();
            //    ddlUsuario.DataSource = dtUsuario;
            //    ddlUsuario.DataTextField = "username";
            //    ddlUsuario.DataValueField = "id";
            //    ddlUsuario.DataBind();

            //    dtRol = objHotel.consultarRol();
            //    ddlRol.DataSource = dtRol;
            //    ddlRol.DataTextField = "authority";
            //    ddlRol.DataValueField = "id";
            //    ddlRol.DataBind();
            //}
        }

        protected void btnBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmMenuPrincipal.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //objUsuarioRol objRol = new objUsuarioRol()
            //{
            //    strUser = ddlUsuario.SelectedValue,
            //    strRol = ddlRol.SelectedValue,
            //};
            //ctrlHotel objHotel = new ctrlHotel();
            //bool resultado = objHotel.insertarRol(objRol);
            //if(resultado != true)
            //{
            //    dvError.Visible = true;
            //    dvCorrecto.Visible = false;
            //    lblError.Text = objHotel.strMensaje;
            //}
            //else
            //{
            //    dvCorrecto.Visible = true;
            //    dvError.Visible = false;
            //}
        }

        protected void ddlUsuario_Load(object sender, EventArgs e)
        {
            //ctrlHotel objHotel = new ctrlHotel();

            //if (dtUsuario == null)
            //{
            //    dtUsuario = objHotel.consultarUsuarioRol();
            //}


        }

        protected void ddlRol_Load(object sender, EventArgs e)
        {
            //ctrlHotel objHotel = new ctrlHotel();

            //if(dtRol == null)
            //{
            //    dtRol = objHotel.consultarRol();
            //}
        }
    }
}