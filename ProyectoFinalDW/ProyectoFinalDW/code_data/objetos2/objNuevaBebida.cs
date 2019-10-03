using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalDW.code_data.objetos2
{
    public class objNuevaBebida
    {
        public string strBebida { get; set; }
        public string strMarca { get; set; }
        public string strPrecio { get; set; }
        public string strFecha { get; set; }


        public objNuevaBebida() { }

        public objNuevaBebida(string strBebida, string strMarca, string strPrecio, string strFecha)
        {
            this.strBebida = strBebida;
            this.strMarca = strMarca;
            this.strPrecio = strPrecio;
            this.strFecha = strFecha;


        }
    }
}