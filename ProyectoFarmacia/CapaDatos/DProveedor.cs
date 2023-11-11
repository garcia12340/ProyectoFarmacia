
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
    public class DProveedor
    {
        private DConexion Conexion = new DConexion();

        public DataTable MostrarProveedor()
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarProveedor", Conexion.AbrirConexion());
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

        public static bool AgregarProveedor(MProveedor mProveedor)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarProveedor", oConexion);
                    Comando.Parameters.AddWithValue("@nombrecompania", mProveedor.nombreCompañia);
                    Comando.Parameters.AddWithValue("@idTrabajador", mProveedor.IdTrabajador);
                    Comando.Parameters.AddWithValue("@direccionProveedor", mProveedor.Direccion);
                    Comando.Parameters.AddWithValue("@telefono", mProveedor.Telefono);
                    Comando.Parameters.AddWithValue("@fechaRegistro", mProveedor.fechaRegistro);
                    Comando.Parameters.AddWithValue("@fechaUltimoPedido", mProveedor.fechaUltimoPedido);
                    Comando.Parameters.AddWithValue("@estado", mProveedor.Estado);
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

        public static bool ModificarProveedor(MProveedor mProveedor)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ActualizarPresentacion", oConexion);
                    Comando.Parameters.AddWithValue("@idProveedor", mProveedor.IdProveedor);
                    Comando.Parameters.AddWithValue("@nombrecompania", mProveedor.nombreCompañia);
                    Comando.Parameters.AddWithValue("@idTrabajador", mProveedor.IdTrabajador);
                    Comando.Parameters.AddWithValue("@direccionProveedor", mProveedor.Direccion);
                    Comando.Parameters.AddWithValue("@telefono", mProveedor.Telefono);
                    Comando.Parameters.AddWithValue("@fechaRegistro", mProveedor.fechaRegistro);
                    Comando.Parameters.AddWithValue("@fechaUltimoPedido", mProveedor.fechaUltimoPedido);
                    Comando.Parameters.AddWithValue("@estado", mProveedor.Estado);
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
