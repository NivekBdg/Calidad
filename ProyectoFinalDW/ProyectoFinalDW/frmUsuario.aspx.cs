using ProyectoFinalDW.code_data.controller;
using ProyectoFinalDW.code_data.objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalDW
{
    public partial class frmUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["usuario"].ToString() == "")
                {
                    Response.Redirect("Login.aspx");
                }
            }
            catch
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombreUsuario.Text.Trim() != "" && TxtPass.Text.Trim() != "" && txtNombre.Text.Trim() != "" 
                && txtApellidos.Text.Trim() != "" && txtId.Text.Trim() != "")
            {
                objNuevoUsuario objUsuario = new objNuevoUsuario()
                {
                    strUser = txtNombreUsuario.Text,
                    strPass = TxtPass.Text,
                    strCorreo = txtEmail.Text,
                    strDireccion = txtDireccion.Text,
                    strNombre = txtNombre.Text,
                    strApellidos = txtApellidos.Text,
                    strTelefono = txtTelefono.Text,
                    int64Dni = Convert.ToInt64(txtId.Text),
                };

                CtrlHotel objHotel = new CtrlHotel();

                if (objHotel.insertarUsuario(objUsuario))
                {
                    dvCorrecto.Visible = true;
                    dvError.Visible = false;
                }
                else
                {
                    dvCorrecto.Visible = false;
                    dvError.Visible = true;
                    lblError.Text = objHotel.strReturnMessage;
                }
            }
            else
            {
                if(txtNombreUsuario.Text == "")
                {
                    lblError1.Visible = true;
                }
                if (TxtPass.Text == "")
                {
                    lblError2.Visible = true;
                }
                if (txtNombre.Text == "")
                {
                    lblError3.Visible = true;
                }
                if (txtApellidos.Text == "")
                {
                    lblError4.Visible = true;
                }
                if (txtId.Text == "")
                {
                    lblError5.Visible = true;
                }

                dvCorrecto.Visible = false;
                dvError.Visible = true;
                lblError.Text = "Debe ingresar los campos obligatorios!";
            }
        }

        protected void btnBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmMenuPrincipal.aspx");
        }
    }
}