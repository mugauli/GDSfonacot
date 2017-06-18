using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDSfonacotDatos.DTO
{
    public class DatosGridSupervisiones
    {
        public int IdSupervisiones { get; set; }
        public string NoSupervision { get; set; }
        public Nullable<System.DateTime> FechaSupervision { get; set; }
        public string DescripcionSucursal { get; set; }

    }
}
