using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDSfonacotDatos.DTO
{
    public class DatosBuscarSeguimiento
    {
        public int Idseguimiento { get; set; }
        public Nullable<int> Idsupervision { get; set; }
        public string Inmueble { get; set; }
        public string Gestion_direccion { get; set; }
        public string Originacion { get; set; }
        public string Tarjetas_transfer { get; set; }
        public string Credito { get; set; }
        public string Utys { get; set; }
        public string Promocionales { get; set; }
        public string Cobranza { get; set; }
        public string Fondofijo { get; set; }
        public string AcuerdosCompromisos { get; set; }
        public Nullable<int> IdusuarioCreador { get; set; }
        public Nullable<System.DateTime> FechaSeguimCreacion { get; set; }
        public string DescripcionSucursal { get; set; }
        public string Director_Regional { get; set; }
        public string Director_Estatal { get; set; }
        public string DireccionRegional { get; set; }
        public string NoSupervision { get; set; }
        public short NoSucursal { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }

    }
}
