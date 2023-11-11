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
    public class DPresentacion
    {
        private DConexion Conexion = new DConexion();

        public DataTable MostrarPresentacion()
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarPresentacion", Conexion.AbrirConexion());
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

        public static bool AgregarPresentacion(MPresentacion mPresentacion)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarPresentacion", oConexion);
                    Comando.Parameters.AddWithValue("@nombre", mPresentacion.Nombre);
                    Comando.Parameters.AddWithValue("@estadoPresentacion", mPresentacion.EstadoPresentacion);
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

        public static bool ModificarPresentacion(MPresentacion mPresentacion)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ActualizarPresentacion", oConexion);
                    Comando.Parameters.AddWithValue("@idPresentacion", mPresentacion.IdPresentacion);
                    Comando.Parameters.AddWithValue("@nombre", mPresentacion.Nombre);
                    Comando.Parameters.AddWithValue("@estadoPresentacion", mPresentacion.EstadoPresentacion);
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
