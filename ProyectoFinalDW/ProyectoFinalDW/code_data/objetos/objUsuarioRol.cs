using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalDW.code_data.objetos
{
    public class objUsuarioRol
    {
        public string strUser { get; set; }
        public string strRol { get; set; }

        public objUsuarioRol() { }

        public objUsuarioRol(string strUser, string strRol)
        {
            this.strUser = strUser;
            this.strRol = strRol;
        }

    }
}