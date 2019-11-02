using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoFinalDW.code_data.controller
{
    public class CtrlHotel : ClsController
    {
        readonly clsConexion objHotel = new clsConexion();



        public bool ConsultarUsuario(objetos.objUsuario Usuario)
        {
            if (!objHotel.ConsultarUsuario(Usuario))
            {
                strReturnMessage = objHotel.strMensajeError;
                return false;
            }

            return true;
        }

        public bool insertarUsuario(objetos.objNuevoUsuario Usuario)
        {
            if (!objHotel.InsertarUsuario(Usuario))
            {
                strReturnMessage = objHotel.strMensajeError;
                return false;
            }

            return true;
        }



        public bool insertarBebida(objetos.ObjNuevaBebida Bebida)
        {
            if (!objHotel.InsertarBebida(Bebida))
            {
                strReturnMessage = objHotel.strMensajeError;
                return false;
            }

            return true;
        }


        public bool ConsultarBebida()
        {
            if (!objHotel.SeleccionarBebida())
            {
                strReturnMessage = objHotel.strMensajeError;
                return false;
            }
            if (objHotel.dsDaoHotel.Tables[0].Rows.Count < 1)
            {
                strReturnMessage = "No existen registros";
                return false;
            }

            dsReturn = objHotel.dsDaoHotel;
            return true;
        }

        public bool insertarHotel(objetos.objHotel hotel)
        {
            if (!objHotel.InsertarHotel(hotel))
            {
                strReturnMessage = objHotel.strMensajeError;
                return false;
            }

            return true;
        }

        public bool consultarHoteles()
        {
            if (!objHotel.ConsultarHoteles())
            {
                strReturnMessage = objHotel.strMensajeError;
                return false;
            }
            if (objHotel.dsDaoHotel.Tables[0].Rows.Count < 1)
            {
                strReturnMessage = "No existen registros";
                return false;
            }

            dsReturn = objHotel.dsDaoHotel;
            return true;
        }
    }
}