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
    public partial class frmHabitacion : System.Web.UI.Page
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
                    if (!IsPostBack)
                    {
                        cargarDatos();
                    }
                }
            }
            catch
            {
                Response.Redirect("Login.aspx");
            }

            
        }

        private void cargarDatos()
        {
            gvHabitaciones.DataSource = new DataTable();
            gvHabitaciones.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            //if (ddlHoteles.SelectedValue != "0" && ddlCategoria.SelectedValue != "0" && ddlTipo.SelectedValue != "0" && txtCodigo.Text != "")
            //{
            //    objHabitacion objBebidas = new objHabitacion()
            //    {
            //        intHotelId = Convert.ToInt32(ddlHoteles.SelectedValue),
            //        intCategoria = Convert.ToInt32(ddlCategoria.SelectedValue),
            //        intTipo = Convert.ToInt32(ddlTipo.SelectedValue),
            //        intCodigo = txtCodigo.Text
            //    };

            //    CtrlHotel objHotel = new CtrlHotel();

            //    if (objHotel.insertarBebida(objBebidas))
            //    {
            //        dvCorrecto.Visible = true;
            //        dvError.Visible = false;
            //        CargarDatos();
            //    }
            //    else
            //    {
            //        dvCorrecto.Visible = false;
            //        dvError.Visible = true;
            //        lblError.Text = objHotel.strReturnMessage;
            //    }
            //}
            //else
            //{
            //    if (txtNombreBebida.Text == "")
            //    {
            //        lblError1.Visible = true;
            //    }
            //    if (txtMarca.Text == "")
            //    {
            //        lblError2.Visible = true;
            //    }
            //    if (TxtPrecio.Text == "")
            //    {
            //        lblError2.Visible = true;
            //    }
            //    if (txtFechaCaducidad.Text == "")
            //    {
            //        lblError2.Visible = true;
            //    }
            //    dvCorrecto.Visible = false;
            //    dvError.Visible = true;
            //    lblError.Text = "Debe ingresar los campos obligatorios!";
            //}
        }
    }
}