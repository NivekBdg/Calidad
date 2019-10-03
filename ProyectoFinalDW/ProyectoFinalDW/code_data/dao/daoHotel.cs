using MySql.Data.MySqlClient;
using ProyectoFinalDW.code_data.objetos;
using System;
using System.Data;

namespace ProyectoFinalDW.code_data.dao
{
    public class DaoHotel
    {
        public string strMensajeError { get; set; }
        public DataSet dsDaoHotel;
        public DaoHotel() { }

        public bool ConsultarUsuario(objUsuario Usuario)
        {
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=hotel_bd;uid=conexion;password=pruebas1.");
            bool idnumber = false;
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from usuario WHERE username = '" + Usuario.strUser + "' and password = '" + Usuario.strPass + "'";

            try
            {
                dbConn.Open();
            }
            catch (Exception erro)
            {
                strMensajeError = erro.Message;
                dbConn.Close();
            }
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    idnumber = reader.HasRows;
                }

                return idnumber;
            }
            catch (Exception ex)
            {
                strMensajeError = ex.Message;
                return false;
            }

        }

        public bool InsertarUsuario(objNuevoUsuario Usuario)
        {
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=hotel_bd;uid=conexion;password=pruebas1.");
            bool idnumber = false;
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = @" INSERT INTO usuario(username, password, email, dni, nombre, apellidos, direccion, tlf, enabled)  
                                VALUES('" + Usuario.strUser + "', '" + Usuario.strPass + "', '" + Usuario.strCorreo + "', " + Usuario.int64Dni + "," +
                                " '" + Usuario.strNombre + "', '" + Usuario.strApellidos + "', '" + Usuario.strDireccion + "', " + Usuario.strTelefono + ", 1)";

            try
            {
                dbConn.Open();
            }
            catch (Exception erro)
            {
                strMensajeError = erro.Message;
                dbConn.Close();
            }
            try
            {
                int reader = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                strMensajeError = e.Message;
                return false;
            }
            return idnumber;
        }

        public bool SeleccionarBebida()
        {
            try
            {
                String sql;
                MySqlConnection cn;
                MySqlCommand cm;
                MySqlDataAdapter da;
                DataSet ds;
                sql = "SELECT * FROM bebida ";
                MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=hotel_bd;uid=conexion;password=pruebas1.");
                dbConn.Open();

                cm = new MySqlCommand();
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = dbConn;
                da = new MySqlDataAdapter(cm);

                ds = new DataSet();
                da.Fill(ds);
                dsDaoHotel = ds;
                return true;
            }
            catch (Exception ex)
            {
                strMensajeError = ex.Message;
                return false;
            }
            

        }

        public bool InsertarBebida(ObjNuevaBebida Usuario)
        {
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=hotel_bd;uid=conexion;password=pruebas1.");
            bool idnumber = false;
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = @" INSERT INTO bebida(precio, nombre, FECHA_VENCIMIENTO, MARCA)  
                                VALUES(" + Usuario.strPrecio + ", '" + Usuario.strBebida + "', '" + Usuario.strFecha + "', '" + Usuario.strMarca + "')";

            try
            {
                dbConn.Open();
            }
            catch (Exception erro)
            {
                strMensajeError = erro.Message;
                dbConn.Close();
            }
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
            return idnumber;
        }

    }
}