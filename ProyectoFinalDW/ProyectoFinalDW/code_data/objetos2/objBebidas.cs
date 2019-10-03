using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalDW.code_data.objetos2
{
    public class objBebida
    {
        public string strBebida { get; set; }
        public string strMarca { get; set; }
        public string strPrecio { get; set; }
        public string strFecha { get; set; }

        public objBebida() { }

        public objBebida(string strBebida, string strMarca, String strPrecio, String strFecha)
        {
            this.strBebida = strBebida;
            this.strMarca = strMarca;
            this.strPrecio = strPrecio;
            this.strFecha = strFecha;
        }

    }
}