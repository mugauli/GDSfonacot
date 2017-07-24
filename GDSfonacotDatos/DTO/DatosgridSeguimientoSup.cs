using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDSfonacotDatos.DTO
{
    public class DatosgridSeguimientoSup
    {
        public int IdSupervisiones { get; set; }
        public int Idseguimiento { get; set; }
        public Nullable<System.DateTime> FechaSeguimCreacion { get; set; }
        public string NoSupervision { get; set; }
        public Nullable<System.DateTime> FechaSupervision { get; set; }
        public string DescripcionSucursal { get; set; }
        public string Estatus { get; set; }
    }
}
