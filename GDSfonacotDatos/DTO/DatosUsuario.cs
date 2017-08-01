using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDSfonacotDatos.DTO;
using static GDSfonacotDatos.Utilities.Util;


namespace GDSfonacotDatos.DTO
{
    public class DatosUsuario
    {
        public int IdUsuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public Nullable<int> IdNivel { get; set; }
        public Nullable<System.DateTime> fechaalta { get; set; }
        public Nullable<System.DateTime> fechabaja { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public string DescripcionSucursal { get; set; }
        public string NivelUsuarioDescrip { get; set; }
        public Nullable<System.DateTime> fechareingreso { get; set; }
        public Nullable<int> IdsucursalPadre { get; set; }
    }
}
