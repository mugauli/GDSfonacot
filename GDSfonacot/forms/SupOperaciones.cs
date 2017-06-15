using GDSfonacotDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDSfonacot
{
    public partial class SupOperaciones : Form
    {
        public SupOperaciones()
        {
            InitializeComponent();//



        }

        private void SupOperaciones_Load(object sender, EventArgs e)
        {

            var sucursales = new SupervisionesData().ObtenerSucursalesCombo();
            if (sucursales.Code != 0)
            {
                //Mandar mensaje de error con sucursales.Message
            }

            cmbSucursales.DataSource = sucursales.Result;
            cmbSucursales.DisplayMember = "NameSucursal";
            cmbSucursales.ValueMember = "IdSucursal";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var objSupervision = new Historial_de_Supervisiones();

            objSupervision.IdSucursal = Convert.ToInt32(cmbSucursales.SelectedValue);
            objSupervision.NoSupervision = "12";
            objSupervision.FechaSupervision = dtFechaSupervision.Value;
            objSupervision.AfiliacionOtorgamientoCredito = ""; 
            objSupervision.ActividadesPromocionAfiliaciónCT = "";
            objSupervision.ProcesoCobranza = "";
            objSupervision.Revisión_de_UTYS = "";
            objSupervision.Situaciones_de_Orden_General_e_Infraestructura = "";
            objSupervision.AcuerdosCompromisos = "";
            objSupervision.No_de_Respuesta_Supervision = "";
            objSupervision.FechaRespuestaSupervision = DateTime.Now;
            objSupervision.Seguimiento_a_la_Supervisión = "";
            objSupervision.Respuesta_Supervision = "";
            objSupervision.Solventada = false;
            objSupervision.IdSupervisor1 = 1;
            objSupervision.IdSupervisor2 = 1;
            objSupervision.NoOficio = "23";

            var gdSupervisiones = new SupervisionesData().GuardarSupervision(objSupervision);

            if (gdSupervisiones.Code != 0)
            {
                //Mensage de error con g
            }

        }


    }
}
