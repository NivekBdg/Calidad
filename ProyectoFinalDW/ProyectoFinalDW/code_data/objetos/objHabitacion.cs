using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalDW.code_data.objetos
{
    public class objHabitacion
    {
        public int intHotelId { get; set; }
        public int intCategoria { get; set; }
        public int intTipo { get; set; }
        public string intCodigo { get; set; }

        public objHabitacion() { }

        public objHabitacion(int intHotelId, int intCategoria, int intTipo, string intCodigo)
        {
            this.intHotelId = intHotelId;
            this.intCategoria = intCategoria;
            this.intTipo = intTipo;
            this.intCodigo = intCodigo;
        }


    }
}