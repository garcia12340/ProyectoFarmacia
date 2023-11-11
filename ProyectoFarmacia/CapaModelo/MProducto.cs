using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class MProducto
    {
        public int IdProducto { get; set; }
        public string nombreProducto { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoProducto { get; set; }
        public int IdProveedor { get; set; }
        public int IdRubro { get; set; }
        public int IdPresentacion { get; set; }
        public string Concentracion { get; set; }
        public string unidadMedida { get; set; }
        public int stockMinimo { get; set; }
        public int stockActual { get; set; }
        public int stockMaximo { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaFabricacion { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public decimal precioCompra { get; set; }
        public decimal margenGanancias { get; set; }
        public decimal precioVenta { get; set; }
        public string estadoProducto { get; set; }
    }
}
