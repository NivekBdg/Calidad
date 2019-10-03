using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalDW.code_data.objetos2
{
    public class objBebidas1
    {
        public string strUser { get; set; }
        public string strPass { get; set; }

        public objBebidas1() { }

        public objBebidas1(string strBebida, string strMarca, tring strPrecio, tring strFecha)
        {
            this.strBebida = strBebida;
            this.strMarca = strMarca;
            this.strPrecio = strPrecio;
            this.strFecha = strFecha;
        }

    }
}