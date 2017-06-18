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
            LoadingCatSucursales();//load sucursales list of table
         

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void toolButNuevo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nuevo");


        }

        private void toolButGuardar_Click(object sender, EventArgs e)
        {

            if (validarDatos())
            {
               return;
            }

            MessageBox.Show("pASO VALIDACION");

            //var objSupervision = new Historial_de_Supervisiones();

            //objSupervision.IdSucursal = Convert.ToInt32(cmbSucursales.SelectedValue);
            //objSupervision.NoSupervision = txtNoSupervision.Text.Trim();
            //objSupervision.FechaSupervision = dtFechaSupervision.Value;
            //objSupervision.AfiliacionOtorgamientoCredito = "";
            //objSupervision.ActividadesPromocionAfiliaciónCT = "";
            //objSupervision.ProcesoCobranza = "";
            //objSupervision.Revisión_de_UTYS = "";
            //objSupervision.Situaciones_de_Orden_General_e_Infraestructura = "";
            //objSupervision.AcuerdosCompromisos = "";
            //objSupervision.No_de_Respuesta_Supervision = "";
            //objSupervision.FechaRespuestaSupervision = DateTime.Now;
            //objSupervision.Seguimiento_a_la_Supervisión = "";
            //objSupervision.Respuesta_Supervision = "";
            //objSupervision.Solventada = false;
            //objSupervision.IdSupervisor1 = 1;
            //objSupervision.IdSupervisor2 = 1;
            //objSupervision.NoOficio = "23";

            //var gdSupervisiones = new SupervisionesData().GuardarSupervision(objSupervision);

            //if (gdSupervisiones.Code != 0)
            //{
            //    //Mensage de error con g
            //}
        }
        private bool validarDatos()
        {
            if (cmbSucursales.SelectedIndex <= -1)
            {
                MessageBox.Show("Selecciona una Sucursal", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbSucursales.Focus();
                return true;              
            }



            return  false;
        }

        private void LoadingCatSucursales()
        {
            var sucursales = new SupervisionesData().ObtenerSucursalesCombo();
            if (sucursales.Code != 0)
            {
                //Mandar mensaje de error con sucursales.Message
            }

            cmbSucursales.DataSource = sucursales.Result;
            cmbSucursales.DisplayMember = "NameSucursal";
            cmbSucursales.ValueMember = "IdSucursal";
            cmbSucursales.SelectedIndex = -1;
        }
    }
   
}
