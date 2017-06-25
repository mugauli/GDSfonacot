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
            toolButImprimir.Enabled = false;
            LimpiarDatos();

        }

        private void toolButGuardar_Click(object sender, EventArgs e)
        {

            if (validarDatos())
            {
               return;
            }

                                                                                                                                                                                         // MessageBox.Show("pASO VALIDACION");
            if (MessageBox.Show("¿La información es correcta? por favor verifique antes de ser registrada", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {;// Mensaje en pantallas)
                var objSupervision = new HistorialSupervisiones();
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
                objSupervision.Promocionales = txtPromocionales.Text.Trim();
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
                    MessageBox.Show(gdSupervisiones.Message.ToString(),System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    toolButImprimir.Enabled = false;

                }
                else
                {
                    toolButNuevo.Enabled = true;
                    toolButGuardar.Enabled = false;
                    toolButImprimir.Enabled = true;
                    MessageBox.Show("La supervision ha sido guardada correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("La supervision no fue guardada, por favor intente nuevamente",System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                toolButNuevo.Enabled = false;
                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = false;
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
        private void LimpiarDatos()
        {
            txthidIdSup.Text = String.Empty;
            cmbSucursales.SelectedIndex = -1;
            txtNoSupervision.Text=String.Empty;
            dtFechaSupervision.Value=DateTime.Now;
            txtInmueble.Text = String.Empty;
            txtGesDireccion.Text = String.Empty;
            txtOriginacion.Text = String.Empty;
            txtTransfer.Text = String.Empty;
            txtCredito.Text = String.Empty;
            txtUTYS.Text = String.Empty;
            txtPromocionales.Text = String.Empty;
            txtCobranza.Text = String.Empty;
            txtFonFijo.Text = String.Empty;
            textAcuerdosCompr.Text = String.Empty;
            cmbSupervisor1.SelectedIndex = -1;
            cmbSupervisor2.SelectedIndex = -1;


        }

        private void ConsultarDatos(String Nosupervision)
        {
            LimpiarDatos();
            var objSupervision = new SupervisionesData();
            var busqueda = objSupervision.BuscarSupervision(Nosupervision);
            if (busqueda.Result!=null)
            {
                txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();
                cmbSucursales.SelectedValue = busqueda.Result.IdSucursal;
                txtNoSupervision.Text = busqueda.Result.NoSupervision.ToString();
                dtFechaSupervision.Value = busqueda.Result.FechaSupervision.Value;
                txtInmueble.Text = busqueda.Result.Inmueble.ToString();
                txtGesDireccion.Text = busqueda.Result.Gestion_direccion.ToString();
                txtOriginacion.Text = busqueda.Result.Originacion.ToString();
                txtTransfer.Text = busqueda.Result.Tarjetas_transfer.ToString();
                txtCredito.Text = busqueda.Result.Credito.ToString();
                txtUTYS.Text = busqueda.Result.Utys.ToString();
                txtPromocionales.Text = busqueda.Result.Promocionales.ToString();
                txtCobranza.Text = busqueda.Result.Cobranza.ToString();
                txtFonFijo.Text = busqueda.Result.Fondofijo.ToString();
                textAcuerdosCompr.Text = busqueda.Result.AcuerdosCompromisos.ToString();
                cmbSupervisor1.SelectedValue = busqueda.Result.Idsupervisor1;
                cmbSupervisor2.SelectedValue = busqueda.Result.Idsupervisor2;
                toolButNuevo.Enabled = false;
                toolButGuardar.Enabled = true;
               
                toolButImprimir.Enabled = true;
            }
            else
            {
                MessageBox.Show(busqueda.Message.ToString());
                MessageBox.Show("No se encontro la supervision requerida");
                toolButNuevo.Enabled = true;
                toolButGuardar.Enabled = false;

                toolButImprimir.Enabled =false;
            }



        }

        private void toolButImprimir_Click(object sender, EventArgs e)
        {
            forms.FormVisorConsultarSupervCR frmvisor = new forms.FormVisorConsultarSupervCR();//crea una instancia del formulario

            frmvisor.valor = txtNoSupervision.Text.Trim();
            //frmvisor.MdiParen8t = MDIPrincip();
            frmvisor.ShowDialog();
            
        }

        private void txtNoSupervision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ConsultarDatos(txtNoSupervision.Text.Trim());
            }
        }
    }
   
}
