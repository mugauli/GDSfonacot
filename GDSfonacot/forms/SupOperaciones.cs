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
            LoadingCatSupervisor2();
            LoadingCatSupervisor1();



        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void toolButNuevo_Click(object sender, EventArgs e)
        {
            toolButNuevo.Enabled = false;
            txthidIdSup.Text = "0";
             toolButGuardar.Enabled = true;


        }

        private void toolButGuardar_Click(object sender, EventArgs e)
        {

            if (validarDatos())
            {
               return;
            }

           // MessageBox.Show("pASO VALIDACION");

            var objSupervision = new HistorialSupervisiones();

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
            objSupervision.IdSupervisiones = Convert.ToInt32(txthidIdSup.Text.Trim());
            objSupervision.IdSucursal = Convert.ToInt32(cmbSucursales.SelectedValue);
            objSupervision.NoSupervision = txtNoSupervision.Text.Trim();
            objSupervision.FechaSupervision = dtFechaSupervision.Value;
            objSupervision.Inmueble = txtInmueble.Text.Trim();
            objSupervision.Gestion_direccion = txtGesDireccion.Text.Trim();
            objSupervision.Originacion = txtOriginacion.Text.Trim();
            objSupervision.Tarjetas_transfer = txtTransfer.Text.Trim();
            objSupervision.Credito = txtCredito.Text.Trim();
            objSupervision.Utys = txtUTYS.Text.Trim();
            objSupervision.Promocionales =txtPromocionales.Text.Trim();
            objSupervision.Cobranza = txtCobranza.Text.Trim();
            objSupervision.Fondofijo = txtFonFijo.Text.Trim();
            objSupervision.AcuerdosCompromisos = textAcuerdosCompr.Text.Trim();
            objSupervision.Idusuariocreador = Globales.objpasardatosusuario.IdUsuario;
            objSupervision.Idstatus = 1;
            objSupervision.Idsupervisor1 = Convert.ToInt32(cmbSupervisor1.SelectedValue);
            objSupervision.Idsupervisor2 = Convert.ToInt32(cmbSupervisor2.SelectedValue);
            objSupervision.Fechacreacion = DateTime.Now;
            var gdSupervisiones = new SupervisionesData().GuardarSupervision(objSupervision);

            if (gdSupervisiones.Code != 0)
            {
                //Mensage de error con g
                toolButNuevo.Enabled = false;
                toolButGuardar.Enabled = true;
                MessageBox.Show(gdSupervisiones.Message.ToString());
            }
            else {
                toolButNuevo.Enabled = true;
                toolButGuardar.Enabled = false;
                MessageBox.Show("La supervision ha sido guardada correctamente");
            }

        }
        private bool validarDatos()
        {
            if (cmbSucursales.SelectedIndex <= -1)
            {
                MessageBox.Show("Selecciona una Sucursal", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbSucursales.Focus();
                return true;              
            }

            if (string.IsNullOrEmpty(txtNoSupervision.Text.Trim()) || txtNoSupervision.Text.Trim()=="")
            {
                MessageBox.Show("Ingresa un numero de supervision", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNoSupervision.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(cmbSupervisor1.Text.Trim()) || cmbSupervisor1.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa el nombre del supervisor 1", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbSupervisor1.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(cmbSupervisor2.Text.Trim()) || cmbSupervisor2.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa el nombre del supervisor 2", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbSupervisor2.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtInmueble.Text.Trim()) || txtInmueble.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion del Inmueble", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInmueble.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtGesDireccion.Text.Trim()) || txtGesDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de gestión de la dirección", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGesDireccion.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtOriginacion.Text.Trim()) || txtOriginacion.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de Originación", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOriginacion.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtTransfer.Text.Trim()) || txtTransfer.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de Tarjetas transfer", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTransfer.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtCredito.Text.Trim()) || txtCredito.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de Crédito", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCredito.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtUTYS.Text.Trim()) || txtUTYS.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de UTYS", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUTYS.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtPromocionales.Text.Trim()) || txtPromocionales.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de promocionales", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPromocionales.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtCobranza.Text.Trim()) || txtCobranza.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de cobranza", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCobranza.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtFonFijo.Text.Trim()) || txtFonFijo.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de fondo fijo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFonFijo.Focus();
                return true;
            }


            return false;
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

        private void LoadingCatSupervisor1()
        {
            var sucursales = new SupervisionesData().ObtenerSupervisores();
            if (sucursales.Code != 0)
            {
                //Mandar mensaje de error con sucursales.Message
            }

            cmbSupervisor1.DataSource = sucursales.Result;
            cmbSupervisor1.DisplayMember = "Nombre_Usuario";
            cmbSupervisor1.ValueMember = "IdUsuario";
            cmbSupervisor1.SelectedIndex = -1;
        }

        private void LoadingCatSupervisor2()
        {
            var sucursales = new SupervisionesData().ObtenerSupervisores();
            if (sucursales.Code != 0)
            {
                //Mandar mensaje de error con sucursales.Message
            }

            cmbSupervisor2.DataSource = sucursales.Result;
            cmbSupervisor2.DisplayMember = "Nombre_Usuario";
            cmbSupervisor2.ValueMember = "IdUsuario";
            cmbSupervisor2.SelectedIndex = -1;
        }
    }
   
}
