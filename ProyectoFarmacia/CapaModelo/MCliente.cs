using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class MCliente
    {
        public int IdCliente { get;set; }
        public string primerNombre { get;set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public int Edad { get; set; }   
        public string Direccion { get;set;}
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public DateTime fechaRegistro { get; set; } 
        public string Estado { get; set; }  

    }
}
