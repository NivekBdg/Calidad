using MySql.Data.MySqlClient;
using ProyectoFinalDW.code_data.objetos;
using System;
using System.Data;

namespace ProyectoFinalDW.code_data
{
    

    public class clsConexion
    {
        private MySqlConnection Conexion;
        public string strMensajeError { get; set; }
        public DataSet dsDaoHotel;
        public clsConexion() {
            IniciarConexion();
        }

        private void IniciarConexion()
        {
            Conexion = new MySqlConnection("Server=localhost;Uid=conexion;Database=hotel_bd;Password=pruebas1.");
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                Conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        strMensajeError = "No se puede conectar con el servidor.  Contacte con el administrador";
                        break;

                    case 1045:
                        strMensajeError = "Usuario/Contraseña inválido, porfavor intente nuevamente";
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                Conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                strMensajeError = ex.Message;
                return false;
            }
        }

        public bool ConsultarUsuario(objUsuario Usuario)
        {

            if (this.OpenConnection())
            {
                MySqlCommand cmd = Conexion.CreateCommand();
                bool idnumber = false;
                cmd.CommandText = "SELECT * from usuario WHERE username = @usuario and password = @contra";
                cmd.Parameters.AddWithValue("@usuario", Usuario.strUser);
                cmd.Parameters.AddWithValue("@contra", Usuario.strPass);
                
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        idnumber = reader.HasRows;
                    }
                    this.CloseConnection();
                    return idnumber;
                }
                catch (Exception ex)
                {
                    strMensajeError = ex.Message;
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public bool InsertarUsuario(objNuevoUsuario Usuario)
        {
            if (this.OpenConnection())
            {
                bool idnumber = false;
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = @" INSERT INTO usuario(username, password, email, dni, nombre, apellidos, direccion, tlf, enabled)  
                                VALUES(@usuario, @contra, @mail, @dpi," +
                                    " @nombreb, @apellido, @direccion, @telefono, 1)";

                cmd.Parameters.AddWithValue("@usuario", Usuario.strUser);
                cmd.Parameters.AddWithValue("@contra", Usuario.strPass);
                cmd.Parameters.AddWithValue("@mail", Usuario.strCorreo);
                cmd.Parameters.AddWithValue("@dpi", Usuario.int64Dni);
                cmd.Parameters.AddWithValue("@nombreb", Usuario.strNombre);
                cmd.Parameters.AddWithValue("@apellido", Usuario.strApellidos);
                cmd.Parameters.AddWithValue("@direccion", Usuario.strDireccion);
                cmd.Parameters.AddWithValue("@telefono", Usuario.strTelefono);

               
                try
                {
                    int reader = cmd.ExecuteNonQuery();
                    idnumber = true;
                }
                catch (Exception e)
                {
                    strMensajeError = e.Message;
                    return false;
                }
                this.CloseConnection();
                return idnumber;
            }
            else
            {
                return false;
            }
        }

        public bool SeleccionarBebida()
        {
            try
            {
                String sql;
                
                MySqlCommand cm;
                MySqlDataAdapter da;
                DataSet ds;
                sql = "SELECT * FROM bebida ";
                if (this.OpenConnection())
                {
                    cm = new MySqlCommand();
                    cm.CommandText = sql;
                    cm.CommandType = CommandType.Text;
                    cm.Connection = Conexion;
                    da = new MySqlDataAdapter(cm);

                    ds = new DataSet();
                    da.Fill(ds);
                    dsDaoHotel = ds;
                    this.CloseConnection();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                strMensajeError = ex.Message;
                return false;
            }


        }

        public bool InsertarBebida(ObjNuevaBebida Usuario)
        {
            
            bool idnumber = false;
            MySqlCommand cmd = Conexion.CreateCommand();
            cmd.CommandText = @" INSERT INTO bebida(precio, nombre, FECHA_VENCIMIENTO, MARCA)  
                                VALUES(@precio, @nombre, @fecha, @marca)";
            cmd.Parameters.AddWithValue("@precio", Usuario.strPrecio);
            cmd.Parameters.AddWithValue("@nombre", Usuario.strBebida);
            cmd.Parameters.AddWithValue("@fecha", Usuario.strFecha);
            cmd.Parameters.AddWithValue("@marca", Usuario.strMarca);

           
            try
            {
                int reader = cmd.ExecuteNonQuery();
                idnumber = true;
            }
            catch (Exception e)
            {
                strMensajeError = e.Message;
                return false;
            }
            this.CloseConnection();
            return idnumber;
        }

    }
}