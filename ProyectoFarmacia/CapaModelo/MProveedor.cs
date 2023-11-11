using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class MProveedor
    {
        public int IdProveedor { get; set; }
        public string nombreCompañia { get; set; }
        public int IdTrabajador { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaUltimoPedido { get; set; }
        public string Estado { get; set; }
    }
}
