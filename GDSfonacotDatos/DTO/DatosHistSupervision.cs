using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDSfonacotDatos.DTO
{
    public class DatosHistSupervision
    {
        public int Idcontestacion { get; set; }
        public Nullable<int> Idsupervision { get; set; }
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
        public string NoOficio { get; set; }
        public Nullable<int> Idstatus { get; set; }
        //Datos de la sucursal
        public short NoSucursal { get; set; }
        public string DireccionRegional { get; set; }
        public string DescripcionSucursal { get; set; }
        public string Supervisor1 { get; set; }
        public string Supervisor2 { get; set; }
        public string Dirección { get; set; }
        public string Representaciones { get; set; }
        public string Director_Regional { get; set; }
        public string Director_Estatal { get; set; }
        public string Coordinador_Administrativo { get; set; }
        public string Coordinador_Crédito { get; set; }
        public string Coordinador_Cobranza { get; set; }
        public Nullable<short> Analistas { get; set; }
        public Nullable<short> Ventanillas { get; set; }
        public Nullable<short> Analistas_Otorgamiento_de_Crédito { get; set; }
        public Nullable<short> Analistas_Administrativo_y_SAM { get; set; }
        public Nullable<short> Analistas_Crédito_Control_Documental { get; set; }
        public Nullable<short> Analistas_Cobranza { get; set; }
        public byte[] Fotografia { get; set; }
        public Nullable<int> Empresas_Afiliadas { get; set; }
        public Nullable<int> Trabajadores_Afiliados { get; set; }
        public Nullable<int> Potencial_de_Empresas { get; set; }
        public Nullable<int> Potencial_de_Trabajadores { get; set; }
        public Nullable<int> Empresas_Status_1 { get; set; }
        public Nullable<int> Empresas_Status_18 { get; set; }
        public Nullable<int> Empresas_Status_21 { get; set; }
        public Nullable<int> Empresas_Status_30 { get; set; }
        public Nullable<decimal> Meta_Anual { get; set; }
        public Nullable<decimal> Meta_Mensual { get; set; }
        public Nullable<decimal> Colocación_Anual { get; set; }
        public Nullable<decimal> Colocación_Mensual { get; set; }
        public Nullable<System.DateTime> Fecha_baja { get; set; }
        public Nullable<decimal> Meta_Acumulada_Porcentaje { get; set; }
        public string Cobranza_Meta_Anual { get; set; }
        public string Cobranza_Porcentaje_Meta { get; set; }
        public string Cobranza_Cumplimiento_Meta { get; set; }
        public Nullable<int> IdRegional { get; set; }

    }
}
