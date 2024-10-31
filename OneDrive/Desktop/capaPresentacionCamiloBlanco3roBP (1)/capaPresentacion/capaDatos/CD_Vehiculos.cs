using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace capaDatos
{
    public class CD_Vehiculos
    {
        private Conexion conn = new Conexion();
        private MySqlCommand comando = new MySqlCommand();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public DataTable ObtenerVehiculos()
        {
            DataTable dt = new DataTable();
            try
            {
                comando.Connection = Conexion.Conectarse();
                comando.CommandText = "SELECT * FROM vehiculos";
                comando.CommandType = CommandType.Text;

                adapter.SelectCommand = comando;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los vehiculos: " + ex.Message);
            }
            finally
            {
                Conexion.Desconectarse();
            }
            return dt;
        }


        public void AgregarVehiculos(VehiculosGS vehiculo)

        {

            try
            {
                comando.Connection = Conexion.Conectarse();
                comando.CommandText = "INSERT INTO vehiculos (matricula, marca, modelo, anio, cod_Serv) VALUES (@matricula, @marca, @modelo, @anio, @cod_Serv)";
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@matricula", vehiculo.Matricula);
                comando.Parameters.AddWithValue("@marca", vehiculo.Marca);
                comando.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                comando.Parameters.AddWithValue("@anio", vehiculo.Anio);
                comando.Parameters.AddWithValue("@cod_Serv", vehiculo.Cod_serv);
               
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el vehiculo: " + ex.Message);
            }
            finally
            {
                comando.Parameters.Clear();
                Conexion.Desconectarse();
            }
        }

        public void EliminarVehiculo(int id)
        {
            try
            {
                comando.Connection = Conexion.Conectarse();
                comando.CommandText = "DELETE FROM vehiculos WHERE id = @id";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery(); // Ejecutar el comando de eliminación
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el vehiculo: " + ex.Message);
            }
            finally
            {
                comando.Parameters.Clear();
                Conexion.Desconectarse();
            }
        }


        public void ActualizarVehiculo(VehiculosGS vehiculo)
        {
            try
            {
                comando.Connection = Conexion.Conectarse();
                comando.CommandText = "UPDATE vehiculos SET matricula = @matricula, marca = @marca, modelo = @modelo, anio = @anio, cod_Serv = @cod_Serv  WHERE id = @id";
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@matricula", vehiculo.Matricula);
                comando.Parameters.AddWithValue("@marca", vehiculo.Marca);
                comando.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                comando.Parameters.AddWithValue("@anio", vehiculo.Anio);
                comando.Parameters.AddWithValue("@cod_Serv", vehiculo.Cod_serv);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el vehiculo: " + ex.Message);
            }
            finally
            {
                comando.Parameters.Clear();
                Conexion.Desconectarse();
            }
        }






    }
}
