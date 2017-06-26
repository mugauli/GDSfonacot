using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDSfonacotDatos.DTO
{
    public class DatosUsuario
    {
        public int IdUsuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public Nullable<int> IdNivel { get; set; }
        public System.DateTime fechaalta { get; set; }
        public Nullable<System.DateTime> fechabaja { get; set; }
        public Nullable<int> IdSucursal { get; set; }
    }
}
