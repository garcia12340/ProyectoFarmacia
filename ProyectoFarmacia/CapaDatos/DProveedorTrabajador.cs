using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DProveedorTrabajador
    {
        private DConexion Conexion = new DConexion();

        public DataTable MostrarTrabajadorProveedor()
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarTrabajadorProveedor", Conexion.AbrirConexion());
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.ExecuteNonQuery();
                DataTable tablaautor = new DataTable();


                SqlDataAdapter adaptar = new SqlDataAdapter(Comando);
                adaptar.Fill(tablaautor);
                return tablaautor;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        public static bool AgregarTrabajadorProveedor(MProveedorTrabajador mProveedorTrabajador)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarTrababajor", oConexion);
                    Comando.Parameters.AddWithValue("@PrimerNombre", mProveedorTrabajador.primerNombre);
                    Comando.Parameters.AddWithValue("@SegundoNombre", mProveedorTrabajador.segundoNombre);
                    Comando.Parameters.AddWithValue("@PrimerApellido", mProveedorTrabajador.primerApellido);
                    Comando.Parameters.AddWithValue("@SegundoApellido", mProveedorTrabajador.segundoApellido);
                    Comando.Parameters.AddWithValue("@DireccionTrabajador", mProveedorTrabajador.direccionTrabajador);
                    Comando.Parameters.AddWithValue("@Cargo", mProveedorTrabajador.Edad);
                    Comando.Parameters.AddWithValue("@Edad", mProveedorTrabajador.Sexo);
                    Comando.Parameters.AddWithValue("@Telefono", mProveedorTrabajador.telefonoTrabajador);
                    Comando.Parameters.AddWithValue("@Sexo", mProveedorTrabajador.Sexo);
                    Comando.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    Comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    res = false;
                }

                return res;
            }

        }

        public static bool ModificarTrabajadorProveedor(MProveedorTrabajador mProveedorTrabajador)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ActualizarTrababajor", oConexion);
                    Comando.Parameters.AddWithValue("@IdTrabajador", mProveedorTrabajador.IdTrabajador);
                    Comando.Parameters.AddWithValue("@PrimerNombre", mProveedorTrabajador.primerNombre);
                    Comando.Parameters.AddWithValue("@SegundoNombre", mProveedorTrabajador.segundoNombre);
                    Comando.Parameters.AddWithValue("@PrimerApellido", mProveedorTrabajador.primerApellido);
                    Comando.Parameters.AddWithValue("@SegundoApellido", mProveedorTrabajador.segundoApellido);
                    Comando.Parameters.AddWithValue("@DireccionTrabajador", mProveedorTrabajador.direccionTrabajador);
                    Comando.Parameters.AddWithValue("@Cargo", mProveedorTrabajador.Edad);
                    Comando.Parameters.AddWithValue("@Edad", mProveedorTrabajador.Sexo);
                    Comando.Parameters.AddWithValue("@Telefono", mProveedorTrabajador.telefonoTrabajador);
                    Comando.Parameters.AddWithValue("@Sexo", mProveedorTrabajador.Sexo);
                    Comando.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    Comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    res = false;
                }

                return res;
            }

        }
    }
    
}
