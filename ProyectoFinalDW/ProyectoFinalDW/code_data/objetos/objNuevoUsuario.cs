using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalDW.code_data.objetos
{
    public class objNuevoUsuario
    {
        public string strUser { get; set; }
        public string strPass { get; set; }
        public string strCorreo { get; set; }
        public string strNombre { get; set; }
        public Int64 int64Dni { get; set; }
        public string strApellidos { get; set; }
        public string strDireccion { get; set; }
        public string strTelefono { get; set; }

        public objNuevoUsuario() { }

        public objNuevoUsuario(string strUser, string strPass, string strCorreo, string strNombre, string strApellidos, string strDireccion, Int64 int64Dni, string strTelefono)
        {
            this.strUser = strUser;
            this.strPass = strPass;
            this.strCorreo = strCorreo;
            this.strNombre = strNombre;
            this.strApellidos = strApellidos;
            this.strDireccion = strDireccion;
            this.int64Dni = int64Dni;
            this.strTelefono = strTelefono; 
        }
    }
}