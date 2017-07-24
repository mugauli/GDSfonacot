using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDSfonacotDatos.DTO
{
    public class DatosBuscarSupervision
    {
        public int IdSupervisiones { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public string NoSupervision { get; set; }
        public Nullable<System.DateTime> FechaSupervision { get; set; }
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
        public Nullable<int> Idusuariocreador { get; set; }
        public Nullable<int> Idstatus { get; set; }
        public Nullable<int> Idsupervisor1 { get; set; }
        public Nullable<int> Idsupervisor2 { get; set; }
        public short NoSucursal { get; set; }
        public string DireccionRegional { get; set; }
        public string DescripcionSucursal { get; set; }
        public string Dirección { get; set; }
        public string Representaciones { get; set; }
        public string Director_Regional { get; set; }
        public string Director_Estatal { get; set; }
        public string Coordinador_Administrativo { get; set; }
        public string Coordinador_Crédito { get; set; }
        public string Coordinador_Cobranza { get; set; }
        public string Supervisor1 { get; set; }
        public string Supervisor2 { get; set; }

    }
    
}
