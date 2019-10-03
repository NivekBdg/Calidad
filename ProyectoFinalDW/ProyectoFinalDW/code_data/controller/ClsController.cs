using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoFinalDW.code_data.controller
{
    public class ClsController
    {
        protected string strMensaje;
        DataSet dsPrivate;
        public string strReturnMessage
        {
            get { return this.strMensaje; }
            set { this.strMensaje = value; }
        }

        public DataSet dsReturn
        {
            get { return this.dsPrivate; }
            set { this.dsPrivate = value; }
        }
    }
}