using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalDW
{
    public partial class frmHotel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvHoteles.DataSource = new DataTable();
            gvHoteles.DataBind();
        }
    }
}