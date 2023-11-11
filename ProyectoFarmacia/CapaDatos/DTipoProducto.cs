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
    public class DTipoProducto
    {
        private DConexion Conexion = new DConexion();

        public DataTable TipoProducto()
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarTipoProducto", Conexion.AbrirConexion());
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

        public static bool AgregarTipoProducto(MTipoProducto mTipoProducto)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarTipoProducto", oConexion);
                    Comando.Parameters.AddWithValue("@descripcion", mTipoProducto.Descripcion);
                    Comando.Parameters.AddWithValue("@estado", mTipoProducto.Estado);
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

        public static bool ModificarTipoProducto(MTipoProducto mTipoProducto)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ActualizarTipoProducto", oConexion);
                    Comando.Parameters.AddWithValue("@idTipoProducto", mTipoProducto.IdTipoProducto);
                    Comando.Parameters.AddWithValue("@descripcion", mTipoProducto.Descripcion);
                    Comando.Parameters.AddWithValue("@estado", mTipoProducto.Estado);
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
