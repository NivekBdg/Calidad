using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalDW
{
    public partial class frmReservar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dtAlgo = new DataTable();
            dtAlgo.Columns.Add("habitacion");

            DataRow dr = dtAlgo.NewRow();
            dr["habitacion"] = "prueba";
            dtAlgo.Rows.Add(dr);
            dtAlgo.AcceptChanges();
            gvReserva.DataSource = dtAlgo;
            gvReserva.DataBind();
        }
    }
}