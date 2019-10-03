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
    public partial class frmBebidas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["usuario"].ToString() == "")
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    if(!IsPostBack)
                    {
                        CargarDatos();
                    }
                    
                }
            }
            catch
            {
                Response.Redirect("Login.aspx");
            }

        }

        private void CargarDatos() {

            txtFechaCaducidad.Text = "";
            txtMarca.Text = "";
            txtNombreBebida.Text = "";
            TxtPrecio.Text = "";
            CtrlHotel objHotel = new CtrlHotel();
            if (objHotel.ConsultarBebida())
            {
                gvBebidas.DataSource = objHotel.dsReturn.Tables[0];
                gvBebidas.DataBind();
            }
            else
            {
                gvBebidas.DataSource = new DataTable();
                gvBebidas.DataBind();
            }   
        
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombreBebida.Text != "" && txtMarca.Text != "" && TxtPrecio.Text != "" && txtFechaCaducidad.Text != "")
            {
                ObjNuevaBebida objBebidas = new ObjNuevaBebida()
                {
                    strBebida = txtNombreBebida.Text,
                    strMarca = txtMarca.Text,
                    strPrecio = TxtPrecio.Text,
                    strFecha = txtFechaCaducidad.Text
                };

                CtrlHotel objHotel = new CtrlHotel();

                if (objHotel.insertarBebida(objBebidas))
                {
                    dvCorrecto.Visible = true;
                    dvError.Visible = false;
                    CargarDatos();
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
                if (txtNombreBebida.Text == "")
                {
                    lblError1.Visible = true;
                }
                if (txtMarca.Text == "")
                {
                    lblError2.Visible = true;
                }
                if (TxtPrecio.Text == "")
                {
                    lblError2.Visible = true;
                }
                if (txtFechaCaducidad.Text == "")
                {
                    lblError2.Visible = true;
                }
                dvCorrecto.Visible = false;
                dvError.Visible = true;
                lblError.Text = "Debe ingresar los campos obligatorios!";
            }
        }
        

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmMenuPrincipal.aspx");
        }
    }
}