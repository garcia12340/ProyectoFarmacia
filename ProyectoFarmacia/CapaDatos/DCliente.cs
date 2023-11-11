using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaDatos
{
    public class DCliente
    {
        private DConexion Conexion = new DConexion();

        public DataTable MostrarCliente()
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarClientes", Conexion.AbrirConexion());
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

        public static bool AgregarCliente(MCliente mCliente)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarClientes", oConexion);
                    Comando.Parameters.AddWithValue("@primernombre", mCliente.primerNombre);
                    Comando.Parameters.AddWithValue("@segundonombre", mCliente.segundoNombre);
                    Comando.Parameters.AddWithValue("@primerapellido", mCliente.primerApellido);
                    Comando.Parameters.AddWithValue("@segundoapellido", mCliente.segundoApellido);
                    Comando.Parameters.AddWithValue("@edad", mCliente.Edad);
                    Comando.Parameters.AddWithValue("@direccion", mCliente.Direccion);
                    Comando.Parameters.AddWithValue("@telefono", mCliente.Telefono);
                    Comando.Parameters.AddWithValue("@sexo", mCliente.Sexo);
                    Comando.Parameters.AddWithValue("@fechaRegistro", mCliente.fechaRegistro);
                    Comando.Parameters.AddWithValue("@estado", mCliente.Estado);
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

        public static bool ModificarCliente(MCliente mCliente)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ActualizarCliente", oConexion);
                    Comando.Parameters.AddWithValue("@idCliente", mCliente.IdCliente);
                    Comando.Parameters.AddWithValue("@primernombre", mCliente.primerNombre);
                    Comando.Parameters.AddWithValue("@segundonombre", mCliente.segundoNombre);
                    Comando.Parameters.AddWithValue("@primerapellido", mCliente.primerApellido);
                    Comando.Parameters.AddWithValue("@segundoapellido", mCliente.segundoApellido);
                    Comando.Parameters.AddWithValue("@edad", mCliente.Edad);
                    Comando.Parameters.AddWithValue("@direccion", mCliente.Direccion);
                    Comando.Parameters.AddWithValue("@telefono", mCliente.Telefono);
                    Comando.Parameters.AddWithValue("@sexo", mCliente.Sexo);
                    Comando.Parameters.AddWithValue("@fechaRegistro", mCliente.fechaRegistro);
                    Comando.Parameters.AddWithValue("@estado", mCliente.Estado);
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
