using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDSfonacotDatos.DTO
{
    public class DatosComboSucursales
    {
        
        public int IdSucursal { get; set; }
        [DisplayName("Sucursal")]
        public String NameSucursal { get; set; }
        public short NoSucursal { get; set; }
        public String DireccionRegional { get; set; }


    }
}
