using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalDW.code_data.objetos
{
    public class objUsuario
    {
        public string strUser { get; set; }
        public string strPass { get; set; }

        public objUsuario() { }

        public objUsuario(string strUser, string strPass)
        {
            this.strUser = strUser;
            this.strPass = strPass;
        }

    }
}