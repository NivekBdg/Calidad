namespace ProyectoFinalDW.code_data.objetos
{
    public class objHotel
    {
        public string strNombreHotel { get; set; }
        public string strEstrellas { get; set; }
        public string strCiudad { get; set; }
        public string strTelefono { get; set; }
        public string strTiempoReserva { get; set; }
        public string strDireccion { get; set; }
        public string strPrecio { get; set; }

        public objHotel() { }

        public objHotel(string strNombreHotel, string strEstrellas, string strCiudad, string strTelefono, string strApellidos, string strDireccion, string strTiempoReserva, string strPrecio)
        {
            this.strNombreHotel = strNombreHotel;
            this.strEstrellas = strEstrellas;
            this.strCiudad = strCiudad;
            this.strTelefono = strTelefono;
            this.strDireccion = strDireccion;
            this.strTiempoReserva = strTiempoReserva;
            this.strTelefono = strTelefono;
            this.strPrecio = strPrecio;
        }
    }
}