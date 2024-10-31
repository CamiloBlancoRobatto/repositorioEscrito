using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using capaDatos;
using System.Data;

namespace capaLogica
{
    public class CL_Vehiculo
    {
        private CD_Vehiculos datosVehiculo = new CD_Vehiculos();
        public DataTable ObtenerFuncionarios()
        {
            return datosVehiculo.ObtenerVehiculos();
        }


        public void AgregarVehiculo(VehiculosGS vehiculo)
        {
            if (string.IsNullOrWhiteSpace(vehiculo.Matricula) || string.IsNullOrWhiteSpace(vehiculo.Marca) || string.IsNullOrWhiteSpace(vehiculo.Modelo))
          {
              throw new Exception("El nombre y el apellido son obligatorios.");
          }
            else
            datosVehiculo.AgregarVehiculos(vehiculo);

        }
        public void EliminarVehiculos(int id)
        {
            try
            {
                datosVehiculo.EliminarVehiculo(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el vehiculo: " + ex.Message);
            }
        }
        public void ModificarVehiculo(VehiculosGS vehiculo)
        {
            try
            {
                datosVehiculo.ActualizarVehiculo(vehiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el vehiculo: " + ex.Message);
            }
        }


    }
}
