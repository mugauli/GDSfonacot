using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDSfonacotDatos.DTO
{
   public class DatosSupervisores
    {
        public int IdUsuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public Nullable<int> IdNivel { get; set; }
    }
}
