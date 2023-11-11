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
    public class DProducto
    {
        private DConexion Conexion = new DConexion();

        public DataTable MostrarProducto()
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarProducto", Conexion.AbrirConexion());
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

        public static bool AgregarProducto(MProducto mProducto)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarProducto", oConexion);
                    Comando.Parameters.AddWithValue("@nombreproducto", mProducto.nombreProducto);
                    Comando.Parameters.AddWithValue("@descripcion", mProducto.Descripcion);
                    Comando.Parameters.AddWithValue("@idTipoProducto", mProducto.IdTipoProducto);
                    Comando.Parameters.AddWithValue("@idProveedor", mProducto.IdProveedor);
                    Comando.Parameters.AddWithValue("@idRubro", mProducto.IdRubro);
                    Comando.Parameters.AddWithValue("@idPresentacion", mProducto.IdPresentacion);
                    Comando.Parameters.AddWithValue("@concentracion", mProducto.Concentracion);
                    Comando.Parameters.AddWithValue("@unidadMedida", mProducto.unidadMedida);
                    Comando.Parameters.AddWithValue("@stockMinimo", mProducto.stockMinimo);
                    Comando.Parameters.AddWithValue("@stockActual", mProducto.stockActual);
                    Comando.Parameters.AddWithValue("@stockMaximo", mProducto.stockMaximo);
                    Comando.Parameters.AddWithValue("@fechaRegistro", mProducto.fechaRegistro);
                    Comando.Parameters.AddWithValue("@fechaFabricacion", mProducto.fechaFabricacion);
                    Comando.Parameters.AddWithValue("@fechaVencimiento", mProducto.fechaVencimiento);
                    Comando.Parameters.AddWithValue("@precioCompra", mProducto.precioCompra);
                    Comando.Parameters.AddWithValue("@margenGanancias", mProducto.margenGanancias);
                    Comando.Parameters.AddWithValue("@precioVenta", mProducto.precioVenta);
                    Comando.Parameters.AddWithValue("@estadoProducto", mProducto.estadoProducto);
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

        public static bool ModificarProducto(MProducto mProducto)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ActualizarProducto", oConexion);
                    Comando.Parameters.AddWithValue("@idProducto", mProducto.IdProducto);
                    Comando.Parameters.AddWithValue("@nombreproducto", mProducto.nombreProducto);
                    Comando.Parameters.AddWithValue("@descripcion", mProducto.Descripcion);
                    Comando.Parameters.AddWithValue("@idTipoProducto", mProducto.IdTipoProducto);
                    Comando.Parameters.AddWithValue("@idProveedor", mProducto.IdProveedor);
                    Comando.Parameters.AddWithValue("@idRubro", mProducto.IdRubro);
                    Comando.Parameters.AddWithValue("@idPresentacion", mProducto.IdPresentacion);
                    Comando.Parameters.AddWithValue("@concentracion", mProducto.Concentracion);
                    Comando.Parameters.AddWithValue("@unidadMedida", mProducto.unidadMedida);
                    Comando.Parameters.AddWithValue("@stockMinimo", mProducto.stockMinimo);
                    Comando.Parameters.AddWithValue("@stockActual", mProducto.stockActual);
                    Comando.Parameters.AddWithValue("@stockMaximo", mProducto.stockMaximo);
                    Comando.Parameters.AddWithValue("@fechaRegistro", mProducto.fechaRegistro);
                    Comando.Parameters.AddWithValue("@fechaFabricacion", mProducto.fechaFabricacion);
                    Comando.Parameters.AddWithValue("@fechaVencimiento", mProducto.fechaVencimiento);
                    Comando.Parameters.AddWithValue("@precioCompra", mProducto.precioCompra);
                    Comando.Parameters.AddWithValue("@margenGanancias", mProducto.margenGanancias);
                    Comando.Parameters.AddWithValue("@precioVenta", mProducto.precioVenta);
                    Comando.Parameters.AddWithValue("@estadoProducto", mProducto.estadoProducto);
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

