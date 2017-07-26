using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDSfonacotDatos;
using GDSfonacotDatos.DTO;
using GDSfonacotDatos.Data;

namespace GDSfonacot.forms
{
    public partial class frmSeguimiento : Form
    {
        private int saveorupdate = 0;
        public int idsup = 0;
        public String valor2 = "";
        public int idseg = 0;
        public frmSeguimiento(int actualizarconst)
        {
            InitializeComponent();
            saveorupdate = actualizarconst;
        }

        private void frmSeguimiento_Load(object sender, EventArgs e)
        {

            if (saveorupdate == 0)
            {
                
                toolButNuevo.Enabled = false;
                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = false;
                LlenarDatos();
                txthidIdSegui.Text = "0";
            }
            else
            {
                CargarSeguimientoSup();
                toolButNuevo.Enabled = false;
                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = true;
            }

        }

        private void CargarSeguimientoSup()
        {
            var objSeguimiento = new SeguimientosData();
            var busqueda = objSeguimiento.ObtenerDatosSeguimientoSupervision(idsup,idseg);
            if (busqueda.Result != null)
            {
                txthidIdSup.Text = busqueda.Result.Idsupervision.ToString();
                txthidIdSegui.Text = busqueda.Result.Idseguimiento.ToString();
                txtNoSupervision.Text = busqueda.Result.NoSupervision.ToString();
                txtDireccionRegional.Text = (busqueda.Result.Director_Regional != null ? busqueda.Result.Director_Regional.ToString() : "");
                txtDirectorEstatal.Text = (busqueda.Result.Director_Estatal != null ? busqueda.Result.Director_Estatal.ToString() : "");
                txtSucursal.Text = busqueda.Result.NoSucursal.ToString() + "- " + busqueda.Result.DescripcionSucursal.ToString();
                txtInmuble.Text = busqueda.Result.Inmueble.ToString();
                txtGestionDireccion.Text = busqueda.Result.Gestion_direccion.ToString();
                txtOriginacion.Text = busqueda.Result.Originacion.ToString();
                txtTarjetasTransfer.Text = busqueda.Result.Tarjetas_transfer.ToString();
                txtCredito.Text = busqueda.Result.Credito.ToString();
                txtUtys.Text = busqueda.Result.Utys.ToString();
                txtPromocionales.Text = busqueda.Result.Promocionales.ToString();
                txtCobranza.Text = busqueda.Result.Cobranza.ToString();
                txtFondoFijo.Text = busqueda.Result.Fondofijo.ToString();
                txtAcuerdosCompromisos.Text = busqueda.Result.AcuerdosCompromisos.ToString();
                dtfechaSeguimiento.Value = busqueda.Result.FechaSeguimCreacion.Value;
               // txtNoOficio.Text = busqueda.Result.NoOficio.ToString();
               // txthidStatus.Text = busqueda.Result.Idstatus.ToString();
                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = false;

            }

        }

        private void toolButNuevo_Click(object sender, EventArgs e)
        {
            toolButNuevo.Enabled = false;

            toolButGuardar.Enabled = true;
            toolButImprimir.Enabled = false;
            LimpiarDatos();
            txthidIdSegui.Text = "0";

        }

        private void toolButGuardar_Click(object sender, EventArgs e)
        {

            if (validarDatos())
            {
                return;
            }
            if (validarlongitudDatos())
            {
                return;
            }

            // MessageBox.Show("pASO VALIDACION");
            if (MessageBox.Show("¿La información es correcta? por favor verifique antes de ser registrada", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ;// Mensaje en pantallas)
                var objSeguimiento = new SeguimientoSupervision_Supervisores();
                objSeguimiento.Idseguimiento = Convert.ToInt32(txthidIdSegui.Text.ToString());
                objSeguimiento.Idsupervision = Convert.ToInt32(txthidIdSup.Text.ToString());
                objSeguimiento.Inmueble = txtInmuble.Text.Trim();
                objSeguimiento.Gestion_direccion = txtGestionDireccion.Text.Trim();
                objSeguimiento.Originacion = txtOriginacion.Text.Trim();
                objSeguimiento.Tarjetas_transfer = txtTarjetasTransfer.Text.Trim();
                objSeguimiento.Credito = txtCredito.Text.Trim();
                objSeguimiento.Utys = txtUtys.Text.Trim();
                objSeguimiento.Promocionales = txtPromocionales.Text.Trim();
                objSeguimiento.Cobranza = txtCobranza.Text.Trim();
                objSeguimiento.Fondofijo = txtFondoFijo.Text.Trim();
                objSeguimiento.AcuerdosCompromisos = txtAcuerdosCompromisos.Text.Trim();
                objSeguimiento.IdusuarioCreador = Globales.objpasardatosusuario.IdUsuario;
                objSeguimiento.FechaSeguimCreacion = dtfechaSeguimiento.Value;
                objSeguimiento.FechaCreacion = DateTime.Now;
                var gdSeguimiento = new SeguimientosData().GuadarSeguimiento(objSeguimiento);
                if (gdSeguimiento.Code != 0)
                {
                    //Mensage de error con g
                    toolButNuevo.Enabled = false;
                    toolButGuardar.Enabled = true;
                    MessageBox.Show(gdSeguimiento.Message.ToString(), System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    toolButImprimir.Enabled = false;

                }
                else
                {
                    toolButNuevo.Enabled = false;
                    toolButGuardar.Enabled = false;
                    toolButImprimir.Enabled = true;
                    MessageBox.Show("El Seguimiento ha sido guardado correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatos();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("El Seguimiento no fue guardado, por favor intente nuevamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                toolButNuevo.Enabled = false;
                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = false;
            }


        }
        private bool validarDatos()
        {

            if (string.IsNullOrEmpty(txtInmuble.Text.Trim()) || txtInmuble.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion del Inmueble", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInmuble.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtGestionDireccion.Text.Trim()) || txtGestionDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de gestión de la dirección", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGestionDireccion.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtOriginacion.Text.Trim()) || txtOriginacion.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de Originación", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOriginacion.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtTarjetasTransfer.Text.Trim()) || txtTarjetasTransfer.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de Tarjetas transfer", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTarjetasTransfer.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtCredito.Text.Trim()) || txtCredito.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de Crédito", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCredito.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtUtys.Text.Trim()) || txtUtys.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de UTYS", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUtys.Focus();
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

            if (string.IsNullOrEmpty(txtFondoFijo.Text.Trim()) || txtFondoFijo.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de fondo fijo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFondoFijo.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtAcuerdosCompromisos.Text.Trim()) || txtAcuerdosCompromisos.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de fondo fijo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAcuerdosCompromisos.Focus();
                return true;
            }


            return false;
        }

        private bool validarlongitudDatos()
        {
            int longitud = Globales.longitudChars;

            if (txtInmuble.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtInmuble.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInmuble.Focus();
                return true;
            }
            if (txtGestionDireccion.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtGestionDireccion.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGestionDireccion.Focus();
                return true;
            }
            if (txtOriginacion.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtOriginacion.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOriginacion.Focus();
                return true;
            }
            if (txtOriginacion.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtOriginacion.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOriginacion.Focus();
                return true;
            }
            if (txtTarjetasTransfer.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtTarjetasTransfer.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTarjetasTransfer.Focus();
                return true;
            }
            if (txtCredito.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtCredito.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCredito.Focus();
                return true;
            }
            if (txtUtys.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtUtys.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUtys.Focus();
                return true;
            }
            if (txtPromocionales.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtPromocionales.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPromocionales.Focus();
                return true;
            }
            if (txtCobranza.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtCobranza.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCobranza.Focus();
                return true;
            }
            if (txtFondoFijo.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtFondoFijo.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFondoFijo.Focus();
                return true;
            }
            if (txtAcuerdosCompromisos.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtAcuerdosCompromisos.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAcuerdosCompromisos.Focus();
                return true;
            }

            return false;
        }

        private void LimpiarDatos()
        {
            txthidIdSegui.Text = "0";
            txtNoSupervision.Text = String.Empty;
            dtfechaSeguimiento.Value = DateTime.Now;
            txtInmuble.Text = String.Empty;
            txtGestionDireccion.Text = String.Empty;
            txtOriginacion.Text = String.Empty;
            txtTarjetasTransfer.Text = String.Empty;
            txtCredito.Text = String.Empty;
            txtUtys.Text = String.Empty;
            txtPromocionales.Text = String.Empty;
            txtCobranza.Text = String.Empty;
            txtFondoFijo.Text = String.Empty;
            txtAcuerdosCompromisos.Text = String.Empty;
           // toolButNuevo.Enabled = false;
            //toolButGuardar.Enabled = true;
          
        }

        private void LlenarDatos()
        {
            int[] varstatus = { 1, 2 };
            var objSupervision = new SupervisionesData();
            var busqueda = objSupervision.ObtenerDatosSupervision(idsup,valor2,varstatus);
            if (busqueda.Result != null)
            {
                txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();
                txthidIdSegui.Text = "0";
                txtNoSupervision.Text = busqueda.Result.NoSupervision.ToString();
                txtDireccionRegional.Text = (busqueda.Result.Director_Regional != null ? busqueda.Result.Director_Regional.ToString() : "");
                txtDirectorEstatal.Text = (busqueda.Result.Director_Estatal != null ? busqueda.Result.Director_Estatal.ToString() : "");
                txtSucursal.Text = busqueda.Result.NoSucursal.ToString() + "- " + busqueda.Result.DescripcionSucursal.ToString();
                txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();
                txthidstatus.Text = busqueda.Result.Idstatus.ToString();
                txtSupervisor1.Text = busqueda.Result.Supervisor1.ToString();
                txtSupervisor2.Text = busqueda.Result.Supervisor2.ToString();
                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = false;

            }
        }

        private void toolButImprimir_Click(object sender, EventArgs e)
        {
            forms.FormVisorConsultarSupervCR frmvisor = new forms.FormVisorConsultarSupervCR(4);//crea una instancia del formulario

            frmvisor.param1 = txthidIdSup.Text;
            frmvisor.param2 = txthidIdSegui.Text;
            frmvisor.ShowDialog();

        }

        
    }
}

